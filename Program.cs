// See https://aka.ms/new-console-template for more information


// SNACK 1
// L'utente inserisce due numeri in successione.
// Il software stampa il maggiore.

int numberMax = 0;

for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Ciao! Inserisci il {0}° numero", i + 1);
    int numberIns = Convert.ToInt32(Console.ReadLine());
    if (numberMax < numberIns)
        {
            numberMax = numberIns;
        }
}

Console.WriteLine("Il numero Maggiore tra i due è: " + numberMax);





// SNACK 2
// L'utente inserisce due parole in successione.
// Il software stampa prima la parola più corta, poi la parola più lunga.

// Ciclo for

// SNACK 3
// Il software deve chiedere per 10 volte all'utente di inserire un numero.
// Il programma stampa la somma di tutti i numeri inseriti.

// SNACK 4
// Calcola la somma e la media dei numeri da 2 a 10.

