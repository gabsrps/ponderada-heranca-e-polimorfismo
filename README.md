Fusca.Dashboard.WebApi - Grupo Fusca
====================

Introdução
----------

Este template de documentação fornece instruções para inicializar, desenvolver e executar um back-end .NET Core MVC com C# em Docker. O Backend criado tem como objetivo buscar as informações em nosso banco de dados e as processar de forma a as disponiblizar para o nosso projeto de front-end. Nossa API trabalha tanto com os dados de saúde mental dos funcionarios quanto com as pesquisas de satisfação fornecidas pelo parceiro. Além de tambem e reponsavel pela authenticação do úsuario.

Pré-requisitos
--------------

* Visual Studio para o desenvolvimento do codigo.

Inicialização do projeto
------------------------

### Obtendo o código

* Clone o repositório do projeto:

```bash
git clone https://github.com/Inteli-College/2024-T0004-SI09-G01-API.git
```

* Ou faça o download diretamente do código-fonte.

Construção da imagem Docker
---------------------------

* Em desenvolvimento

Execução da aplicação
---------------------

* local:

Para rodar localmente a aplicação abra a solução no visual studio :

![image](https://github.com/Inteli-College/2024-T0004-SI09-G01-API/assets/99202408/6457aaa1-d688-47e2-a0f1-079b4344821c)

Após isso de o comando para iniciar a aplicação :

![image](https://github.com/Inteli-College/2024-T0004-SI09-G01-API/assets/99202408/9ea951b2-1bf7-406e-8dd8-2003f0cc4559)

E pronto !, a solução irá abrir automaticamente em seu navegador padrão :

![image](https://github.com/Inteli-College/2024-T0004-SI09-G01-API/assets/99202408/478d48e9-b11e-4613-8bc3-cf8502f3210e)


Estrutura de pastas
-------------------

```markdown
├── README.md
├── .gitignore
├── .dockerignore
├── Fusca.Dashboard.WebApi
│   ├── Controllers
│   │   └── StibaController.cs
│   ├── Dockerfile
│   ├── Fusca.Dashboard.WebApi.csproj
│   ├── Fusca.Dashboard.WebApi.http
│   ├── launchSettings.json
│   ├── Properties
│   └── Program.cs
├── Fusca.Dashboard.Services
│   ├── Stiba
│   │   ├── IStibaService.cs
│   │   └── StibaService.cs
│   └── Fusca.Dashboard.Services.csproj
├── Fusca.Dashboard.Tests
│   ├── Fusca.Dashboard.Tests.csproj
│   ├── GlobalUsings.cs
│   └── StibaTest.cs
├── Fusca.Dashboard.Repository
│   ├── CidInfoModel.cs
│   ├── GptwInfoModel.cs
│   ├── GptwPerguntasModel.cs
│   ├── IStibaRepository.cs
│   ├── StibaInfoModel.cs
│   ├── StibaPerguntasModel.cs
│   ├── StibaRepository.cs
│   └── UnidadeModel.cs
├── Fusca.Dashboard.WebApi.sin
└── workflows
    └── Fusca.Dashboard.WebApi
```

Integrantes do projeto
----------------------

- <a href="https://www.linkedin.com/in/gabriel-rocha-pinto-santos-/">Gabriel Rocha Pinto Santos</a>
- <a href="https://www.linkedin.com/in/giovanna-furlan-torres/">Giovanna Furlan Torres</a>
- <a href="https://www.linkedin.com/in/maria-lu%C3%ADsa-maia-14384a212/">Maria Luísa Vilaronga Maia</a>
- <a href="https://www.linkedin.com/in/patrick-miranda/">Patrick Victorino Miranda</a>
- <a href="https://www.linkedin.com/in/uelitonrocha/">Ueliton Moreira Rocha</a>
- <a href="https://www.linkedin.com/in/vit%C3%B3ria-rodrigues-de-oliveira/">Vitória Rodrigues de Oliveira</a>

Demais itens
------------

### Tecnologias utilizadas

* .NET Core
* C#

### Bibliotecas e Frameworks

* Entity Framework Core
* ASP.NET Core MVC
* NUnit
* Npgsql
* Dapper
* Moq

### Deploy

* Em desenvolvimento

