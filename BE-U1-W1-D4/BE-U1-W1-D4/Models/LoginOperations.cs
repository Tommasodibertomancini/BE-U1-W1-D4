using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_U1_W1_D4.Models
{
    static class LoginOperations
    {
        public static string Username { get; private set; }
        private static string Password;
        public static DateTime? LoginTime { get; private set; }
        public static List<DateTime> Accessi { get; } = new List<DateTime>();
        public static bool Autenticato => Username != null;

        public static bool Login(string username, string password, string confermaPassword)
        {
            if (string.IsNullOrWhiteSpace(username) || password != confermaPassword)
            {
                Console.WriteLine("Errore: Username non valido o le password non coincidono.");
                return false;
            }

            Username = username;
            Password = password;
            LoginTime = DateTime.Now;
            Accessi.Add(LoginTime.Value);
            Console.WriteLine("Login effettuato con successo.");
            return true;
        }

        public static void Logout()
        {
            if (!Autenticato)
            {
                Console.WriteLine("Errore: Nessun utente attualmente loggato.");
                return;
            }
            Username = null;
            Password = null;
            LoginTime = null;
            Console.WriteLine("Logout effettuato con successo.");
        }

        public static void VerificaOraDataLogin()
        {
            if (!Autenticato)
            {
                Console.WriteLine("Errore: Nessun utente attualmente loggato.");
                return;
            }
            else
            {
                Console.WriteLine($"L'utente {Username} si è loggato in data {LoginTime.Value.ToShortDateString()} alle ore {LoginTime.Value.ToShortTimeString()}.");
            }
        }

        public static void ListaAccessi()
        {
            if (Accessi.Count == 0)
            {
                Console.WriteLine("Nessun accesso precedente in archivio.");
                return;
            }
            Console.WriteLine("Lista degli accessi:");
            foreach (var accesso in Accessi)
            {
                Console.WriteLine($"- {accesso.ToShortDateString()} alle ore {accesso.ToShortTimeString()}");
            }
        }
    }
}
