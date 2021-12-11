/*Mencionando a tag onde será inserido os objetos*/
var text = document.getElementsByTagName('main')[0];

/*Objetos =====================================*/
var destino1 = {
    img: "http://2.bp.blogspot.com/-RThEwEqQrtc/Uk2l9uuty4I/AAAAAAAAnE0/ZsPTiyseI_A/s1600/Rio-de-Janeiro.jpg",
    destinoCidade: "Rio de Janeiro",
    destinoEstado: "RJ",
    preco: 300,
}
var destino2 = {
    img: "http://2.bp.blogspot.com/-RThEwEqQrtc/Uk2l9uuty4I/AAAAAAAAnE0/ZsPTiyseI_A/s1600/Rio-de-Janeiro.jpg",
    destinoCidade: "Rio de Janeiro",
    destinoEstado: "RJ",
    preco: 300,
}
var destino3 ={
    img: "http://2.bp.blogspot.com/-RThEwEqQrtc/Uk2l9uuty4I/AAAAAAAAnE0/ZsPTiyseI_A/s1600/Rio-de-Janeiro.jpg",
    destinoCidade: "Rio de Janeiro",
    destinoEstado: "RJ",
    preco: 300,
}

var destino4 ={
    img: "http://2.bp.blogspot.com/-RThEwEqQrtc/Uk2l9uuty4I/AAAAAAAAnE0/ZsPTiyseI_A/s1600/Rio-de-Janeiro.jpg",
    destinoCidade: "Rio de Janeiro",
    destinoEstado: "RJ",
    preco: 300,
}

var destino5 ={
    img: "http://2.bp.blogspot.com/-RThEwEqQrtc/Uk2l9uuty4I/AAAAAAAAnE0/ZsPTiyseI_A/s1600/Rio-de-Janeiro.jpg",
    destinoCidade: "Rio de Janeiro",
    destinoEstado: "RJ",
    preco: 300,
}
var destino6 ={
    img: "http://2.bp.blogspot.com/-RThEwEqQrtc/Uk2l9uuty4I/AAAAAAAAnE0/ZsPTiyseI_A/s1600/Rio-de-Janeiro.jpg",
    destinoCidade: "Rio de Janeiro",
    destinoEstado: "RJ",
    preco: 300,
}

/*Inserindo os objetos em uma lista*/
var lista = [destino1, destino2, destino3, destino4, destino5, destino6]
var i = 0;
while(i <= lista.length){

    if(i == 0){
        text.innerHTML = `
    <div class="object">
    <img src="${lista[i].img}">
    <div>
    <p>Destino</p>
    <h1>${lista[i].destinoCidade} - ${lista[i].destinoEstado}</h1>
    <p class="preco_p">Preço: R$${lista[i].preco}</p>
    <button>Comprar</button>
    </div>
    </div>
`;
    }else{
    text.innerHTML += `
    <div class="object">
    <img src="${lista[i].img}">
    <div>
    <p>Destino</p>
    <h1>${lista[i].destinoCidade} - ${lista[i].destinoEstado}</h1>
    <p class="preco_p">Preço: R$${lista[i].preco}</p>
    <button>Comprar</button>
    </div>
    </div>
`;
}
    i++;
}
