// // !Bucles

// // While (mientras)
// int i = 0;
// Console.WriteLine("While");
// while (i < 10)
// {
//     // ?CÓDIGO MIENTRAS LA CONDICION SEA TRUE
//     Console.Write(i + " ");
//     i++;
// }

// // DO....While HACCER - (mientras)
// Console.WriteLine("\ndo...While: ");
// int k = 5;

// do{
//     Console.Write(k + " ");
//     k += 5;
// }while(k <= 10);


// Console.WriteLine("\nDespues del While: " + i);
// // FOR - PARA / POR
// Console.WriteLine("For");


// for(int j = 0; j <= 10; j++){
//     Console.Write(j + " ");
// }

// // FOREACH - POR CADA ELEMENTO
// Console.WriteLine("\nForEach");

// var lista = new List<string>{"Daniel","Afrodita","Zeus"};
// foreach(var elemento in lista){
//     Console.WriteLine("Hola, " + elemento);
// }


// * EJEMPLOS DE BUCLES

// * SUMAR LOS 100 PRIMEROS NUMEROS ENTEROS
// int suma = 0;

// for(int i=0; i <= 100;i++){
    
//     suma += i;
// }
// Console.WriteLine(suma); //5050

// // * EXPANDIMOS EL CODIGO PARA QUE EL USUARIO INDIQUE UN NUMERO HASTA DONDE VAMOS A SUMAR- PAYPHONEEE
// Console.WriteLine("¿Hasta que número querés sumar?");
// int numUser = Convert.ToInt32(Console.ReadLine());

// suma = 0;
// for(int i=0; i <= numUser;i++){
    
//     suma += i;
// }
// Console.WriteLine($"El Resultado Es {suma}");

// // * ESCRIBIR TODOS LOS ELEMENTOS DE UN ARRAY
// int[] arr = new int[3];
// arr[0] = 1;
// arr[1] = 2;
// arr[2] = 3;

// for(int i = 0; i < arr.Length; i++){
//     Console.Write(arr[i] + ", ");
// }

// foreach(var element in arr){
//     Console.Write(element + " ");
// }


// !TAREA 

// ! Ejercicio 1 - While
Console.WriteLine("Que tabla de multiplicar queres?");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;

while(i <= 10){
    Console.WriteLine($"{num} X {i} = {num*i}");
    i++;
}
