use MusicDetails
SELECT * FROM Album;
SELECT * FROM Artist;
SELECT * FROM Customer;
SELECT * FROM Employee;
SELECT * FROM Genre;
SELECT * FROM Invoice;
SELECT * FROM InvoiceLine;
SELECT * FROM MediaType;
SELECT * FROM Playlist;
SELECT * FROM PlaylistTrack;
SELECT * FROM Track

--Problem No. 1 
select T.Name as 'Track Name',T.composer,T.Milliseconds,T.bytes,al.Title as 'Album Name',m.Name as 'Media Type Name',g.Name as 'Genre Name'
from Track T join Album al on T.AlbumId=al.AlbumId
join MediaType m on m.MediaTypeId=T.MediaTypeId
join Genre g on g.GenreId=T.GenreId where g.Name='Rock'
--OR
select T.Name as 'Track Name',T.composer,T.Milliseconds,T.bytes,al.Title as 'Album Name',m.Name as 'Media Type Name',g.Name as 'Genre Name'
from Track T join Album al on T.AlbumId=al.AlbumId
join MediaType m on m.MediaTypeId=T.MediaTypeId
join Genre g on g.GenreId=T.GenreId

--Problem No. 2
select concat(c.FirstName,' ',c.LastName) as 'FullName' ,inv.invoiceid as 'InvoiceId',
inv.invoicedate as 'InvoiceDate', inv.billingcountry as 'BillingCountry'
from Customer c join invoice inv on c.CustomerId=inv.CustomerId
group by c.FirstName,c.LastName ,inv.invoiceid,inv.invoicedate,inv.billingcountry having inv.BillingCountry='Brazil';

--Problem No. 3


--Problem No. 4
select (emp.FirstName+ ' '+emp.LastName) as 'Sales Agent' ,inv.invoiceid,inv.customerid,inv.invoicedate,inv.InvoiceDate,inv.billingcity,inv.billingstate,inv.billingcountry,inv.billingpostalcode,inv.total
from Employee emp join invoice inv on emp.EmployeeId=inv.InvoiceId

--Problem No. 5
select inv.invoicelineid as 'InvoiceLineId', inv.invoiceid as 'InvoiceId',
t.trackid as 'TrackId', inv.unitprice as 'UnitPrice',inv.quantity as 'Quantity',
al.title as 'Track',ar.name 'Artsist'
from track t join InvoiceLine inv on t.TrackId=inv.TrackId 
join album al on t.AlbumId=al.AlbumId
join artist ar on al.ArtistId=ar.ArtistId where InvoiceLineId in  (579,1,1154,1728,2) order by Artsist

--Problem No. 6
select emp.FirstName,emp.LastName,inv.invoiceid,inv.customerid,inv.invoicedate,inv.InvoiceDate,inv.BillingAddress,inv.billingcountry,inv.billingpostalcode,inv.total
from Employee emp join invoice inv on emp.EmployeeId=inv.InvoiceId
where emp.FirstName='Jane' AND emp.LastName='Peacock'

--Problem No. 7
select c.FirstName as 'Customer_name',inv.InvoiceDate as 'orderdate'
from Customer c join Invoice inv on c.CustomerId=inv.CustomerId where InvoiceDate<='2012-03-11' and InvoiceDate>='2012-01-01'

--Problem No.8
