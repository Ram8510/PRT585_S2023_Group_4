import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
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

  constructor(private menuService: MenuService, private fb: FormBuilder, private toastr: ToastrService) { }

  menuForm = this.fb.group({
    MenuName: ['', [Validators.required, Validators.minLength(1), Validators.maxLength(100)]]
  });

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
    this.menuForm.patchValue({
      MenuName: this.selectedMenu.MenuName // assuming 'name' is a field in MenuDto
    });
  }

  async onSubmit() {
    if (this.menuForm.invalid) {
      this.toastr.error('Invalid form data');
      return;
    }
  
    try {
      // Capture the form value
      const formValue = this.menuForm.value;
  
      // Update selectedMenu based on the form value
      this.selectedMenu.MenuName = formValue.MenuName ?? undefined;
  
      if (this.selectedMenu.MenuId) {
        // If MenuId exists, update the menu
        await this.menuService.updateMenu(this.selectedMenu);
        this.toastr.success('Menu successfully updated');
      } else {
        // Otherwise, create a new menu
        await this.menuService.createMenu(this.selectedMenu);
        this.toastr.success('Menu successfully created');
      }
  
      // Close the form and reload the menu list
      this.showForm = false;
      this.menus = await this.menuService.getAllMenus();
  
      // Reset the form and selectedMenu
      this.menuForm.reset();
      this.selectedMenu = new MenuDto();
  
    } catch (error) {
      this.toastr.error('An error occurred');
    }
  }
  

  async deleteMenu(id: number) {
    try {
      await this.menuService.deleteMenu(id);
      this.menus = await this.menuService.getAllMenus();
      this.toastr.success('Menu deleted');
    } catch (error) {
      this.toastr.error('Failed to delete menu');
    }
  }

  cancelForm() {
    this.showForm = false;
  }
}
