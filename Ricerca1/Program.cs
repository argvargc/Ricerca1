int[] numbervs = new int[10];
int i1 = 0;

for (int i = 0; i < numbervs.Length; i++)
{
    Console.Write($"Inserisci numero {i}: ");
    numbervs[i] = Convert.ToInt32(Console.ReadLine());
}

bool trovato = false;
int intDaTrovare = 0;
Console.WriteLine($"Inserisci il numero che vuoi trovare: ");
intDaTrovare = Convert.ToInt32(Console.ReadLine());

//ricerca 1
do
{
    if (numbervs[i1] == intDaTrovare)
    {
        trovato = true;
    }
    i1++;

    if (trovato == true)
    {
        Console.WriteLine("Trovato");
    }
} while (trovato == false);
