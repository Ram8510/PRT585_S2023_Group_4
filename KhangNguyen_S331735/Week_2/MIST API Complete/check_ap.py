import os
import json
from datetime import datetime, timedelta


def check_last_modified(file_path):
    # Check if the file exists
    if not os.path.exists(file_path):
        print(f"File '{file_path}' does not exist.")
        return

    # Get the last modified timestamp of the file
    modified_time = os.path.getmtime(file_path)

    # Calculate the time difference
    current_time = datetime.now()
    last_modified_time = datetime.fromtimestamp(modified_time)
    time_difference = current_time - last_modified_time

    # Check if the file was last modified more than 1 day ago
    if time_difference > timedelta(days=1):
        # Read the JSON file
        with open(file_path, 'r') as file:
            data = json.load(file)

        # Change the value of all "Access Point Name" keys to "Unknown"
        for item in data:
            if 'Access Point Name' in item:
                item['Access Point Name'] = 'Unknown'

            # Check the "Connected" value and change it to "green" or "red"
            if 'Connected' in item:
                if item['Connected'] == True:
                    item['Connected'] = 'green'
                else:
                    item['Connected'] = 'red'

        # Write the modified data back to the JSON file
        with open(file_path, 'w') as file:
            json.dump(data, file, indent=4)

        print(
            f"File '{file_path}' was last modified more than 1 day ago. Changes made.")
    else:
        print(f"File '{file_path}' was last modified within 1 day.")



# Add the path file of the JSON file
file_path = '/Users/khangnguyen/Desktop/CDU/Year 2023/2023 SEM 1/PRT583/MIST API/MIST API Complete'
check_last_modified(file_path)
