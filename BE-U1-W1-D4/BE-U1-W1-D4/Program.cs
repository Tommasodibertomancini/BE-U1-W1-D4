using BE_U1_W1_D4.Models;

while (true)
{
    Console.Clear();

    Console.WriteLine("\n===============OPERAZIONI==============");
    Console.WriteLine("Scegli l'operazione da effettuare:");
    Console.WriteLine("1.: Login");
    Console.WriteLine("2.: Logout");
    Console.WriteLine("3.: Verifica ora e data di login");
    Console.WriteLine("4.: Lista degli accessi");
    Console.WriteLine("5.: Esci");
    Console.WriteLine("========================================");

    Console.Write("Operazione: ");
    string selezionato = Console.ReadLine();

    switch (selezionato)
    {
        case "1":
            Console.WriteLine("Inserisci UserName:");
            string username = Console.ReadLine();
            Console.WriteLine("Inserisci Password:");
            string password = Console.ReadLine();
            Console.WriteLine("Conferma Password:");
            string confermaPassword = Console.ReadLine();
            LoginOperations.Login(username, password, confermaPassword);
            break;
        case "2":
            LoginOperations.Logout();
            break;
        case "3":
            LoginOperations.VerificaOraDataLogin();
            break;
        case "4":
            LoginOperations.ListaAccessi();
            break;
        case "5":
            Console.WriteLine("Arrivederci!");
            return;
        default:
            Console.WriteLine("Operazione non valida.");
            break;
    }
    Console.WriteLine("\nPremi un tasto per continuare...");
    Console.ReadKey();
}