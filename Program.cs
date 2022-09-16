// SNACK 1
// L'utente inserisce due numeri in successione.
// Il software stampa il maggiore.

// SNACK 2
// L'utente inserisce due parole in successione.
// Il software stampa prima la parola più corta, poi la parola più lunga.

Console.WriteLine("Ciao! Scegli uno dei seguenti Snack:");
Console.WriteLine(" 1 - Snack 1");
Console.WriteLine(" 2 - Snack 2");
Console.WriteLine(" 3 - Snack 3");

Console.WriteLine(" ");

Console.WriteLine("Inserisci il numero dello Snack scelto: ");
int optionSelected = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");

switch (optionSelected)

{
    
    case 1:
        #region

        int numberMax = 0;

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Inserisci il {0}° numero", i + 1);
            int numberIns = Convert.ToInt32(Console.ReadLine());

            if (numberMax < numberIns)
            {
                numberMax = numberIns;
            }
        }

        Console.WriteLine("Il numero Maggiore tra i due è: " + numberMax);

        break;
        #endregion

    case 2:
        #region
        string[] wordsInsert = new string[2];

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Inserisci la {0}° parola", i + 1);
            wordsInsert[i] = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");

        }

        if (wordsInsert[0].Length > wordsInsert[1].Length)
        {
            Console.WriteLine("Queste sono le parole inserite, ordinate per lunghezza: " + wordsInsert[0] + " - " + wordsInsert[1]);
        }
        else if (wordsInsert[1].Length > wordsInsert[0].Length)
        {
            Console.WriteLine("Queste sono le parole inserite, ordinate per lunghezza: " + wordsInsert[1] + " - " + wordsInsert[0]);
        }
        else
        {
            Console.WriteLine("Queste sono le parole inserite, di uguale lunghezza: " + wordsInsert[0] + " - " + wordsInsert[1]);
        }

        break;
    #endregion

    case 3:

        int sumNumberIns = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Inserisci il {0}° numero", i + 1);
            sumNumberIns += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

        }

        Console.WriteLine("Il somma dei numeri inseriti è: " + sumNumberIns);

        break;

    default:
        Console.WriteLine("Il codice inserito è erratto");
        break;
}



// Ciclo for

// SNACK 3
// Il software deve chiedere per 10 volte all'utente di inserire un numero.
// Il programma stampa la somma di tutti i numeri inseriti.

// SNACK 4
// Calcola la somma e la media dei numeri da 2 a 10.

