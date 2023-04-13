import { Component } from '@angular/core';
import { Menu } from 'src/app/config/menu';

@Component({
  selector: 'app-sidebar',
  templateUrl: './sidebar.component.html',
  styleUrls: ['./sidebar.component.scss']
})
export class SidebarComponent {

  menuItems = Menu;

  constructor() {

  }
}
