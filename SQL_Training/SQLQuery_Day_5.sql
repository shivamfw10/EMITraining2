select al.title as Album,mt.name as MediaType, g.name as Genre 
from Track t join album al on t.AlbumId=al.AlbumId
join MediaType mt on mt.MediaTypeId =t.mediatypeid
join genre g on g.GenreId=t.GenreId
group by al.Title, mt.name,g.name

select t.name, count(t.name) as 'Purchase Count' from track t
join InvoiceLine i on t.TrackId=i.TrackId
group by t.name order by [Purchase Count] desc

select ar.name as ArtistName, count(t.trackid) as trackcount from track t 
join album al on t.AlbumId=al.AlbumId
join Artist ar on ar.ArtistId =al.ArtistId
join Genre g on g.GenreId=t.GenreId where g.GenreId=1
group by ar.Name order by trackcount desc

select play.name as Name, count(t.trackid) as 'Number of Tracks' from Playlist play
join PlaylistTrack pt on pt.PlaylistId=play.PlaylistId
join Track t on t.TrackId=pt.TrackId
group by play.name order by name

select CONCAT(c.FirstName,' ',c.LastName) as CustomerName, sum(i.total) as 'Amount Spent' from Customer c
join Invoice i on i.CustomerId=c.CustomerId
group by FirstName, LastName order by [Amount Spent] asc


select distinct name from Playlist
select distinct playlist.name from Playlist,
PlaylistTrack,Track,Album,Artist where 
Playlist.PlaylistId=PlaylistTrack.PlaylistId
and
Album.AlbumId=Track.AlbumId
and
Artist.ArtistId=Album.ArtistId

select * from Customer
select * from Track
select * from InvoiceLine
select * from Invoice
select * from Album
select * from Artist
Select * from Track
select * from Genre
select * from MediaType
select * from Playlist
select * from PlaylistTrack
