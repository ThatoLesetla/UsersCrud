import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentsComponent } from './students/students.component';
import { UsersComponent } from './users/users.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { PageRoutes } from './pages.routing';
import { SignupComponent } from './signup/signup.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { AddStudentComponent } from './students/add-student/add-student.component';
import { ToastrModule } from 'ngx-toastr';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CalculatorComponent } from './calculator/calculator.component';
import { AddUserComponent } from './users/add-user/add-user.component';


@NgModule({
  declarations: [
    StudentsComponent,
    UsersComponent,
    SignupComponent,
    DashboardComponent,
    AddStudentComponent,
    CalculatorComponent,
    AddUserComponent
  ],
  imports: [
    CommonModule,
    NgbModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forChild(PageRoutes),
    ToastrModule.forRoot()
  ]
})
export class PagesModule { }
