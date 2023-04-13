import { Routes } from "@angular/router";
import { UsersComponent } from "./users/users.component";
import { SignupComponent } from "./signup/signup.component";
import { StudentsComponent } from "./students/students.component";
import { AddStudentComponent } from "./students/add-student/add-student.component";
import { CalculatorComponent } from "./calculator/calculator.component";
import { AddUserComponent } from "./users/add-user/add-user.component";

export const PageRoutes: Routes = [
    {
      path: 'students',
      component: StudentsComponent
    },
    {
      path: 'students/add',
      component: AddStudentComponent
    },
    {
      path: 'students/edit/:id',
      component: AddStudentComponent
    },
    {
      path: 'users',
      component: UsersComponent
    },
    {
      path: 'users/add',
      component: AddUserComponent
    },
    {
      path: 'calculator',
      component: CalculatorComponent
    },
    {
      path: 'signup',
      component: SignupComponent
    }
  ];