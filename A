CREATE TRIGGER eksiltme 
On siparistable
After insert 
as
begin
declare @satislar int
declare @urunid int
select @satislar=satisMiktar , @urunid=urunId from inserted
update urunler set miktar=miktar-@satislar where urunId=@urunid
End

Create Trigger Stokguncelle
On siparisTable
AFTER UPDATE
AS
Declare @yenisatisadedi INT
Declare @satilanadeti INT
Declare @urunid2 INT
SELECT @satilanadeti=satisMiktar, @urunid2=siparisId
From deleted
SELECT @yenisatisadedi=satisMiktar, @urunid2=siparisId
FROM inserted
UPDATE urunler SET miktar=miktar+(@satilanadeti-@yenisatisadedi)
WHERE urunId=@urunid2

Create Trigger Stokartir
On siparis
AFTER DELETE
AS
Declare @urunID INT
Declare @satilanadet INT
SELECT @urunID=urunId, @satilanadet=satisMiktar 
FROM DELETED
UPDATE urunler SET miktar=miktar+@satilanadet
WHERE urunId=@urunID

2 İnner join
Ortak kullanımı 
SELECT alanlar FROM tablo1 INNER JOIN tablo2 ON tablo1'deki ID alan = tablo2'deki ID alan

SELECT alanlar FROM tablo1 LEFT JOIN tablo2 ON tablo1'deki ID alan= tablo2'deki ID alan
SELECT alanlar FROM tablo1 RIGHT JOIN tablo2 ON o.ogrenciIDtablo1'deki ID alan= tablo2'deki ID alan
Where =o.secmeli=”ing”

listeleme
select * from ogrenci where cinsiyet='K' and sinif='10A'
SELECT alanlar FROM tablo1 FULL JOIN tablo2 ON tablo1'deki ID alan= tablo2'deki ID alan

Delete sorgu
DELETE FROM personel WHERE perdepart='Muhasebe';
Tablo ekleme Join 
INSERT INTO Ögrenci VALUES(65,'MetinYıldız','Reklam',1975,'İstanbul',1350)
Tablo update 
UPDATE Ogrenci SET dtarihi=1978 AND dyeri='Kırıkkale' WHERE ID=42
Alter Table Personel Add DogumYeri vharchar(50)NOT NULL default(space(0))

CREATE PROCEDURE isim(@isim VARCHAR(25))
	AS
	SELECT * FROM Personel WHERE peradi= @isim;
Çalıştırmak için;
	 EXECUTE isim @isim = 'Aslı';



Selects
select * from Ogrenci where cins='K’
select peradi as 'Adı',persoyad as 'Soyadı', pertel as 'Telefonu', perdepart as 'Departmanı' from personel where perdepart='Muhasebe' or perdepart='Finansman

select * from personel where peradi like '[ABM]%'
				where permaas between 10000 and 15000
				order by peradisıralama


