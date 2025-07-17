internal class Program
{
    private static void PrintAsciiArt()
    {
        Console.WriteLine(@"          _____                    _____                    _____            _____           _______                 ");
        Console.WriteLine(@"         /\    \                  /\    \                  /\    \          /\    \         /::\    \               ");
        Console.WriteLine(@"        /::\____\                /::\    \                /::\____\        /::\____\       /::::\    \              ");
        Console.WriteLine(@"       /:::/    /               /::::\    \              /:::/    /       /:::/    /      /::::::\    \             ");
        Console.WriteLine(@"      /:::/    /               /::::::\    \            /:::/    /       /:::/    /      /::::::::\    \            ");
        Console.WriteLine(@"     /:::/    /               /:::/\:::\    \          /:::/    /       /:::/    /      /:::/~~\:::\    \          ");
        Console.WriteLine(@"    /:::/____/               /:::/__\:::\    \        /:::/    /       /:::/    /      /:::/    \:::\    \         ");
        Console.WriteLine(@"   /::::\    \              /::::\   \:::\    \      /:::/    /       /:::/    /      /:::/    / \:::\    \        ");
        Console.WriteLine(@"  /::::::\    \   _____    /::::::\   \:::\    \    /:::/    /       /:::/    /      /:::/____/   \:::\____\       ");
        Console.WriteLine(@" /:::/\:::\    \ /\    \  /:::/\:::\   \:::\    \  /:::/    /       /:::/    /      |:::|    |     |:::|    |      ");
        Console.WriteLine(@"/:::/  \:::\    /::\____\/:::/__\:::\   \:::\____\/:::/____/       /:::/____/       |:::|____|     |:::|    |      ");
        Console.WriteLine(@"\::/    \:::\  /:::/    /\:::\   \:::\   \::/    /\:::\    \       \:::\    \        \:::\    \   /:::/    /      ");
        Console.WriteLine(@" \/____/ \:::\/:::/    /  \:::\   \:::\   \/____/  \:::\    \       \:::\    \        \:::\    \ /:::/    /       ");
        Console.WriteLine(@"          \::::::/    /    \:::\   \:::\    \       \:::\    \       \:::\    \        \:::\    /:::/    /        ");
        Console.WriteLine(@"           \::::/    /      \:::\   \:::\____\       \:::\    \       \:::\    \        \:::\__/:::/    /         ");
        Console.WriteLine(@"           /:::/    /        \:::\   \::/    /        \:::\    \       \:::\    \        \::::::::/    /          ");
        Console.WriteLine(@"          /:::/    /          \:::\   \/____/          \:::\    \       \:::\    \        \::::::/    /           ");
        Console.WriteLine(@"         /:::/    /            \:::\    \               \:::\    \       \:::\    \        \::::/    /            ");
        Console.WriteLine(@"        /:::/    /              \:::\____\               \:::\____\       \:::\____\        \::/____/             ");
        Console.WriteLine(@"        \::/    /                \::/    /                \::/    /        \::/    /         ~~                   ");
        Console.WriteLine(@"         \/____/                  \/____/                  \/____/          \/____/                               ");
        Console.WriteLine(@"                                                                                                                  ");
        Console.WriteLine(@"          _____                   _______                   _____                    _____            _____        ");
        Console.WriteLine(@"         /\    \                 /::\    \                 /\    \                  /\    \          /\    \      ");
        Console.WriteLine(@"        /::\____\               /::::\    \               /::\    \                /::\____\        /::\    \     ");
        Console.WriteLine(@"       /:::/    /              /::::::\    \             /::::\    \              /:::/    /       /::::\    \    ");
        Console.WriteLine(@"      /:::/   _/___           /::::::::\    \           /::::::\    \            /:::/    /       /::::::\    \   ");
        Console.WriteLine(@"     /:::/   /\    \         /:::/~~\:::\    \         /:::/\:::\    \          /:::/    /       /:::/\:::\    \  ");
        Console.WriteLine(@"    /:::/   /::\____\       /:::/    \:::\    \       /:::/__\:::\    \        /:::/    /       /:::/  \:::\    \ ");
        Console.WriteLine(@"   /:::/   /:::/    /      /:::/    / \:::\    \     /::::\   \:::\    \      /:::/    /       /:::/    \:::\    \");
        Console.WriteLine(@"  /:::/   /:::/   _/___   /:::/____/   \:::\____\   /::::::\   \:::\    \    /:::/    /       /:::/    / \:::\    \");
        Console.WriteLine(@" /:::/___/:::/   /\    \ |:::|    |     |:::|    | /:::/\:::\   \:::\____\  /:::/    /       /:::/    /   \:::\ ___\");
        Console.WriteLine(@"|:::|   /:::/   /::\____\|:::|____|     |:::|    |/:::/  \:::\   \:::|    |/:::/____/       /:::/____/     \:::|    |");
        Console.WriteLine(@"|:::|__/:::/   /:::/    / \:::\    \   /:::/    / \::/   |::::\  /:::|____|\:::\    \       \:::\    \     /:::|____|");
        Console.WriteLine(@" \:::\/:::/   /:::/    /   \:::\    \ /:::/    /   \/____|:::::\/:::/    /  \:::\    \       \:::\    \   /:::/    / ");
        Console.WriteLine(@"  \::::::/   /:::/    /     \:::\    /:::/    /          |:::::::::/    /    \:::\    \       \:::\    \ /:::/    /  ");
        Console.WriteLine(@"   \::::/___/:::/    /       \:::\__/:::/    /           |::|\::::/    /      \:::\    \       \:::\    /:::/    /   ");
        Console.WriteLine(@"    \:::\__/:::/    /         \::::::::/    /            |::| \::/____/        \:::\    \       \:::\  /:::/    /    ");
        Console.WriteLine(@"     \::::::::/    /           \::::::/    /             |::|  ~|               \:::\    \       \:::\/:::/    /     ");
        Console.WriteLine(@"      \::::::/    /             \::::/    /              |::|   |                \:::\    \       \::::::/    /      ");
        Console.WriteLine(@"       \::::/    /               \::/____/               \::|   |                 \:::\____\       \::::/    /       ");
        Console.WriteLine(@"        \::/____/                 ~~                      \:|   |                  \::/    /        \::/____/        ");
        Console.WriteLine(@"         ~~                                                \|___|                   \/____/          ~~              ");
        Console.WriteLine("======================================================================================================================\n\n");
    }

    private static void TellDayOfWeek()
    {
        int RequestedDay = -1;
        while (true)
        {
            Console.WriteLine("\nIngrese un número entre 1 y 7 para saber el día de la semana, o 0 para salir:");
            Console.WriteLine("=============================================================================");
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out RequestedDay))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
                continue;
            }

            if (RequestedDay == 0)
            {
                Console.WriteLine("Saliendo del programa.");
                break;
            }

            if (RequestedDay < 0 || RequestedDay > 7)
            {
                Console.WriteLine("Número fuera de rango. Por favor, ingrese un número entre 0 y 7.");
                continue;
            }

            switch (RequestedDay)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sábado"); break;
                case 7: Console.WriteLine("Domingo"); break;
            }
        }
    }
    private static void Main(string[] args)
    {
        PrintAsciiArt();
        TellDayOfWeek();
        Console.WriteLine("Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}
