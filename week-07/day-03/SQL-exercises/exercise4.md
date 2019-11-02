# Exercise 4 (Extras)

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

## Q3
Return all reviewer names and movie names together in a single list, alphabetized. (Sorting by the first name of the reviewer and first word in the title is fine; no need for special processing on last names or removing "The".) 

    SELECT name FROM Reviewer
    UNION
    SELECT title from Movie
