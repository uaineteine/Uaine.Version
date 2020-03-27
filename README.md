# VersionController

A simple version controller written in c# for .NET core.

Adaptable number of signifgant digits, special attribute names and comparisons of version numbers.

## Getting Started

Compling yourself: Use Visual Studio and the project file to create either a new project to be modified or add to a solution for use as a DLL.

### Requires:

This project is target for .NET standard 2.0. It should be compliant with earlier versions of course, however when compiling with VS, one will have to change the project settings.

### Installing

##### Building with Windows:

Use Visual Studio with the project as a reference to build the project file into an DLL for an app.

##### Building with Linux:

Open terminal/cmd and use .NET core to build with:

```
dotnet publish -c release -r ubuntu.16.04-x64 --self-contained
```

## Authors

* **Daniel Stamer-Squair** - *UaineTeine*

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details