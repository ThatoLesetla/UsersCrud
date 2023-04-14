import { Component } from '@angular/core';
import {FormControl, FormGroup, Validators} from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Student } from 'src/app/core/models/Student';
import { StudentService } from 'src/app/core/services/student.service';

@Component({
  selector: 'app-add-student',
  templateUrl: './add-student.component.html',
  styleUrls: ['./add-student.component.scss']
})
export class AddStudentComponent {
  userForm: any;
  countries: any;

  studId: string = '';

  constructor(
    private studentService: StudentService,
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private toastr: ToastrService
  ) {
    this.activatedRoute.params.subscribe((data: any) => {
      if (data.id !== undefined) {

        this.studId = data.id;
      }
    });
  }

  ngOnInit(): void {
    this.userForm = new FormGroup({
      firstName: new FormControl('',  [Validators.required, Validators.maxLength(20)]),
      lastName: new FormControl('',  [Validators.required, Validators.maxLength(20)]),
      email: new FormControl('', [Validators.required, Validators.email, Validators.maxLength(30)]),
      phone: new FormControl('', [Validators.required, Validators.pattern(/^-?(0|[0-9]\d*)?$/), Validators.maxLength(20)]),
      bio: new FormControl('', [Validators.required]),
      country: new FormControl('', [Validators.required]),
      province: new FormControl('', [Validators.required]),
      city: new FormControl('', [Validators.required]),
      postalCode: new FormControl('', [Validators.required, Validators.pattern(/^-?(0|[0-9]\d*)?$/), Validators.maxLength(20)]),
      address: new FormControl('', [Validators.required])
    });

    this.getAllCountries();

    if (this.studId !== "") {
      this.getUser();
    }
  }

  getUser() {
    this.studentService.getStudent(this.studId).subscribe((data: Student) => {
      this.userForm.patchValue({
        firstName: data.firstName,
        lastName: data.lastName,
        email: data.email,
        phone: data.phone,
        bio: data.bio,
        country: data.country,
        province: data.province,
        city: data.city,
        postalCode: data.postalCode,
        address: data.address
      });
    });
  }

  onSubmit() {
    this.studentService.createStudent(this.userForm.value).subscribe(data => {
      debugger;
      this.toastr.success('User added successfully');
      this.router.navigate(['/students']);
    }, error => {
      debugger;
      this.toastr.error('Oops... Something went wrong. Please try again');
    });
  }

  getAllCountries() {
    this.studentService.getAllCountries().subscribe(data => {
      this.countries = data;
    });
  }
}
