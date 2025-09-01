using System;

namespace Persistence;
using Domain;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>
        {
            new() {
                Title = "Past Activity 1",
                Date = DateTime.Now.AddMonths(-2),
                Description = "Activity 2 months ago",
                Category = "drinks",
                City = "London",
                Venue = "Pub",
                Longitude = -0.12574,
                Latitude = 51.50853
            },
            new() {
                Title = "Past Activity 2",
                Date = DateTime.Now.AddMonths(-1),
                Description = "Activity 1 month ago",
                Category = "culture",
                City = "Paris",
                Venue = "Louvre",
                Longitude = 2.336443,
                Latitude = 48.860846
            },
            new() {
                Title = "Future Activity 1",
                Date = DateTime.Now.AddMonths(1),
                Description = "Activity 1 month in future",
                Category = "music",
                City = "New York",
                Venue = "Madison Square Garden",
                Longitude = -73.993439,
                Latitude = 40.750504
            },
            new() {
                Title = "Future Activity 2",
                Date = DateTime.Now.AddMonths(2),
                Description = "Activity 2 months in future",
                Category = "food",
                City = "Rome",
                Venue = "Pizzeria",
                Longitude = 12.496366,
                Latitude = 41.902782
            },
            new() {
                Title = "Future Activity 3",
                Date = DateTime.Now.AddMonths(3),
                Description = "Activity 3 months in future",
                Category = "travel",
                City = "Tokyo",
                Venue = "Shibuya Crossing",
                Longitude = 139.700464,
                Latitude = 35.6595
            },
            new() {
                Title = "Future Activity 4",
                Date = DateTime.Now.AddMonths(4),
                Description = "Activity 4 months in future",
                Category = "film",
                City = "Los Angeles",
                Venue = "Hollywood Sign",
                Longitude = -118.321548,
                Latitude = 34.134115
            },
            new() {
                Title = "Future Activity 5",
                Date = DateTime.Now.AddMonths(5),
                Description = "Activity 5 months in future",
                Category = "drinks",
                City = "Sydney",
                Venue = "Opera House",
                Longitude = 151.215256,
                Latitude = -33.856784
            },
        };

        await context.Activities.AddRangeAsync(activities);
        await context.SaveChangesAsync();
    }

}
