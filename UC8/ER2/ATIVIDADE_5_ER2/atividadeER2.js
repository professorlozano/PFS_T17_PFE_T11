/*
Atividade do Card 9 - Atividade 5 - Encontro Remoto 2

Considere a quantidade de alunos presentes na sala, 
ok - percorra do zero até o número total e retornar os seguintes resultados:

- Se o número for par, escreva ‘par’ e o número correspondente
- Se o número for ímpar, escreva ‘impar’ e o número correspondente 
ok- Se o número for zero, escreva ‘zero’ 
*/


//primeira forma de resolver o exercício
/*
let numeroDeAlunos = 10;

for(let contador = 0; contador <= numeroDeAlunos; contador++)
{
    if(contador == 0){
        console.log(`${contador} - ZERO`) //interpolação
        //console.log(contador + " - ZERO") //concatenação
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    }
    else {
        console.log(`${contador} - IMPAR`)
    }
}
*/

//segunda forma de resolver o exercício
/*
let numeroDeAlunos = 10;
let contador = 0
while(contador <= numeroDeAlunos)
{
    if(contador == 0){
        console.log(`${contador} - ZERO`) //interpolação
        //console.log(contador + " - ZERO") //concatenação
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    }
    else {
        console.log(`${contador} - IMPAR`)
    }
    contador++
}
*/
//terceira forma de resolver o exercício
let numeroDeAlunos = 10;
let contador = 0
do
{
    if(contador == 0){
        console.log(`${contador} - ZERO`) //interpolação
        //console.log(contador + " - ZERO") //concatenação
    }
    else if((contador % 2) == 0){
        console.log(`${contador} - PAR`)
    }
    else {
        console.log(`${contador} - IMPAR`)
    }
    contador++
}while(contador <= numeroDeAlunos)


