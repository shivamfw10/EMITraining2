use Music
select * from Album
select * from Artist
select * from RecordLabel
select * from Song

--Problem No.1
select ar.name  as 'artist name',lb.name as 'record label name' from Artist ar
join RecordLabel lb on ar.LabelId=lb.LabelID

--Problem No.2
select al.Name as 'Artistname' ,count(s.Name) as 'number of songs' 
from Album al join Artist ar on al.ArtistId=ar.ArtistId
join song s on s.AlbumId=al.AlbumId
group by al.Name order by [number of songs] desc

--Problem No.3
select ar.name as 'artist', al.name as 'album' ,song.Duration as 'duration' from Album al
join Artist ar on al.ArtistId=ar.ArtistId
join Song song on Song.AlbumId=al.AlbumId
order by al.Name asc

--Problem No.4
select ar.name 'artist', al.name as 'album' from Album al
join Artist ar on ar.ArtistId=al.ArtistId where ar.Name='Metallica'

--Problem No.5
select ar.Name as 'Artistname' ,SUM(s.Duration) as 'duration of all songs' 
from Album al join Artist ar on al.ArtistId=ar.ArtistId
join song s on s.AlbumId=al.AlbumId
group by ar.Name order by [duration of all songs] desc