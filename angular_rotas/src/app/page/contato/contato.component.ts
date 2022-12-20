import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-contato',
  templateUrl: './contato.component.html',
  styleUrls: ['./contato.component.css']
})
export class ContatoComponent implements OnInit {

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
  }

  
  public mensagem: string = '';

  public cadastroForm : FormGroup = this.formBuilder.group ({
    nome: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]]
  })

  submitForm() {
    if(!this.cadastroForm.valid){
      this.mensagem = "Favor preencher todos os camops"
    }
    console.log(this.cadastroForm)
  }

}
