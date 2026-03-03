# 📚 BookStore - ASP.NET Core MVC

![.NET](https://img.shields.io/badge/.NET-6.0+-purple)
![C#](https://img.shields.io/badge/C%23-Programming-blue)
![MySQL](https://img.shields.io/badge/MySQL-Database-orange)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Core-green)

Sistema web de gerenciamento de livros desenvolvido com **ASP.NET Core MVC**, utilizando **Entity Framework Core** e **MySQL**.

Este projeto foi criado durante meus estudos de desenvolvimento back-end com foco em arquitetura MVC, persistência de dados e boas práticas em aplicações web.

---

## 🚀 Funcionalidades

- 📖 Cadastro de livros  
- ✏️ Edição de registros  
- 🗑️ Exclusão de livros  
- 📋 Listagem dinâmica  
- 💾 Persistência em banco MySQL  

---

## 🧠 Conceitos Aplicados

- Arquitetura MVC
- Separação de responsabilidades
- Injeção de Dependência
- Entity Framework Core (Code First)
- Migrations
- CRUD completo
- Configuração via `appsettings.json`

---

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core
- C#
- Entity Framework Core
- MySQL
- Pomelo.EntityFrameworkCore.MySql

---

# 🖥️ Como Executar o Projeto Localmente

## ✅ 1. Pré-requisitos

Instale:

- .NET SDK 6 ou superior  
- MySQL Server  
- Git (opcional)

Verifique se o .NET está instalado:

```bash
dotnet --version
```

---

## ✅ 2. Clonar o Repositório

```bash
git clone https://github.com/dayvidtp/ASPNetCore-BookStore-Project.git
cd ASPNetCore-BookStore-Project
```

---

## ✅ 3. Criar o Banco de Dados

No MySQL, execute:

```sql
CREATE DATABASE bookstore;
```

---

## ✅ 4. Configurar a String de Conexão

Edite o arquivo `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;port=3306;database=bookstore;user=root;password=SUA_SENHA"
}
```

Substitua `SUA_SENHA` pela senha do seu MySQL.

---

## ✅ 5. Restaurar Dependências

```bash
dotnet restore
```

---

## ✅ 6. Aplicar as Migrations

```bash
dotnet ef database update
```

Se necessário:

```bash
dotnet tool install --global dotnet-ef
```

---

## ✅ 7. Executar a Aplicação

```bash
dotnet run
```

O terminal exibirá algo como:

```
Now listening on: http://localhost:5000
```

Abra essa URL no navegador.

⚠️ Use exatamente a URL que aparecer no terminal (http ou https).

---

# 🏗️ Estrutura do Projeto

```
Controllers/     → Lógica da aplicação
Models/          → Entidades do domínio
Views/           → Interface (Razor)
Data/            → Contexto do banco
Migrations/      → Versionamento do banco
```

---

# 📈 Melhorias Futuras

- Implementar autenticação com Identity  
- Paginação na listagem  
- Validações avançadas  
- Deploy em ambiente cloud  
- Containerização com Docker  

---

# 👨‍💻 Autor

**Dayvid Toledo**

Desenvolvedor em evolução constante na área de desenvolvimento de software.

Este projeto representa minha prática com:

- Desenvolvimento back-end em .NET
- Integração com banco relacional
- Estruturação de aplicações web reais

---

⭐ Se este projeto te ajudou ou foi interessante, deixe uma estrela no repositório!
