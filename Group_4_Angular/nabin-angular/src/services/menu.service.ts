import { Injectable } from '@angular/core';
import axios from 'axios';
import { MenuDto } from '../models/menu.model';  // Assuming you have menu-dto.model.ts

@Injectable({
  providedIn: 'root'
})
export class MenuService {

  apiURL: string = 'https://localhost:7246/api/Menu'; // Replace with your API URL

  constructor() { }

  async getAllMenus(): Promise<MenuDto[]> {
    const response = await axios.get<MenuDto[]>(`${this.apiURL}`);
    return response.data;
  }

  async getMenuById(id: number): Promise<MenuDto> {
    const response = await axios.get<MenuDto>(`${this.apiURL}/${id}`);
    return response.data;
  }

  async createMenu(menu: MenuDto): Promise<void> {
    await axios.post(`${this.apiURL}`, menu);
  }

  async updateMenu(menu: MenuDto): Promise<void> {
    await axios.put(`${this.apiURL}/update`, menu);
  }

  async deleteMenu(id: number): Promise<void> {
    await axios.delete(`${this.apiURL}/${id}`);
  }
}
