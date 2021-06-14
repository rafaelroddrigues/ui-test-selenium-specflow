# Automation Frontend Tests - SpecFlow Selenium

O objetivo deste projeto é fornecer um bom ponto de partida para quem procura usar SpecFlow e Selenium com C# na plataforma .NET Core 3.1, demonstrando os resultados com o framework Allure Report. Também procura demonstrar uma estrutura utilizando o padrão PageObject.

**Referências**
- [Selenium](http://www.seleniumhq.org/)
- [SpecFlow](http://specflow.org/)
- [Allure](https://docs.qameta.io/allure/)
- [Webdriver Manager](https://www.npmjs.com/package/webdriver-manager)

### Setup - Windows

Download e instale [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/).

#### Visual Studio - Extension

Download e instale a extensão [SpecFlow for Visual Studio 2019](https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio) na sua IDE.

#### Visual Studio Code - Extension

Download e instale a extensão [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer) na sua IDE.
Esta extensão permite visualizar os testes, para isso crie o arquivo *.vscode/settings.json*, com o seguinte conteúdo.

```
{
    "dotnet-test-explorer.testProjectPath": "**/*(nome do diretório onde está seu projeto).csproj"
}
```
Se os testes não forem exibidos no Test Explorer, de acordo com esta [issue](https://github.com/formulahendry/vscode-dotnet-test-explorer/issues/77) será necessário deletar o diretório correspondente à linguagem padrão que está sendo usada pela SDK, localizado em "dotnet-install-directory/sdk/sdk-version".

#### Instale Scoop (utilitário para instalar programas pela linha de comando)

**Requerimentos**
- [PowerShell 3](https://www.microsoft.com/en-us/download/details.aspx?id=34595)

Para instalar o Scoop abra o PowerShell e executa os seguintes comandos.
```
$ set-executionpolicy unrestricted -s cu
```
```
$ iex (new-object net.webclient).downloadstring('https://get.scoop.sh')
```

#### Git

Instale o Git para conseguir clonar o projeto para sua máquina.
```
$ scoop install git
```

### Clone

Clone o projeto.
```
$ git clone TODO
```

### Webdriver Manager

**Requerimentos**
- [Node.js](https://nodejs.org/en/)

Instale o Webdriver Manager para resolver possíveis incompatibilidades entre o webdriver e a versão do browser.
```
$ npm install -g webdriver-manager
```

### Allure Report

Instale o Allure Report.

```
$ scoop install allure
```
```
$ scoop update allure
```

#### Executando Testes

**Requerimentos**
- Inicie o Selenium Server.

```
$ webdriver-manager update
```
```
$ webdriver-manager start
```

Você pode executar no Test Explorer da sua IDE escolhida ou via command line.

Build.
```
$ dotnet build
```

Exeuctar todos os testes.
```
$ dotnet test
```
Exeuctar apenas um teste.
```
$ dotnet test --filter "FullyQualifiedName~(ParteUnicaDoNomeDoCenario)"
```

Entao você pode gerar um html report via Allure.
```
$ allure generate "allure-results-directory" -c
```
E abrir o report.
```
$ allure open "allure-report-directory"
```
