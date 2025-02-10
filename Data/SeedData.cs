using Microsoft.EntityFrameworkCore;
using BlazorMovieApp.Models;

namespace BlazorMovieApp.Data
{
	public class SeedData
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using var context = new BlazorMovieAppContext(
				serviceProvider.GetRequiredService<DbContextOptions<BlazorMovieAppContext>>()
			);

			if (context == null || context.Movie == null)
			{
				throw new NullReferenceException(
					"Null BlazorMovieAppContext or Movie DbSet"
				);
			}
			if (context.Movie.Any())
			{
				return;
			}
			context.Movie.AddRange(
				new Movie
				{
					Title = "Mad Max",
					ReleaseDate = new DateOnly(1979, 4, 12),
					Genre = "Sci-fi (Cyberpunk)",
					Price = 2.51M
				},
				new Movie
				{
					Title = "The Road Warrior",
					ReleaseDate = new DateOnly(1981, 12, 24),
					Genre = "Sci-fi (Cyberpunk)",
					Price = 2.78M
				},
				new Movie
				{
					Title = "Mad Max: Beyond Thunderdome",
					ReleaseDate = new DateOnly(1985, 7, 10),
					Genre = "Sci-fi (Cyberpunk)",
					Price = 3.55M
				},
				new Movie
				{
					Title = "Mad Max: Fury Road",
					ReleaseDate = new DateOnly(2015, 5, 15),
					Genre = "Sci-fi (Cyberpunk)",
					Price = 8.43M
				},
				new Movie
				{
					Title = "Furiosa: A Mad Max Saga",
					ReleaseDate = new DateOnly(2024, 5, 24),
					Genre = "Sci-fi (Cyberpunk)",
					Price = 13.49M
				},
				new Movie
				{
					Title = "The Matrix",
					ReleaseDate = new DateOnly(1999, 29, 3),
					Genre = "Sci-fi (Cyberpunk)",
					Price = 5.00M
				},
				new Movie
				{
					Title = "2001: A Space Odyssey",
					ReleaseDate = new DateOnly(1968, 2, 4),
					Genre = "SCi-Fi",
					Price = 0
				},
				new Movie
				{
					Title = "Alien",
					ReleaseDate = new DateOnly(1979, 5, 25),
					Genre = "Sci-Fi",
					Price = 0
				},
				new Movie
				{
					Title = "Contact",
					ReleaseDate = new DateOnly(1997, 4, 11),
					Genre = "Sci-Fi",
					Price = 0
				},
				new Movie
				{
					Title = "Dune: Part One",
					ReleaseDate = new DateOnly(2021, 10, 27),
					Genre = "Sci-Fi",
					Price = 0
				},
				new Movie
				{
					Title = "Galaxy Quest",
					ReleaseDate = new DateOnly(1999, 12, 25),
					Genre = "Sci-fi (Comedy)",
					Price = 0
				}
			);
			context.SaveChanges();
		}
	}
}
