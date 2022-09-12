//sistema para um radar de velocidade

//variaveis
let velocidade;

//entrada
//velocidade = 99;
velocidade = Number(prompt("Digite a velocidade!!!"))

//processamento / saida
if (velocidade > 110){
    //console.log("Voce foi multado!!!")
    alert("Voce foi multado")
}
else
    {
        if(velocidade >100 && velocidade <110){
            //console.log("Voce esta sendo notificado por andar acima do limite")
            alert("Voce esta sendo notificado por andar acima do limite")
        }   
        else{
            //console.log("Voce esta dentro do limite de velocidade")
            alert("Voce esta dentro do limite de velocidade")

        }
    }

    
