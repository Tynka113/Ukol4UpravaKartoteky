using Ukol4UpravaKartoteky;

/*
 * Zadání:
Použižj zadání ze 3. lekce a uprav úkol s kartotékou tak, 
že bude využívat typ list.

Tedy v průběhu aplikace se budou položky ukládat do listu, 
který bude tvého vlastního typu a v menu mohou být přidány položky 
pro uložení do souboru a načtení ze souboru. 
Až při této volbě se položky do souboru uloží respektive načtou. 
*/

var mojeKnihy = new List<Kniha>();
bool jeKonec=false;

while(!jeKonec)
{
    Console.WriteLine("Moje knihy - menu:");
    Console.WriteLine("1-Přidat knihu");
    Console.WriteLine("2-Smazat knihu");
    Console.WriteLine("3-Vypsat knihy");
    Console.WriteLine("0-Konec");
    Console.Write("Zadej volbu :");

    int menu = Convert.ToInt32(Console.ReadLine());

    switch(menu)
    {
        case 0:
            jeKonec = true;
            break;
        case 1:
            Kniha zadaneKnihy = new Kniha();
            Console.Write("Zadej nazev knihy: ");
            zadaneKnihy.Nazev = Console.ReadLine();
            Console.Write("Zadej příjmení autora: ");
            zadaneKnihy.AutorPrijmeni = Console.ReadLine();
            Console.Write("Zadej jméno autora: ");
            zadaneKnihy.AutorJmeno = Console.ReadLine();
            Console.Write("Zadej rok vydání: ");
            zadaneKnihy.RokVydani = Console.ReadLine();
            mojeKnihy.Add(zadaneKnihy);
            break;
        case 2:
            Console.Write("Zadej index mazané položky: ");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index > -1 && index < mojeKnihy.Count)
            {
                mojeKnihy.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Mazání přerušeno: zadaný index neexistuje");
            }
            
            break;
        case 3:
            //Console.WriteLine($"Index \t Název knihy \t Přijmení autora \t Jméno autora \t Rok vydání knihy");
            int i = 0;
            foreach(Kniha k in mojeKnihy)
            {
                Console.WriteLine($"{i}\t{k.Nazev}\t{k.AutorPrijmeni}\t{k.AutorJmeno}\t{k.RokVydani}");
                i++;
            }
            break;

    }
}
