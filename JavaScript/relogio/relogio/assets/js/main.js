let criaHorasdosSegundos = (segundos) => {
    const data = new Date(segundos * 1000);
    return data.toLocaleTimeString('pt-BR', {
        hour12: false,
        timeZone: 'UTC'
    });
}

const relogio = document.querySelector(".relogio");

let segundos = 0;
let timer;

let iniciarRelogio = () => { 
    timer = setInterval( ()=> {
        segundos++;
        relogio.innerHTML = criaHorasdosSegundos(segundos);
    }, 1000
)};

document.addEventListener("click", function(e){
    const el = e.target;

    if(el.classList.contains('zerar')){
        relogio.classList.remove('pausado');
        clearInterval(timer);
        relogio.innerHTML = '00:00:00';
        segundos = 0;

    }

    if(el.classList.contains('iniciar')){
        relogio.classList.remove('pausado');
        clearInterval(timer);
        iniciarRelogio();
    }

    if(el.classList.contains('pausar')){
        clearInterval(timer);
        relogio.classList.add('pausado');
    }
});