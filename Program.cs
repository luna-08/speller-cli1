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
            Console.WriteLine("1. Correction de ton texte en français");
            Console.WriteLine("2. Traduction en anglais (US ou UK)");
            Console.WriteLine("3. Généreration page HTML à partir du texte");
            Console.Write("Votre choix (1/2/3) : ");

            string? choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    Console.WriteLine("Entrez le texte à corriger :");
                    string? texteACorriger = Console.ReadLine();
                    // a faire: Appeler le service de correction IA
                    Console.WriteLine("[Correction IA que je dois implémenter]");
                    break;
                case "2":
                    Console.WriteLine("Entrez le texte à traduire :");
                    string? texteATraduire = Console.ReadLine();
                    Console.Write("Traduire en anglais US ou UK ? (us/uk) : ");
                    string? variante = Console.ReadLine();
                    // a faire: Appeler le service de traduction IA 
                    Console.WriteLine("[Traduction IA que je dois implémenter]");
                    break;
                case "3":
                    Console.WriteLine("Entrez le texte pour générer la page HTML :");
                    string? texteHtml = Console.ReadLine();
                    string html = HtmlGenerationService.GenererHtml(texteHtml ?? "");
                    string cheminFichier = "resultat.html";

                    // le code HTML dans le fichier
                    System.IO.File.WriteAllText(cheminFichier, html);

                    // Affiche un message pour dire que le fichier a été créé
                    Console.WriteLine("La page HTML a été créée !");
                    

                    // Ouvre automatiquement le fichier dans le navigateur (option que j'ai trouvé)
                    System.Diagnostics.Process.Start("open", System.IO.Path.GetFullPath(cheminFichier));
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez entrer 1, 2 ou 3.");
                    break;
            }
        }
    }
}
