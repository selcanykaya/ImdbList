using IMDB;

List<Movies> movies = new List<Movies>(); // Initialize the list to store movie objects

while (true) // Loop to continuously accept movie details
{
    Console.WriteLine("Enter movie title (press e to quit):");
    string title = Console.ReadLine();

    if (title.ToLower() == "e") // Check if the user wants to exit
    {
        break;
    }
    Console.WriteLine("Enter movie rating:");
    double rating = Convert.ToDouble(Console.ReadLine());
    movies.Add(new Movies // Create a new movie object and add it to the list
    {
        Title = title,
        Rating = rating
    });

}

Console.WriteLine("All Movies List:"); // Display all movies
foreach (var movie in movies)
{
    Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}");
}

Console.WriteLine("All Movies with a rating score between 4 and 9:");// Display movies with rating between 4 and 9
foreach (var movie in movies)
{
    if (movie.Rating >= 4 && movie.Rating <= 9)
        Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}");
}

Console.WriteLine("All Movies starting with letter 'A'");// Display movies starting with letter 'A'
foreach (var movie in movies)
{
    if (movie.Title[0] == 'A' || movie.Title[0] == 'a')
    {
        Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}");
    }
}