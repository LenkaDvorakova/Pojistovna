using System.Linq;

namespace Pojistovna
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SpravaPojistencu spravaPojistencu = new SpravaPojistencu();

            while (true)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Evidence pojištěných osob");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Vítejte v mé pojišťovně, vyberte číslo akce, kterou chcete pokračovat:");
                Console.WriteLine("1 - Přidat nového pojištěnce");
                Console.WriteLine("2 - Vypsat všechny pojištěné osoby");
                Console.WriteLine("3 - Vyhledat pojištěnce");
                Console.WriteLine("4 - Ukončit");
                Console.WriteLine();

                string vstup = Console.ReadLine();
                int akce = 0;
                /* Kontrola vstupu - musi jit o cislo */
                if(vstup.All(char.IsDigit))
                {
                    akce = int.Parse(vstup);
                }

                switch (akce)
                {
                    case 1:
                        try
                        {
                            Pojistenec pojistenec = new Pojistenec();
                            Console.WriteLine("Zadejte jméno pojištěného:");
                            pojistenec.Jmeno = Console.ReadLine();
                            if(pojistenec.Jmeno.Length < 2)
                            {
                                Console.WriteLine("Minimální délka jména jsou 2 znaky.");
                                break;
                            }
                            Console.WriteLine("Zadejte přijmení pojištěného:");
                            pojistenec.Prijmeni = Console.ReadLine();
                            if (pojistenec.Prijmeni.Length < 2)
                            {
                                Console.WriteLine("Minimální délka přijmení jsou 2 znaky.");
                                break;
                            }
                            Console.WriteLine("Zadejte věk pojištěného:");
                            pojistenec.Vek = int.Parse(Console.ReadLine());
                            Console.WriteLine("Zadejte telefonní číslo pojištěného:");
                            pojistenec.TelefonniCislo = int.Parse(Console.ReadLine());
                            spravaPojistencu.Pridej(pojistenec);
                        } catch (System.FormatException)
                        {
                            Console.WriteLine("Vstupní data jsou nevadlidní. Osobu nelze uložit!");
                        }
                        break;
                    case 2:
                        List<Pojistenec> pojisteni = spravaPojistencu.VratSeznam();
                        if(pojisteni.Count == 0)
                        {
                            Console.WriteLine("Seznam pojištěných osob je prázdný!");
                        }
                        else
                        {
                            foreach (Pojistenec p in spravaPojistencu.VratSeznam())
                            {
                                Console.WriteLine(p.ToString());
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Zadejte jméno pojištěného:");
                        string jmeno = Console.ReadLine();
                        Console.WriteLine("Zadejte přijmení pojištěného:");
                        string prijmeni = Console.ReadLine();
                        List<Pojistenec> vyhledani = spravaPojistencu.Vyhledej(jmeno, prijmeni);
                        if (vyhledani.Count == 0)
                        {
                            Console.WriteLine("Pojištěný nebyl nalezen!!!");
                        }
                        else
                        {
                            foreach (Pojistenec p in vyhledani)
                            {
                                Console.WriteLine(p.ToString());
                            }
                        }
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Zadal jsi špatné číslo, zkus to znovu.");
                        break;
                }
                Console.WriteLine("Pokračujte libovolnou klávesou...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}