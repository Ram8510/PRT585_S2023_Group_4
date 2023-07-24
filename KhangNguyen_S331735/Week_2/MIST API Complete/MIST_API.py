import requests
import json
import os
from pprint import pp
import config

def main():
    org_id = "04263b80-a1f0-43b4-ac30-08862e640606"
    site_id = "4744b216-eafa-44a4-8cfb-4862eea4b434"
    headers = {
        'Authorization': f'Token {config.MIST_API_KEY}',
        'Content-Type': 'application/json'
    }
    ## ----- Fixed mist URL---- #####
    mist_url = "https://api.mist.com/api/v1/"
    ## ---------------------------------------------------------####

    #Finding the  'connected' status with each of the id
    connection_url = '{0}orgs/{1}/inventory'.format(mist_url, org_id)
    response3 = requests.get(connection_url, headers=headers)
    inventory_of_devices = response3.json()

    inventory_dictionary = {}
    for device in inventory_of_devices:
        if 'connected' in device:
            inventory_dictionary[device["id"]] = device['connected']

    # Retrieve all sites
    all_sites_url = f'{mist_url}orgs/{org_id}/sites'
    sites_req = requests.get(all_sites_url, headers=headers)

    sites_req.raise_for_status()

    device_output_list = []  # Save the list of all information in here
    site_output_list = []  # Save the list of site in here

    for site in sites_req.json():
        # pp(site['name'])

        access_point_url = f'{mist_url}sites/{site["id"]}/devices'
        response2 = requests.get(access_point_url, headers=headers)

        site_output_list.append(
            {"Site": site['name']}
        )

        if response2.status_code == 200:
            devices = response2.json()
            # devices = json.loads(response2.content.decode('utf-8'))

            for device in devices:

                connected_status = inventory_dictionary[device["id"]]

                # json_string = {}
                json_data = {
                    "Access Point Name": device['name'],
                    "Site": site['name'],
                    "Connected": connected_status
                }
                device_output_list.append(json_data)

                print(f'added device to list {device["name"]}')

    with open("mist_data.json", "w") as f:
        s = json.dumps(device_output_list, indent=2)
        f.write(s)
        print("saved success")

    with open("site_name_data.json", "w") as outfile:
        outfile.write(
            json.dumps(site_output_list, indent=2)
        )


if __name__ == '__main__':
    main()
