const form = document.querySelector("#formulario");

form.addEventListener("submit", function(e){
    e.preventDefault();
    let inputNome =  e.target.querySelector("#nome").value;
    let inputTelefeone =  e.target.querySelector("#telefone").value;
    let inputEmail =  e.target.querySelector("#email").value;
    let tbody = document.querySelector("table tbody");


    if(!inputNome && !inputTelefeone && !inputEmail){
         mostrarMsg("Preencha todos os campos!");
    } else {
        let tr = criarElemento("tr");
        
        tbody.appendChild(tr);

        
        
    }       
    

});


function criarElemento(element) {
    const e = document.createElement(element);
    return e;
}


function mostrarMsg(msg){
    let resultado = document.getElementById("resultado");
    let p = criarElemento("p")
    resultado.innerHTML = msg;
    
}