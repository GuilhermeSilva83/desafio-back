## Projeto de teste.

Requisitos:
[**.Net Core 3.1**](https://dotnet.microsoft.com/download/dotnet-core/3.1)

Abra a solução no Visual Studio.

###Para preparar o projeto "Desafio.MainApi":
* Marcar como **"Startup Project"**
* Alterar o arquivo: **appsettings.json**, trocando a variável **"DefaultConnection"**, para uma base de dados local.
* No console do NuGet, escolha o projeto **Desafio.Infra.Repositories.MainContext**
* Por fim, execute a linha de código abaixo:

>
    Update-Database


###Para preparar o projeto "Desafio.UserApi":
* Marcar como **"Startup Project"**
* Alterar o arquivo: **appsettings.json**, trocando a variável **"DefaultConnection"**, para uma base de dados local.
* No console do NuGet, escolha o projeto **Desafio.Infra.Repositories.MembershipContext**
* Por fim, execute a linha de código abaixo:

>
    Update-Database


Rode ambos os projetos.

No Angular:
Altere o arquivo **environment.ts** ou **environment.prod.ts** mudando o valor da propriedade **mainApiUrl** e **membershipApiUrl**   e p/ a nova url/porta que for gerada.
