# Framework Programming Assignment

> 5025201161

> Venia Sollery Aliyya Hasna


This application is able to display films and series when `Get Movies` button is clicked it will load and display the movies and series. Users can click on a specific movie or series to get the detailed information. The application is equipped with adaptive theme, so users can change between light and dark theme.

### Find another JSON dataset and use it in your project.
##

For this assignment, I chose to use a JSON data about movies and series. This database includes the Title, Rated, Year of Released, and etc.

```json
[
    ...
    {
        "Title": "300",
        "Year": "2006",
        "Rated": "R",
        "Released": "09 Mar 2007",
        "Runtime": "117 min",
        "Genre": "Action, Drama, Fantasy",
        "Director": "Zack Snyder",
        "Writer": "Zack Snyder (screenplay), Kurt Johnstad (screenplay), Michael Gordon (screenplay), Frank Miller (graphic novel), Lynn Varley (graphic novel)",
        "Actors": "Gerard Butler, Lena Headey, Dominic West, David Wenham",
        "Plot": "King Leonidas of Sparta and a force of 300 men fight the Persians at Thermopylae in 480 B.C.",
        "Language": "English",
        "Country": "USA",
        "Awards": "16 wins & 42 nominations.",
        "Poster": "http://ia.media-imdb.com/images/M/MV5BMjAzNTkzNjcxNl5BMl5BanBnXkFtZTYwNDA4NjE3._V1_SX300.jpg",
        "Metascore": "52",
        "imdbRating": "7.7",
        "imdbVotes": "611,046",
        "imdbID": "tt0416449",
        "Type": "movie",
        "Response": "True",
        "Images": [
          "https://images-na.ssl-images-amazon.com/images/M/MV5BMTMwNTg5MzMwMV5BMl5BanBnXkFtZTcwMzA2NTIyMw@@._V1_SX1777_CR0,0,1777,937_AL_.jpg",
          "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQwNTgyNTMzNF5BMl5BanBnXkFtZTcwNDA2NTIyMw@@._V1_SX1777_CR0,0,1777,935_AL_.jpg",
          "https://images-na.ssl-images-amazon.com/images/M/MV5BMTc0MjQzOTEwMV5BMl5BanBnXkFtZTcwMzE2NTIyMw@@._V1_SX1777_CR0,0,1777,947_AL_.jpg"
        ]
      },
      {
        "Title": "The Avengers",
        "Year": "2012",
        "Rated": "PG-13",
        "Released": "04 May 2012",
        "Runtime": "143 min",
        "Genre": "Action, Sci-Fi, Thriller",
        "Director": "Joss Whedon",
        "Writer": "Joss Whedon (screenplay), Zak Penn (story), Joss Whedon (story)",
        "Actors": "Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth",
        "Plot": "Earth's mightiest heroes must come together and learn to fight as a team if they are to stop the mischievous Loki and his alien army from enslaving humanity.",
        "Language": "English, Russian",
        "Country": "USA",
        "Awards": "Nominated for 1 Oscar. Another 34 wins & 75 nominations.",
        "Poster": "http://ia.media-imdb.com/images/M/MV5BMTk2NTI1MTU4N15BMl5BanBnXkFtZTcwODg0OTY0Nw@@._V1_SX300.jpg",
        "Metascore": "69",
        "imdbRating": "8.1",
        "imdbVotes": "1,003,301",
        "imdbID": "tt0848228",
        "Type": "movie",
        "Response": "True",
         "Images": [
          "https://images-na.ssl-images-amazon.com/images/M/MV5BMTA0NjY0NzE4OTReQTJeQWpwZ15BbWU3MDczODg2Nzc@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
          "https://images-na.ssl-images-amazon.com/images/M/MV5BMjE1MzEzMjcyM15BMl5BanBnXkFtZTcwNDM4ODY3Nw@@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
          "https://images-na.ssl-images-amazon.com/images/M/MV5BMjMwMzM2MTg1M15BMl5BanBnXkFtZTcwNjM4ODY3Nw@@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
          "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ4NzM2Mjc5MV5BMl5BanBnXkFtZTcwMTkwOTY3Nw@@._V1_SX1777_CR0,0,1777,999_AL_.jpg",
          "https://images-na.ssl-images-amazon.com/images/M/MV5BMTc3MzQ3NjA5N15BMl5BanBnXkFtZTcwMzY5OTY3Nw@@._V1_SX1777_CR0,0,1777,999_AL_.jpg"
        ]
      },

  ...
  ]
  
  ```
  The JSON file can be found in `/Movies/Movies/Resources/Raw/Movies.json `
  
  ##



### Create an application with two screens: the main screen and the detail screen.
##

<div align="center">  
  <span><img src="./resources/MainPage.gif" width="20%" height="20%"/></span>
  <img src="./resources/transparent.png" height=50 width=150 /><!--invisible-->
  <span><img src="./resources/MainToDetails.gif" width="20%" height="20%"/></span>
</div>

<div align="center">  
  <span>Main Page</span>
  <img src="./resources/transparent.png" height=50 width=300 /><!--invisible-->
  <span>Details Page</span>
</div>


 


##

### Application should be able to detect the internet connection status.
##

<div align="center">
    <img src="./resources/Connectivity.gif" width="20%" height="20%"/>
</div>


##

### Add the adaptive theme functionality to your apps.
##

