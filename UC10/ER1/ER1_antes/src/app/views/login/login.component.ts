import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/models/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

ngOnInit(): void {
}

loginModel = new User();

mensagem = ""

usuarioLogado = ""

onSubmit() {
  console.log(this.loginModel)
  }
}