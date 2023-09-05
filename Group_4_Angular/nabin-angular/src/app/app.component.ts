import { Component, OnInit } from '@angular/core';
import { MenuService } from '../services/menu.service';
import { MenuDto } from 'src/models/menu.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  
  menus: MenuDto[] = [];
  showForm = false;
  formTitle = "Create Menu";
  selectedMenu: MenuDto = new MenuDto();

  constructor(private menuService: MenuService) { }

  async ngOnInit() {
    this.menus = await this.menuService.getAllMenus();
  }

  showCreateMenuForm() {
    this.showForm = true;
    this.formTitle = "Create Menu";
    this.selectedMenu = new MenuDto();
  }

  showEditMenuForm(menu: MenuDto) {
    this.showForm = true;
    this.formTitle = "Edit Menu";
    this.selectedMenu = { ...menu };
  }

  async onSubmit() {
    if (this.selectedMenu.MenuId) {
      await this.menuService.updateMenu(this.selectedMenu);
    } else {
      await this.menuService.createMenu(this.selectedMenu);
    }
    this.showForm = false;
    this.menus = await this.menuService.getAllMenus();
  }

  async deleteMenu(id: number) {
    await this.menuService.deleteMenu(id);
    this.menus = await this.menuService.getAllMenus();
  }

  cancelForm() {
    this.showForm = false;
  }
}
