// Capturar evento de submit do formulário
const form = document.querySelector("#formulario");

form.addEventListener("submit", function(e){
    e.preventDefault();
    const inputPeso = e.target.querySelector("#peso"); //Pega as propriedades do Input Peso
    const inputAltura = e.target.querySelector("#altura"); //Pega as propriedades do Input Altura

    const peso = Number(inputPeso.value);
    const altura = Number(inputAltura.value);

    if(!peso){
     
        setMensagem("Informar o Peso", false);
        return;
         
    }

    if(!altura) {
        setMensagem("Informar a altura", false);
        return;
    } 

    //Calcular IMC
    const imc = calcularIMC(peso, altura);

    const indiceIMC = resultIndiceIMC(imc);

    const msg = `Seu imc é ${imc} - ${indiceIMC}`

    setMensagem(msg, true);

});

function calcularIMC(peso, altura){
    let imc = 0;
    const calculo = peso / Math.pow(altura, 2);
    imc = calculo;

    return imc.toFixed(2);

}

function resultIndiceIMC(imc){
    const indice = ['Abaixo do peso', 'Peso normal', 'Sobrepeso', 'Obesidade grau 1', 'Obesidade grau 2', 'Obesidade grau 3']

    if(imc >= 39.9) return indice[5];
    if(imc >= 34.9) return indice[4];
    if(imc >= 29.9) return indice[3];
    if(imc >= 24.9) return indice[2];
    if(imc >= 18.5) return indice[1];
    if(imc < 18.5) return indice[0];
}

function setMensagem(msg, isValid){
    const resultado = document.getElementById("resultado");

     resultado.innerHTML = '';

    const p = criarElemento("p");
     
    if(isValid) {
        p.classList.add('valid');
         
    } else {
        p.classList.add('is-invalid')
    }

    p.innerHTML = msg;

    resultado.appendChild(p);


}

function criarElemento(element){
    const p = document.createElement(element);
    return p;
}