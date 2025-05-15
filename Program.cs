using System;
using SpellerCLI.Services;


namespace SpellerCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Speller CLI ===");
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Corriger l’orthographe/grammaire d’un texte en français");
            Console.WriteLine("2. Traduire le texte en anglais (US ou UK)");
            Console.WriteLine("3. Générer une page HTML à partir du texte");
            Console.Write("Votre choix (1/2/3) : ");

            string? choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Console.WriteLine("Entrez le texte à corriger :");
                    string? texteACorriger = Console.ReadLine();
                    // a faire: Appeler le service de correction IA ici
                    Console.WriteLine("[Correction IA à implémenter]");
                    break;
                case "2":
                    Console.WriteLine("Entrez le texte à traduire :");
                    string? texteATraduire = Console.ReadLine();
                    Console.Write("Traduire en anglais US ou UK ? (us/uk) : ");
                    string? variante = Console.ReadLine();
                    // a faire: Appeler le service de traduction IA ici
                    Console.WriteLine("[Traduction IA à implémenter]");
                    break;
                case "3":
                    // Demande à l'utilisateur d'écrire le texte
                    Console.WriteLine("Entrez le texte pour générer la page HTML :");
                    string? texteHtml = Console.ReadLine();

                    // Génère le code HTML avec le texte de l'utilisateur
                    string html = HtmlGenerationService.GenererHtml(texteHtml ?? "");

                    // Donne un nom au fichier qui va être créé
                    string cheminFichier = "resultat.html";

                    // Écrit le code HTML dans le fichier
                    System.IO.File.WriteAllText(cheminFichier, html);

                    // Affiche un message pour dire que le fichier a été créé
                    Console.WriteLine("La page HTML a été créée !");
                    

                    // Ouvre automatiquement le fichier dans le navigateur sur Mac
                    System.Diagnostics.Process.Start("open", System.IO.Path.GetFullPath(cheminFichier));
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez entrer 1, 2 ou 3.");
                    break;
            }
        }
    }
}
