// See https://aka.ms/new-console-template for more information


//---------parte principale--------

int[] lista = { 2, 6, 7, 5, 3, 9 };

stampaArray(lista);
stampaArray(elevaArrayAlQuadrato(lista));
stampaArray(lista);

int sum = sommaElementiArray(lista);

Console.WriteLine("La somma di tutti i numrti è: " + sum);

int sumAlQuadrato = sommaElementiArray(elevaArrayAlQuadrato(lista));

Console.WriteLine("La somma di tutti i numeri elevati al qaudrato è: " + sumAlQuadrato);


//--------funzioni----------

void stampaArray(int[] array)   //------funzione stampa in video
{
    Console.Write("[ ");

    for(int i = 0; i < array.Length-1; i++)    
    {
        Console.Write(array[i] + ", ");

    }
    Console.WriteLine(array[array.Length - 1] + " ]");
}

int quadrato(int numero)      //--------calcolo quadrato di un numero
{
    int risultato;
    risultato = numero * numero;
    return risultato;
}

int[] elevaArrayAlQuadrato(int[] array)    //------copio un array e ristituisco un valore il quadrato
{
    int[] copiaArray = (int[])array.Clone();

    for(int i = 0; i <array.Length; i++)
    {
        copiaArray[i] = quadrato(copiaArray[i]);

    }
    return copiaArray;
}

int sommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    int somma = 0;

    for(int i = 0; i < array.Length; i++)
    {
        somma += copiaArray[i];
    }
    return somma;
}





