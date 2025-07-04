create database biblioteca
character set utf8mb4
collate utf8mb4_unicode_ci;

use biblioteca;

CREATE TABLE Usuario(
Id int UNSIGNED AUTO_INCREMENT PRIMARY KEY,
Nome varchar(50) NOT NULL,
Email varchar(100) NOT NULL UNIQUE,
Senha varchar(100) NOT NULL,
Nacionalidade varchar(56),
DataCadastro date NOT NULL
);

CREATE TABLE Categoria(
Id int UNSIGNED PRIMARY KEY AUTO_INCREMENT,
Genero char(30) NOT NULL,
SubGenero char(30)
);

CREATE TABLE Avaliacao(
Id int UNSIGNED PRIMARY KEY AUTO_INCREMENT,
Usuario_Id int UNSIGNED,
Livro_Id int UNSIGNED,
Texto text NOT NULL
);

CREATE TABLE Livro(
Id int UNSIGNED PRIMARY KEY AUTO_INCREMENT,
Titulo varchar(50) NOT NULL,
AnoPublicacao year NOT NULL,
Genero_Id int UNSIGNED,
Sinopse text,
Avaliacao_Id int UNSIGNED,
ISBN char(20) UNIQUE,

CONSTRAINT FK_Livro_Categoria
FOREIGN KEY (Genero_Id) REFERENCES Categoria(Id),

CONSTRAINT FK_Livro_Avaliacao
FOREIGN KEY (Avaliacao_Id) REFERENCES Avaliacao(Id)
);

CREATE TABLE AutorLivro(
Livro_Id int UNSIGNED NOT NULL,
Autor_Id int UNSIGNED NOT NULL,
PRIMARY KEY (Livro_Id, Autor_Id),

FOREIGN KEY (Livro_Id) REFERENCES Livro(Id),
FOREIGN KEY (Autor_Id) REFERENCES Usuario(Id)
);