# FreelancerJobs API

Sistema completo para gerenciamento de projetos freelancers, com autenticação de usuários e cadastro de projetos vinculados. Desenvolvido como exercício prático de backend + frontend com integração total entre banco de dados, API REST e prototipagem.

## 🧩 Tecnologias Utilizadas

- 🎨 **Figma** – prototipagem visual da interface
- 🧰 **Angular** – frontend SPA
- 🧠 **SQLite** – banco de dados leve e portátil
- ⚙️ **.NET 8 / C#** – backend com API REST
- 🔄 **Entity Framework Core** – ORM para manipulação do banco
- 🧪 **Swagger** – documentação automática e testes da API

## 🗂️ Estrutura do Projeto

FreelancerJobs/
├── PastaBackend/ │ └── APIREST-Projeto/ │ └── FreelancerJobsAPI/ # Projeto .NET com API REST
├── PastaFrontend/ │ └── freelancer-jobs/ # Aplicação Angular


## 🔌 Endpoints da API

| Método | Rota                       | Descrição                         |
|--------|----------------------------|-----------------------------------|
| GET    | /api/projetos              | Lista todos os projetos           |
| GET    | /api/projetos/{id}         | Busca projeto por ID              |
| GET    | /api/projetos/usuario/{id} | Lista projetos de um usuário      |
| POST   | /api/projetos              | Cria novo projeto                 |
| PUT    | /api/projetos/{id}         | Atualiza projeto existente        |
| DELETE | /api/projetos/{id}         | Remove projeto                    |

## 🚀 Como Rodar Localmente

1. Clone este repositório:
   ```bash
   git clone https://github.com/MatheusBarbosaMP/FreelancerJobsAPI.git

---

🚀 Backend - API REST (C# .NET)

### 🔧 Requisitos

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- Banco de dados: SQLite

### ▶️ Como rodar

1. Navegue até a pasta da API:

cd PastaBackend/APIREST-Projeto/FreelancerJobsAPI
Execute o projeto:

Copiar
Editar
dotnet run
Acesse no navegador:

Copiar
Editar
http://localhost:5212/swagger
📘 Documentação Swagger
A API está documentada automaticamente com o Swagger UI, permitindo testar todos os endpoints diretamente do navegador.

Você pode:

Ver todos os endpoints disponíveis

Testar requisições GET, POST, PUT, DELETE

Visualizar os esquemas de request e response

🌐 Frontend - Angular
🔧 Requisitos
Node.js e npm

Angular CLI:

Copiar
Editar
npm install -g @angular/cli

▶️ Como rodar
Navegue até a pasta do frontend:

Copiar
Editar
cd PastaFrontend/freelancer-jobs
Instale as dependências:

Copiar
Editar
npm install
Inicie o servidor de desenvolvimento:

Copiar
Editar
ng serve
Acesse no navegador:

Copiar
Editar
http://localhost:4200

🎨 Protótipo no Figma
🔗 Link para o protótipo no Figma

(https://www.figma.com/proto/xOvIxWdzOULNLtfPPqNfMz/Prot%C3%B3tipo-de-Interface?node-id=1-4860&t=pR892NqHcV0geiRL-1)

📦 Banco de Dados
O projeto utiliza SQLite. Você pode consultar a estrutura no arquivo schema.sql incluso no repositório.

📌 Observações
O banco de dados está usando SQLite localmente.

Certifique-se de ter o .NET 8+ e o Node.js instalados.

👨‍💻 Autor
Desenvolvido por Matheus Barbosa

