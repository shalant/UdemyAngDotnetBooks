import { Component } from '@angular/core';
import { Book } from '../book';

@Component({
  selector: 'app-book-list',
  standalone: true,
  imports: [],
  templateUrl: './book-list.component.html',
  styleUrl: './book-list.component.css'
})
export class BookListComponent {

  // Have the book data
  book: Book [] = [
    {id: 1, title: "Book One", author: "Bob"}, 
    {id: 1, title: "Book Two", author: "Steve"},
    {id: 1, title: "Book Three", author: "Betina"},

  ]
}
