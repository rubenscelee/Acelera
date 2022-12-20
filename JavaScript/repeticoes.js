


function horaAtual(){
    let data = new Date();
     
    return data.toLocaleTimeString('pt-BR', {
        hour12: false
    }); 
}


let timer = setInterval(() => {
    console.log(horaAtual())
}, 1000)

setTimeout(() => {
    clearInterval(timer)
}, 5000)