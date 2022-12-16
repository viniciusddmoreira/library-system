# Library System (Sistema de Biblioteca)

Projeto do desafio final desenvolvido na academia .NET entre a empresa *Atos* e a *Universidade Franciscana*.

# Visão Geral

Foi desenvolvido um projeto Web com ASP.NET Core MVC, o qual faz gestão de emprestimos de livros, 
clientes e livros.  
Além disso, foi utilizado o Entity Framework Core para interação com o banco de dados, 
fazendo uso do SQL Server.

# Objetivo

O sistema desenvolvido tem como objetivo atender aos requisitos básicos da rotina de uma biblioteca:

## :red_haired_woman: Cadastro de Clientes
- Os clientes podem ser cadastrados, alterados, buscados e excluídos.
- Para a busca de clientes, é possível filtrá-los por qualquer uma das colunas exibidas na tela, 
sendo elas: CPF, nome, número do celular e e-mail.

## :books: Cadastro de Livros
- Os livros podem ser cadastrados, alterados, buscados e excluídos.
- Para a busca de livros, é possível filtrá-los por qualquer uma das colunas exibidas na tela, 
sendo elas: nome, autor, editora, data de publicação e edição.

## :computer: Gestão de Empréstimos
- Para clientes cadastrados, pode-se realizar empréstimos de livros, bem como edição e busca de
empréstimos, e também devoluções.
- Para a busca de empréstimos, é possível filtrá-los por qualquer uma das colunas exibidas na tela, 
sendo elas: CPF do cliente, nome do cliente, nome do livro, data de empréstimo,
data de devolução.

# Tecnologias Utilizadas

As seguintes tecnologias foram utilizadas:

- .NET 6.0
- ASP .NET Core MVC
- Microsoft SQL Server
- Entity Framework Core
- EF Core Power Tools
- DataTables (plug-in para a biblioteca Javascript jQuery)
- Bootstrap’s JavaScript modal plugin
- Bootstrap v5.2.3
- Git

O projeto foi separado em LibrarySystem.Web, que seria a camada de apresentação 
com o projeto MVC; e em LibrarySystem.Data, onde se localizam as camadas referentes 
aos dados do serviço, com modelos de domínio, repositórios e configurações do banco 
de dados.  

Pela natureza dos dados, foi utilizado um banco relacional, Microsoft SQL Server.
Além disso, o Entity Framework Core foi utilizado para abstrair as interações com o 
banco de dados, aumentando a produtividade durante o desenvolvimento. O mesmo se aplica 
ao EF Core Power Tools, que com a abordagem *Database First* permite que os models
sejam gerados a partir de um diagrama entidade-relacionamento.  

Por fim, o Git foi utilizado como ferramenta de versionamento durante todo o desenvolvimento.

# Telas

### Tela Principal
![image](https://user-images.githubusercontent.com/83368340/208149339-df2cdc2a-dd2b-45c9-a5b1-c78a6437a716.png)

### Tela de Clientes Cadastrados
![image](https://user-images.githubusercontent.com/83368340/208149934-fecd761b-37ed-4a60-b5e9-4ab003aa3d52.png)

### Tela de Livros Cadastrados
![image](https://user-images.githubusercontent.com/83368340/208149979-d57a8db5-11ee-4dee-81b3-51f84369fc96.png)

### Tela Novo Empréstimo
![image](https://user-images.githubusercontent.com/83368340/208150058-3e5267c3-bc6e-4afe-b4da-17a89b439435.png)
![image](https://user-images.githubusercontent.com/83368340/208181044-6405911b-d57c-45bf-afc9-a53b08ea9d85.png)








