-- Criação da tabela de usuários
CREATE TABLE Usuarios (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Nome TEXT NOT NULL,
    Email TEXT NOT NULL UNIQUE,
    UserName TEXT NOT NULL UNIQUE,
    Senha TEXT NOT NULL
);

-- Criação da tabela de projetos
CREATE TABLE Projetos (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Titulo TEXT NOT NULL UNIQUE,
    Descricao TEXT,
    UsuarioId INTEGER NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id) ON DELETE CASCADE
);
