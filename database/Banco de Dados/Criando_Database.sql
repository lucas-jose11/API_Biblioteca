CREATE DATABASE biblioteca;
Use biblioteca;

CREATE TABLE Cartao(
Id int PRIMARY KEY AUTO_INCREMENT,
Validade date NOT NULL
);

CREATE TABLE Leitor(
Id int PRIMARY KEY AUTO_INCREMENT,
Nome varchar(50) NOT NULL,
Email varchar(50) NOT NULL,
Cartao_Id int,
CONSTRAINT ´FK_LEITOR_CARTAO´ FOREIGN KEY (Cartao_Id) REFERENCES Cartao(Id)
);

CREATE TABLE Livro(
Id int PRIMARY KEY AUTO_INCREMENT,
Titulo varchar(50) NOT NULL,
Autor varchar(50) NOT NULL,
Ano_Publicacao int NOT NULL
);

CREATE TABLE Leitor_Livro(
Leitor_Id int,
Livro_Id int,
Data_Emprestimo date NOT NULL,
Data_Devolucao date,
CONSTRAINT ´FK_LEITOR_LIVRO_LEITOR´ FOREIGN KEY (Leitor_Id) REFERENCES Leitor(Id),
CONSTRAINT ´FK_LEITOR_LIVRO_LIVRO´ FOREIGN KEY (Livro_Id) REFERENCES Livro(Id)
);