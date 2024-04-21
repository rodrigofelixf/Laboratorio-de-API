<h1 align="center">
  TODO List
</h1>

<p align="center">
 <a href="https://www.linkedin.com/in/rodrigofelixf/" target="_blank">
    <img src="https://img.shields.io/static/v1?label=Linkedin&message=@rodrigofelixf&color=8257E5&labelColor=000000" alt="@rodrigofelixf" />
</a>
 <img src="https://img.shields.io/static/v1?label=Tipo&message=Estudos&color=8257E5&labelColor=000000" alt="Estudos" />
</p>

Repositorio para estudos do ecosistema .NET.


## Tecnologias
 
- [ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core)
- [Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)
- [Microsoft Authentication Jwt](https://balta.io/blog/aspnet-5-autenticacao-autorizacao-bearer-jwt)
- [PostgreSql](https://www.postgresql.org/docs/)
- [Swagger](https://swagger.io/docs/)


## Referencias de estudos

- [ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core)
- [Canal Balta.IO](https://www.youtube.com/@baltaio)
- [Canal Felipe Brito Dev](https://www.youtube.com/@filipebritodev)
- [Canal LuisDev](https://www.youtube.com/@luisdev)
- [Stack Overflow](https://stackoverflow.com/questions/tagged/asp.net)
- [ChatGPT](https://chat.openai.com/)

## Como Executar

- Clonar repositório git
- Navegar ate o projeto:
```bash
$ cd Laboratorio-de-API
```
- Executar a aplicação:
```bash
$ dotnet build
$ dotnet run
```

A API poderá ser acessada em [localhost:porta].
O Swagger poderá ser visualizado em [localhost:porta/swagger-ui.html](http://localhost:porta/swagger-ui.html)

# API Endpoints

Para fazer as requisições HTTP abaixo, foi utilizada a ferramenta [httpie](https://httpie.io):
(OBS: Você tambem pode usar o Insomnia ou o Postman para fazer as requests)

## Endpoint Funcionario ("api/v1/employee")

- Criar Funcionario 
```
$ http POST :<Porta>/api/v1/employee name="Funcionario 1" age=99 photo="url/uploadfile"

[
  201 CREATED
]
```

- Listar Funcionarios - (Com quantidade de itens(5) e paginas(1))
```
$ http GET :<Porta>/api/v1/employee?pageNumber=1&itemQuantity=5

[
  {
    "id": 6,
    "nameEmployee": "Cora",
    "photo": "https://robohash.org/doloremqueeumhic.png?size=50x50&set=set1"
  },
  {
    "id": 7,
    "nameEmployee": "Fleur",
    "photo": "https://robohash.org/etsapienteexpedita.png?size=50x50&set=set1"
  },
  {
    "id": 8,
    "nameEmployee": "Georgie",
    "photo": "https://robohash.org/impeditaperiamaccusantium.png?size=50x50&set=set1"
  },
  {
    "id": 9,
    "nameEmployee": "Lane",
    "photo": "https://robohash.org/alaudantiumvitae.png?size=50x50&set=set1"
  },
  {
    "id": 10,
    "nameEmployee": "Brandais",
    "photo": "https://robohash.org/consequaturvoluptatemodio.png?size=50x50&set=set1"
  }
]
```

- Fazer Download da photo do funcionario (id(1)/download)
```
$ http GET :<Porta>/api/v1/employee/1/download


  {
    200 Ok
    PHOTO URI
  }
```

## Endpoint Autenticacao ("api/v1/auth")

- Atualizar Tarefa
```
$ http POST :<Porta>/api/v1/auth?username=felipe&password=123456

{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbXBsb3llZUlkIjoiMCIsIm5iZiI6MTcxMzc0MDkxOSwiZXhwIjoxNzEzNzUxNzE5LCJpYXQiOjE3MTM3NDA5MTl9.PlQoO288kgeDmmQtB5Yvn7x1ok9JFLKCDkjLkdH_Dgk"
}
```

