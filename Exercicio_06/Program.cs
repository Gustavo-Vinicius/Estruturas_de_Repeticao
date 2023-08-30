int numero = 0, quantPar = 0, quantImpar = 0;

while (numero >=0)
{
    Console.WriteLine("Digite um número (numeros negativos finalizam): ");
    numero=Convert.ToInt32(Console.ReadLine());
    if(numero >= 0){
        if((numero % 2)==0 ){
            quantPar++;
        }
        else{
            quantImpar++;
        }
    }
}
Console.WriteLine("\n\nQuantidade de Números Pares: "+quantPar+"\nQuantidade de Números Impares: "+quantImpar);