//chamada para uma API dos correios
//API que traz CNPJ -> dados da empresa


//buscar endereço pelo cep
$(document).ready(() => {

    //consultado cep
    $("#CEP").blur(function() {

        let cep = $(this).val();
        let url = `http://viacep.com.br/ws/${cep}/json/`;

        let resposta = {};

        fetch(url)
        .then((res) => {
            let x = res.json();
            return x;
        })
        .then((valor) => {
            resposta = valor;

            if(!("erro" in resposta)) {
                $("#rua").val(resposta.logradouro);
                $("#bairro").val(resposta.bairro);
                $("#cidade").val(resposta.localidade);
                $("#estado").val(resposta.uf);
                $("#msgCEP").html("<i style='color: green;' class='fas fa-check'></i>");
                return;
            }
             
            $("#msgCEP").html("<i style='color: red;' class='fas fa-ban'></i>");
            limpa_formulário_cep();
        }) 
    
    });

});

//consultar CNPJ
function serviceReceita(cnpj){ 

        let cnpj = $(this).val();
        let url = `http://publica.cnpj.ws/cnpj/${cnpj}`;

        let resposta = {};

        fetch(url)
        .then((res) => {
            let x = res.json();
            return x;
        })
        .then((valor) => {
            resposta = valor;
            $("#razaoSocial").val(resposta.razao_social);
            $("#nomeFantasia").val(resposta.nome_fantasia);
        })

};