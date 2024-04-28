using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Chemin du dossier d'entrée et de sortie
        string inputDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "old");
        string outputDirectoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "new");

        // Vérifier si le dossier de sortie existe, sinon le créer
        if (!Directory.Exists(outputDirectoryPath))
        {
            Directory.CreateDirectory(outputDirectoryPath);
        }

        // Obtenir tous les fichiers .cs dans le dossier d'entrée (sauf sample.cs)
        string[] inputFiles = Directory.GetFiles(inputDirectoryPath, "*.cs");

        // Parcourir tous les fichiers d'entrée dans le dossier
        foreach (string inputFilePath in inputFiles)
        {
            // Lire le contenu du fichier d'entrée
            string fileContent = File.ReadAllText(inputFilePath);

            // Ignorer le fichier sample.cs
            if (Path.GetFileName(inputFilePath) == "sample.cs")
            {
                continue;
            }

            // Remplacer les lignes "insert here your path" par le contenu du fichier .cs
            string sampleFilePath = Path.Combine(inputDirectoryPath, "sample.cs");
            string sampleContent = File.ReadAllText(sampleFilePath);
            string mergedContent = sampleContent.Replace("insert here your path", fileContent);

            // Chemin de sortie du fichier fusionné
            string outputFileName = Path.GetFileName(inputFilePath);
            string outputFilePath = Path.Combine(outputDirectoryPath, outputFileName);

            // Écrire le contenu fusionné dans le fichier de sortie
            File.WriteAllText(outputFilePath, mergedContent);

            Console.WriteLine($"Le contenu du fichier {inputFilePath} a été intégré à {outputFilePath}");
        }

        Console.WriteLine("Assemblage terminé.");
    }
}