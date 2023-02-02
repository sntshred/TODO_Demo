import { Component, OnInit } from '@angular/core';
import { Itodo } from '../interfaces/Itodo';
import { ToDoService } from '../to-do.service';

@Component({
  selector: 'app-to-do',
  templateUrl: './to-do.component.html',
  styles: [
  ]
})
export class ToDoComponent implements OnInit {
  items: Itodo[];
  constructor(public toDoService: ToDoService) { }

  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    this.toDoService.getAllToDo()
      .subscribe(res => {
        this.items = res;
      })
  }

  addTodo(value: any) {
    this.toDoService.addTodo(value).subscribe(res => {
      this.items = res;
    })
  }


}
