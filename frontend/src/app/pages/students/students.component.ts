import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { ToastrService } from 'ngx-toastr';
import { Student } from 'src/app/core/models/Student';
import { StudentService } from 'src/app/core/services/student.service';
import { UserService } from 'src/app/core/services/user.service';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.scss']
})
export class StudentsComponent implements OnInit {

  page = 1;
  pageSize = 7;

  student!: Student;
  students: any[] = [];

  constructor(
    private studentService: StudentService,
    private toastr: ToastrService,
    private modalService: NgbModal
  ) {}

  ngOnInit(): void {
    this.studentService.getAllStudents().subscribe((data: Student[]) => {
      this.students = data;
    }, error => {

    });
  }

  deleteStudent(student: Student) {
    this.studentService.deleteStudent(student.id).subscribe(data => {
      debugger;
      // remove current student from array
      let index = this.students.indexOf(student);
      this.students.splice(index, 1);

      this.toastr.error('User account deleted successfully');
    });
  }

  openModal(content: any, student: Student) {
    this.student = student;
    this.modalService.open(content, { size: 'lg' });
  }
}
