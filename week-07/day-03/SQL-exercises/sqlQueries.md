## Q1
Find the titles of all movies directed by Steven Spielberg.

    SELECT Title FROM Movie
    WHERE Director = "Steven Spielberg";

## Q2
Find all years that have a movie that received a rating of 4 or 5, and sort them in increasing order. 

    SELECT DISTINCT year FROM Movie
    INNER JOIN Rating ON Movie.mID=Rating.mID
    WHERE stars >= 4
    ORDER BY year ASC;

## Q3
Find the titles of all movies that have no ratings. 

    SELECT DISTINCT title FROM Movie
    LEFT JOIN Rating ON Movie.mID=Rating.mID
    WHERE rID IS NULL;

## Q4
Some reviewers didn't provide a date with their rating. Find the names of all reviewers who have ratings with a NULL value for the date. 

    SELECT name FROM Reviewer
    LEFT JOIN Rating ON Reviewer.rID = Rating.rID
    WHERE ratingDate IS NULL;

## Q5
Write a query to return the ratings data in a more readable format: reviewer name, movie title, stars, and ratingDate. Also, sort the data, first by reviewer name, then by movie title, and lastly by number of stars. 

    SELECT Reviewer.name, Movie.title, Rating.stars, Rating.ratingDate  FROM ((Rating
    INNER JOIN Movie on Rating.mID = Movie.mID)
    INNER JOIN Reviewer on Rating.rID = Reviewer.rID)
    ORDER BY Reviewer.name, Movie.title, Rating.stars;

# Extras

## Q1
Find the names of all reviewers who rated Gone with the Wind. 

    SELECT DISTINCT Reviewer.name FROM ((Rating
    INNER JOIN Movie on Rating.mID = Movie.mID)
    INNER JOIN Reviewer on Rating.rID = Reviewer.rID)
    WHERE Movie.title = "Gone with the Wind";

## Q2
For any rating where the reviewer is the same as the director of the movie, return the reviewer name, movie title, and number of stars. 

    SELECT Reviewer.name, Movie.title, Rating.stars FROM(( 
    Rating INNER JOIN Movie ON Rating.mID = Movie.mID)
    INNER JOIN Reviewer ON Rating.rID = Reviewer.rID)
    WHERE Movie.director = Reviewer.name;