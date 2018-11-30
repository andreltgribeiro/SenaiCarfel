window.addEventListener('load', () => {
    document.querySelectorAll("*[data-toggler]").forEach((e) => {
        //CLicarmos no elemento que possua o data-toggler...
        e.addEventListener('click', () => {

            //Pega o valor do atributo do data toggler
            let valorDoDataToggler = e.attributes["data-toggler"].value;
            
            //Chamando o elemento atraves do seletor do data toggler
            let elementoRetraido = document.querySelector(valorDoDataToggler);

            //CAso o elemento exista, faca-o aparecer
            if (elementoRetraido) {
                elementoRetraido.classList.toggle('mostra');
            }

        });
    });
});