use Склад_Товаров
go

CREATE TABLE Контрагент 
(
    Код_Контрагента INT PRIMARY KEY,
    Наименование_Контрагента VARCHAR(255)
);

CREATE TABLE Склад 
(
    Код_Склада INT PRIMARY KEY,
    Наименование_Склада VARCHAR(255)
);

CREATE TABLE Поставка 
(
    Номер_Накладной INT PRIMARY KEY,
    Код_Контрагента INT,
    Код_Склада INT,
    Дата_Поставки DATE,
    FOREIGN KEY (Код_Контрагента) REFERENCES Контрагент(Код_Контрагента),
    FOREIGN KEY (Код_Склада) REFERENCES Склад(Код_Склада)
);

CREATE TABLE Отпуск 
(
    Номер_Накладной INT PRIMARY KEY,
    Код_Контрагента INT,
    Код_Склада INT,
    Дата_Отпуска DATE,
    FOREIGN KEY (Код_Контрагента) REFERENCES Контрагент(Код_Контрагента),
    FOREIGN KEY (Код_Склада) REFERENCES Склад(Код_Склада)
);

CREATE TABLE Товар 
(
    Код_Товара INT PRIMARY KEY,
    Наименование_Товара VARCHAR(255),
    Единица_Измерения VARCHAR(50),
    Цена_Поставщика DECIMAL(10, 2),
    Цена_Продажи DECIMAL(10, 2),
    Учетная_Цена DECIMAL(10, 2)
);

CREATE TABLE Спецификация_Отпуска_Со_Cклада 
(
    Номер_Накладной INT,
    Код_Товара INT,
    Количество INT,
    FOREIGN KEY (Номер_Накладной) REFERENCES Отпуск(Номер_Накладной),
    FOREIGN KEY (Код_Товара) REFERENCES Товар(Код_Товара)
);

CREATE TABLE Спецификация_Поставки 
(
    Номер_Накладной INT,
    Код_Товара INT,
    Количество INT,
    FOREIGN KEY (Номер_Накладной) REFERENCES Поставка(Номер_Накладной),
    FOREIGN KEY (Код_Товара) REFERENCES Товар(Код_Товара)
);

CREATE TABLE Регистр_цен_продаж
(
    Дата DATE PRIMARY KEY,
    Код_товара INT,
    Цена_продажи DECIMAL,
    FOREIGN KEY (Код_товара) REFERENCES Товар(Код_товара)
);