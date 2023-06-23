/*Ex6
Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine
descrescatoare.
• Exemplu: citim 3,9,0 Afisam : 9 3 0*/

using System.Linq.Expressions;

class Lab1Ex6
{

    static void Main()
    {

        int primulNumar;
        int alDoileaNumar;
        int alTreileaNumar;
        int numarMare;
        int numarMic;
        int numarMijloc;


        Console.WriteLine("Introdu primul numar:");
        primulNumar = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu al doilea numar:");
        alDoileaNumar = int.Parse(Console.ReadLine());

        Console.WriteLine("Introdu al treilea numar:");
        alTreileaNumar = int.Parse(Console.ReadLine());

        if (primulNumar > alDoileaNumar)
        {
            numarMijloc = primulNumar;
            numarMic = alDoileaNumar;
        }
        else
        {
            numarMijloc = alDoileaNumar;
            numarMic = primulNumar;
        }

        if (numarMijloc > alTreileaNumar)
        {
            numarMare = numarMijloc;

            if (numarMic > alTreileaNumar)
            {
                numarMijloc = numarMic;
                numarMic = alTreileaNumar;
            }
            else
            {
                numarMijloc = alTreileaNumar;
            }
        }
        else
        {
            numarMare = alTreileaNumar;

        }

        Console.WriteLine("Ordinea inversa este:");
        Console.WriteLine(numarMare);
        Console.WriteLine(numarMijloc);
        Console.WriteLine(numarMic);
    }
}

