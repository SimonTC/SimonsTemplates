# Simon's Templates
A collection of useful templates to use with `dotnet new`

Currently only a template for a dotnet standard F# library exists.

The templates here have been inspired by the [MiniScaffold](https://github.com/TheAngryByrd/MiniScaffold) project.
I decided to create my own templates to make sure I understand all the parts that are created.

## Getting started
### Clone the repository:
```
git clone git@github.com:SimonTC/SimonsTemplates.git
```

### Install the template:
```
dotnet new -i <pathToRepository>

Example: dotnet new -i "D:\projects\SimonsTemplates"
```

### Use the template:
You can do it in two ways. Either create the folder manually:
```
mkdir MyNewFSharpProject
cd MyNewFSharpProject
dotnet new fsharp-scaffold
```
You can also let the folder be auto created:
```
dotnet new fsharp-scaffold -o MyNewFSharpProject
cd MyNewFSharpProject
```

The scaffold created will look something like this:
```
$ tree /f
.
│   .gitignore
│   paket.cmd
│   paket.sh
│   init.cmd
│   MyNewFSharpProject.sln
│   LICENSE.md
│   paket.dependencies
│
├───src
│   └───MyNewFSharpProject
│           MyNewFSharpProject.fsproj
│           Library.fs
|           Scratchpad.fsx
│           paket.references
│
└───tests
    └───MyNewFSharpProject.Tests
            MyNewFSharpProject.Tests.fsproj
            UniotTests.fs
            paket.references
            PropertyTests.fs
```

### Initialize the project:
```
init.cmd
```
This will automatically install paket and install all needed dependencies.

### Using Paket:
On Windows:
```
paket.cmd <command>

Example: paket.cmd install
```

On Linux:
```
./paket.sh <command>

Example: ./paket.sh install
```

## Uninstalling the template
```
dotnet new -u <pathToRepository>
```
Example:
```
dotnet new -u "D:\projects\SimonsTemplates"
```

#### This project uses the following projects:
* [Paket](https://fsprojects.github.io/Paket/)
* [FAKE](https://fsharp.github.io/FAKE/)
* Inspired by [MiniScaffold](https://github.com/TheAngryByrd/MiniScaffold)
* [NUnit](https://github.com/nunit/nunit)
* [FsCheck](https://github.com/fscheck/FsCheck)
