import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { UserService } from 'src/app/core/services/user.service';

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
    private userService: UserService
  ) {
  }

  ngOnInit(): void {
    this.userForm = new FormGroup({
      firstName: new FormControl(''),
      lastName: new FormControl(''),
      email: new FormControl(''),
      phone: new FormControl(''),
    });
  }

  onSubmit() {
    this.userService.createUser(this.userForm.value).subscribe(data => {
 
    });
  }

  deleteUser(user: any){
  }
}
