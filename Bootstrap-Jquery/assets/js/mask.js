//Criar mascaras para nosso inputs


//cep
//valor monetario
//telefone (Dinamicos)
//cpf e cnpj (Dinamicos)

//jquery

jQuery(document).ready(function($){
    $('.cep').mask('00000-000');
    $('.fone').mask('(00) 0000-0000');
    $('.celular').mask('(00) 0000-0000');
    $('.cpf').mask('000.000.000-00', {reverse: false});
    $('.cnpj').mask('00.000.000/0000-00', {reverse: false});
})