import { Component } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Teacher } from './../models/teacher'
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  cant = new FormControl();
  teachers: Teacher[] = [];
  tables: number[] = [];
  onSubmit() {
    this.teachers = Array(this.cant.value).fill({ type: 1, category: 1, hours: 10, postGraduate: 1, group: 1 });
    
  }

  sendData(teacher: Teacher, index: number) {
    this.teachers[index] = teacher;
    console.log(this.teachers);
  }
}
