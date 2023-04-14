import { Component } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { UserService } from 'src/app/core/services/user.service';
import {Router} from "@angular/router";
import {ToastrService} from "ngx-toastr";

@Component({
  selector: 'app-add-user',
  templateUrl: './add-user.component.html',
  styleUrls: ['./add-user.component.scss']
})
export class AddUserComponent {
  users: any[] = [];
  user: any;

  userForm: any;
  countries: any;

  constructor(
    private userService: UserService,
    private router: Router,
    private toastr: ToastrService
  ) {
  }

  ngOnInit(): void {
    this.userForm = new FormGroup({
      firstName: new FormControl('',  [Validators.required, Validators.maxLength(20)]),
      lastName: new FormControl('',  [Validators.required, Validators.maxLength(20)]),
      email: new FormControl('', [Validators.required, Validators.email, Validators.maxLength(30)]),
      phone: new FormControl('', [Validators.required, Validators.pattern(/^-?(0|[0-9]\d*)?$/), Validators.maxLength(20)]),
    });
  }

  onSubmit() {
    this.userService.createUser(this.userForm.value).subscribe(data => {
      this.toastr.success('User added successfully');

      this.router.navigate(['/users']);
    });
  }

  deleteUser(user: any){
  }

  get firstName() {
    return this.userForm.get('firstName');
  }

  get lastName() {
    return this.userForm.get('lastName');
  }

  get email() {
    return this.userForm.get('email');
  }

  get phone() {
    return this.userForm.get('phone');

  }
}
