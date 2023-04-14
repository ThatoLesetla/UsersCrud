import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, NgModel } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { UserService } from 'src/app/core/services/user.service';
import {User} from "../../core/models/User";

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit {
  page = 1;
  pageSize = 7;

  users: User[] = [];
  user: any;

  userForm: any;
  countries: any;

  constructor(
    private userService: UserService,
    private modalService: NgbModal
  ) {
  }

  ngOnInit(): void {
    this.userService.getAllUsers().subscribe((data: User[]) => {
      this.users = data;
    })
  }

  onSubmit() {
  }



  deleteUser(user: any){
  }
}
