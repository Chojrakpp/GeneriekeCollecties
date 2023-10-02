using WerkenMetRijen;

internal class Program
{
    private static void Main(string[] args)
    {
        Rij<int> rijInt = new Rij<int>();
        //char keuze = '0';
        //int even;
        rijInt.Toevoegen(5);
        Console.WriteLine("rijInt: " + rijInt);

        Rij<string> rijString = new Rij<string>();
        rijString.Toevoegen("string test");
        Console.WriteLine("rijString: " + rijString);


        Student student = new Student { Id = 1, Name = "Janssens" };
        Rij<Student> rijStudent = new Rij<Student>();
        rijStudent.Toevoegen(student);

        Console.WriteLine("rijStudent: " + rijStudent.ToString());
    }
}


//do
//{
//    Console.WriteLine("Kies achtereenvolgens: ");
//    Console.WriteLine(" 0 Stoppen");
//    Console.WriteLine(" 1 Toevoegen");
//    Console.WriteLine(" 2 Uithalen");
//    Console.WriteLine(" 3 Toon hele rij");
//    Console.WriteLine(" 4 Leeg maken");
//    Console.WriteLine("Geef je keuze en druk [enter]: ");
//    keuze = Console.ReadLine()[0];
//    Console.WriteLine();

//    switch (keuze)
//    {
//        case '0':
//            break;
//        case '1':
//            Console.Write("Geef het toe te voegen getal: ");
//            rij.Toevoegen(Convert.ToInt32(Console.ReadLine())); // Convert anders krijg je aski waarde van het cijfer
//            break;
//        case '2':
//            if (rij.isLeeg())
//            {
//                    Console.WriteLine("De rij is leeg");
//            }
//            else
//                Console.WriteLine("Het eerste getal in de rij was " + rij.Uithalen());
//                Console.WriteLine();
//            break;
//        case '3':
//            Console.WriteLine("De getallen zijn: ");
//            Console.WriteLine(rij.ToString());
//            Console.WriteLine();
//            break;
//        case '4':
//            Console.WriteLine("De rij is leeg");
//            rij.MaakLeeg();
//            Console.WriteLine();
//            break;
//        default: Console.WriteLine("????");
//            break;

//    }
//} while (keuze != '0');