# Speller CLI

Speller CLI est une application console en C# permettant :
- de corriger l’orthographe/grammaire d’un texte en français,
- de traduire un texte en anglais (US ou UK),
- de générer une page HTML stylisée à partir d’un texte.

## Prérequis

- [.NET 6 ou supérieur](https://dotnet.microsoft.com/download)
- Une clé API OpenAI pour la correction et la traduction
- un éditeur de texte

## Installation

Clone ce dépôt puis place-toi dans le dossier du projet :

```bash
git clone https://github.com/<ton-utilisateur>/<nom-du-repo>.git
cd final_project
```

## Utilisation

Compile et lance l’application :

dotnet run


Suis les instructions dans le terminal pour choisir une option et entrer ton texte.

### Génération de page HTML

Quand tu choisis l’option 3, un fichier `resultat.html` est créé dans le dossier du projet.  
Et il s'ouvrira automatiquement sur ton navigateur


## API OpenAI 

Pour utiliser la correction et la traduction automatiques, il faudrait ajouter une clé API OpenAI dans une variable d’environnement :


export OPENAI_API_KEY=sk-...

