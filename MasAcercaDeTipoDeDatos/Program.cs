// to string 

using MasAcercaDeTipoDeDatos;

var cantidad = 5;

if(cantidad.ToString() == "5")
{

    Console.WriteLine("son iguales");
}
else
{

    Console.WriteLine("no son iguales");
}

var hoy = DateTime.Today.ToString("yyyy-MMMM-dddd");
Console.WriteLine(hoy);

//To parse - convetir de string a otro tipo de dato

var cantidadString = "5";

int cantidad2 = int.Parse(cantidadString);
cantidad++;


var cantidadDecial = "4.9";
var cantidadDecialC = decimal.Parse(cantidadDecial);


var supeustoNumero = "9";
int numero;
var pudoParsear = int.TryParse(supeustoNumero, out numero);

if (pudoParsear)
{
    numero++;
    Console.WriteLine(numero);
}
else
{

    Console.WriteLine($"El valor {supeustoNumero} no tiene el formato correcto");



}


//casteo


var cantidad1 = 7;

var cantidad3 = 4;

var division =(double) cantidad1 / cantidad3;
Console.WriteLine("la division es: " + division);


byte byte1;
int int1 = 3;

byte1 = (byte) int1;

//enums




var estatusdeLaVentaDeUnaCamisa = EstatusVenta.pendienteDePago;

switch (estatusdeLaVentaDeUnaCamisa)
{
    case EstatusVenta.Exitoso:
        Console.WriteLine("LA VENTA FUE EXITOSA");
        break;
    case EstatusVenta.pendienteDePago:
        Console.WriteLine("EL CLIENTE DEBE DE OAGAR");
        break;
    case EstatusVenta.Cancelada:
        Console.WriteLine("PAGUE RATA");
        break;
    default:
        Console.WriteLine("TODO EN ORDEB");
        break;
}


int estatus = (int)estatusdeLaVentaDeUnaCamisa;
Console.WriteLine(estatus);

int estus3 = 3;
var estatusNombe = (EstatusVenta)estus3;
Console.WriteLine(estatusNombe);



//areglos


//arreglo de chart

char[] vocales = new char[5];

vocales[0] = 'a';
vocales[1] = 'e';
vocales[2] = 'i';
vocales[3] = 'o';
vocales[4] = 'u';

var segundaVocal = vocales[0];
Console.WriteLine(segundaVocal);

//var unaVocalMagica = vocales[5]; // no ay elemento

foreach(var vocal in vocales)
{
    Console.WriteLine(vocal);
}



var numeroMismo = new int[] { 1,2,3,4,5,6};

foreach (int num in numeroMismo)
{
    Console.WriteLine(num);
}


//rangos

var vocals = new char[] { 'a', 'e', 'i', 'o', 'u' };
Range dosprimero = ..2;
var dosPrimerasVocales = vocals[dosprimero]; //0,1

foreach(var vocal in dosPrimerasVocales)
{
    Console.WriteLine(vocal);
}


//arreglo multidimencionales

int[,] matriz = new int[2,2];

Console.WriteLine(matriz.Rank);//2

matriz[0, 0] = 1; //primera fila, primera columna
matriz[0, 1] = 2; //primera fila, segunda columna

matriz[1, 0] = 3; //segunda fila, primera columna
matriz[1, 1] = 4; //segunda fila, segunda columna

var elemento01= matriz[0,1];//2
Console.WriteLine("matriz" + elemento01);

//Manipulado de String

var nombre = "Rafael";

//cambia el valor a mayuscula
var nombreMayuscula = nombre.ToUpper();

//nombre minuscula
var nombreMinuscula = nombre.ToLower();

Console.Write("Desea terminar el programa? (y/n)");
var entradaUsuario = Console.ReadLine();
//trim= elimina los espacion
if (entradaUsuario?.ToLower().Trim() == "y")
{
    Console.WriteLine("terminando el programa");

}
else
{
    Console.WriteLine("el programa no va a terminar");
}

var Longitud = nombre.Length; // obtiene la logitud de los caracteres