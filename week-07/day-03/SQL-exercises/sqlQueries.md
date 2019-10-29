Q1
1.0/1.0 point (graded)
Find the titles of all movies directed by Steven Spielberg. 
SELECT Title FROM Movie
WHERE Director = "Steven Spielberg";

Q2
1/1 point (graded)
Find all years that have a movie that received a rating of 4 or 5, and sort them in increasing order. 
SELECT DISTINCT year FROM Movie
INNER JOIN Rating ON Movie.mID=Rating.mID
WHERE stars >= 4
ORDER BY year ASC;

Q3
1/1 point (graded)
Find the titles of all movies that have no ratings. 
SELECT DISTINCT title FROM Movie
LEFT JOIN Rating ON Movie.mID=Rating.mID
WHERE rID IS NULL;

Q4
1/1 point (graded)
Some reviewers didn't provide a date with their rating. Find the names of all reviewers who have ratings with a NULL value for the date. 
SELECT name FROM Reviewer
LEFT JOIN Rating ON Reviewer.rID = Rating.rID
WHERE ratingDate IS NULL;

Q5
1/1 point (graded)
Write a query to return the ratings data in a more readable format: reviewer name, movie title, stars, and ratingDate. Also, sort the data, first by reviewer name, then by movie title, and lastly by number of stars. 
SELECT Reviewer.name, Movie.title, Rating.stars, Rating.ratingDate  FROM ((Rating
INNER JOIN Movie on Rating.mID = Movie.mID)
INNER JOIN Reviewer on Rating.rID = Reviewer.rID)
ORDER BY Reviewer.name, Movie.title, Rating.stars;