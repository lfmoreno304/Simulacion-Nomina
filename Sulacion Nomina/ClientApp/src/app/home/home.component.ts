import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { DataService } from '../services/data.service';
import { Teacher } from './../models/teacher'
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  teacher: Teacher = { type: "", hours: 0, category: "", postGraduate: "", group: "" };
  teachers: Teacher[] = [];
  salary: number = 0;
  constructor(private readonly service: DataService) { }

  onSubmit(teacher: Teacher) {
    this.teachers.push(teacher);
    this.teacher = { type: "", hours: 0, category: "", postGraduate: "", group: "" };
  }

  sendData() {
    this.service.sendData(this.teachers).subscribe(res => {

      this.salary = parseInt( res.toString());
    });
  }

}
