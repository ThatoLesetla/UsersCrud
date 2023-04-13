import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, NgModel } from '@angular/forms';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { UserService } from 'src/app/core/services/user.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit {
  page = 1;
  pageSize = 7;

  users: any[] = [];
  user: any;

  userForm: any;
  countries: any;

  constructor(
    private userService: UserService,
    private modalService: NgbModal
  ) {
  }

  ngOnInit(): void {
    this.userForm = new FormGroup({
      firstName: new FormControl(''),
      lastName: new FormControl(''),
      email: new FormControl(''),
      phone: new FormControl('')
    });
  }

  onSubmit() {
    this.userService.createUser(this.userForm.value).subscribe(data => {
 
    });
  }


  openModal(content: any, user: any) {
    this.user = user;
    this.modalService.open(content, { size: 'lg' });
  }

  addUser(content: any) {
    this.modalService.open(content, { size: 'lg' });
  }

  deleteUser(user: any){
  }
}
