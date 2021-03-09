CREATE TABLE Cars(
  Id int PRIMARY KEY IDENTITY(1,1),
  BrandId int,
  ColorId int,
  ModelYear nvarchar(25),
  DailyPrice decimal,
  Descriptions nvarchar(25),
  FOREIGN KEY (BrandID) REFERENCES Brands(BrandID),
  FOREIGN KEY (ColorID) REFERENCES Colors(ColorID)
)

CREATE TABLE Colors(
   ColorId int PRIMARY KEY IDENTITY(1,1),
   ColorName nvarchar(25),
)

CREATE TABLE Brands(
     BrandId int PRIMARY KEY IDENTITY(1,1),
     BrandName nvarchar(25),
)


INSERT INTO Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions)
VALUES
     ('1','1','2019','100','manual'),
     ('2','2','2019','200','manual'),
     ('3','3','2020','300','automatic'),
     ('4','4','2020','400','automatic');

INSERT INTO Colors(ColorName)
VALUES
    ('Mavi'),  
    ('Siyah'),  
    ('Beyaz'),  
    ('Kırmızı');
    
INSERT INTO Brands(BrandName)
VALUES
     ('NISSAN'),
     ('FIAT'),
     ('HONDA'),
     ('MITSUBISHI');

SELECT * FROM Cars
SELECT * FROM Brands
SELECT * FROM Colors