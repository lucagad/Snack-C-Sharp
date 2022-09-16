// SNACK 1
// L'utente inserisce due numeri in successione.
// Il software stampa il maggiore.

// SNACK 2
// L'utente inserisce due parole in successione.
// Il software stampa prima la parola più corta, poi la parola più lunga.

// Ciclo for

// SNACK 3
// Il software deve chiedere per 10 volte all'utente di inserire un numero.
// Il programma stampa la somma di tutti i numeri inseriti.

// SNACK 4
// Calcola la somma e la media dei numeri da 2 a 10.

//Operatore modulo

//Snack5.
//Il software chiede all'utente di inserire un numero.
//Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

// Array

// Snack 6
// In un array sono contenuti i nomi degli invitati alla festa del grande
// Gatsby.Chiedi all'utente il suo nome e comunicagli se può partecipare o meno alla festa.

// Snack 7
// Crea un array vuoto.
// Chiedi per 6 volte all'utente di inserire un numero, se è dispari inseriscilo nell'array.



using System;

Console.WriteLine("Ciao! Scegli uno dei seguenti Snack:");

Console.WriteLine(" ");
Console.WriteLine(" 1 - Snack 1");
Console.WriteLine(" 2 - Snack 2");
Console.WriteLine(" 3 - Snack 3");
Console.WriteLine(" 4 - Snack 4");
Console.WriteLine(" 5 - Snack 5");
Console.WriteLine(" 6 - Snack 6");
Console.WriteLine(" 7 - Snack 7");

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
        #region
        int sumNumberIns = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Inserisci il {0}° numero", i + 1);
            sumNumberIns += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

        }

        Console.WriteLine("Il somma dei numeri inseriti è: " + sumNumberIns);

        break;
        #endregion

    case 4:
        #region
        int sumNumber = 0;

        for (int i = 2; i <= 10; i++)
        {
            sumNumber += i;
        }

        Console.WriteLine("Il somma dei numeri è: " + sumNumber);
        Console.WriteLine("La media dei numeri è: " + sumNumber/9);

        break;
    #endregion

    case 5:
        #region
        Console.WriteLine("Inserisci un numero");
        int numberInsert3 = Convert.ToInt32(Console.ReadLine());

        if (numberInsert3 % 2 == 0)
        {
            Console.WriteLine("Il numero inserito è pari: " + numberInsert3);
        }
        else
        {
            numberInsert3 += 1; 
            Console.WriteLine("Il numero inserito è dispari, il numero successivo " + numberInsert3 );
        }
                
        break;
    #endregion

    case 6:
        #region
        string[] whiteList = { "Luca", "Mario", "Giovanni", "Francesco" };

        Console.WriteLine("Inserisci il tuo nome: ");
        string nameIns = Console.ReadLine();
        bool nameFinded = false;

        for (int i = 0; i < whiteList.Length; i++)
        {
            if (whiteList[i] == nameIns)
            {
                Console.WriteLine("Il tuo nome è tra gli invitati, Benvenuto!");
                nameFinded = true;
                break;
            }
        }

        if (nameFinded == false)
          {
            Console.WriteLine("Il tuo nome non è tra gli invitati");
          }
        
        break;
    #endregion

    case 7:
        #region
        int[] numbersInsert = new int[6];

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Inserisci il {0}° numero", i + 1);

            int numberTemp = Convert.ToInt32(Console.ReadLine());

            if (numberTemp % 2 != 0)
            {
                numbersInsert[i] = numberTemp;
            }
            Console.WriteLine(" ");

        }

        Console.WriteLine("I numeri dispari che hai inserto sono: ");

        for (int i = 0; i < 6; i++)
        {
            if (numbersInsert[i] != 0){
                Console.Write(numbersInsert[i] + " ");
            }
        }

        break;
    #endregion

    case 8:
        #region
        int[] numbers = {2,4,6,8,34,9,10,3,8};

        int sumNumberArray = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            
            if (i % 2 != 0)
            {
                sumNumberArray += numbers[i];
            }

        }

        Console.WriteLine("La somma dei numeri in posizione dispari è: " + sumNumberArray);

        break;
    #endregion

    default:
        Console.WriteLine("Il codice inserito è erratto");
        break;
}


// Snack8
// Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

