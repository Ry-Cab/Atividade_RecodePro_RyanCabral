/*Mencionando as tags onde serão inseridos os objetos*/
var text = document.getElementsByTagName('main')[0];


/*Objetos =====================================*/
var destino1 = {
    img: "http://2.bp.blogspot.com/-RThEwEqQrtc/Uk2l9uuty4I/AAAAAAAAnE0/ZsPTiyseI_A/s1600/Rio-de-Janeiro.jpg",
    destinoCidade: "Rio de Janeiro",
    destinoEstado: "Rio de Janeiro",
    preco: 253.51,
}
var destino2 = {
    img: "https://media.tacdn.com/media/attractions-splice-spp-674x446/06/dd/dd/0b.jpg",
    destinoCidade: "Salvador",
    destinoEstado: "Bahia",
    preco: 499.29,
}
var destino3 ={
    img: "https://rodoviariaonline.com.br/wp-content/uploads/2019/04/original-0a2e45ef3ada481fc00e1f88d09b5e00.jpg",
    destinoCidade: "Recife",
    destinoEstado: "Pernambuco",
    preco: 532.65,
}

var destino4 ={
    img: "https://d2yfnz5to9nvdi.cloudfront.net/wp-content/uploads/2017/09/guia-destinos-voesimples-brasil-sao-paulo-sao-paulo.jpg",
    destinoCidade: "São Paulo",
    destinoEstado: "São Paulo",
    preco: 250.63,
}

var destino5 ={
    img: "https://s2.glbimg.com/Z8uoqOyhqG7E33Uh0iMoOnygXBE=/0x0:680x452/924x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_59edd422c0c84a879bd37670ae4f538a/internal_photos/bs/2019/J/z/ly7VkgQeG3AAXvcPNdzg/maringa-quer-se-tornar-a-capital-nacional-do-associativismo.jpeg",
    destinoCidade: "Maringá",
    destinoEstado: "Paraná",
    preco: 350.63,
}
var destino6 ={
    img: "https://jpimg.com.br/uploads/2021/07/31905833.084301.jpg",
    destinoCidade: "Natal",
    destinoEstado: "Rio Grande do Norte",
    preco: 658.99,
}

var destino7 ={
    img: "https://media.tacdn.com/media/attractions-splice-spp-674x446/0b/aa/58/c6.jpg",
    destinoCidade: "Blumenau",
    destinoEstado: "Santa Catarina",
    preco: 724.65,
}
var destino8 ={
    img: "https://www.melhoresdestinos.com.br/wp-content/uploads/2017/11/o-que-fazer-em-porto-alegre-gasometro2-1.jpg",
    destinoCidade: "Porto Alegre",
    destinoEstado: "Rio Grande do Sul",
    preco: 699.99,
}
var destino9 ={
    img: "https://www.segueviagem.com.br/wp-content/uploads/2021/01/shutterstock_700958449-1200x675.jpg",
    destinoCidade: "Belém",
    destinoEstado: "Pará",
    preco: 859.99,
}



/*Inserindo os objetos em uma lista*/
var lista = [destino1, destino2, destino3, destino4, destino5, destino6, destino7, destino8, destino9]
var i = 0;
while(i <= lista.length){

    if(i == 0){
        text.innerHTML = `
    <div class="object">
    <img src="${lista[i].img}">
    <div>
    <p>${lista[i].destinoEstado}</p>
    <h1>${lista[i].destinoCidade}</h1>
    <span class="span-div">Ida e volta</span>
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
    <p>${lista[i].destinoEstado}</p>
    <h1>${lista[i].destinoCidade}</h1>
    <span class="span-div">Ida e volta</span>
    <p class="preco_p">Preço: R$${lista[i].preco}</p>
    <button>Comprar</button>
    </div>
    </div>
`;
}
    i++;
}

