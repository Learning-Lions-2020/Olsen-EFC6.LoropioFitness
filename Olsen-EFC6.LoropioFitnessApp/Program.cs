using EFC6.Loropio_Fitness.Console;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        using (var context = new FitnessAppContext())

        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            CreateRunActivity(context, 1, "Morning Run", 5.2, TimeSpan.FromMinutes(30), DateTime.Now);

            DisplayAllRunActivities(context);

        }
    }
    // Method to create a RunActivity
    static void CreateRunActivity(FitnessAppContext context,int userId, string name, double distance, TimeSpan duration, DateTime date)
    {
        var runActivity = new RunActivity
        {
            UserId = userId,
            Name = name,
            Distance = distance,
            Duration = duration,
            Date = date
        };

        context.RunActivities.Add(runActivity);
        context.SaveChanges();
    }

    static void DisplayAllRunActivities(FitnessAppContext context)
    {
        List<RunActivity> activities = context.RunActivities.ToList();

        Console.WriteLine("----- All Run Activities -----");
        foreach (var activity in activities)
        {
            Console.WriteLine(
                $"ID: {activity.Id}, " +
                $"Name: {activity.Name}, " +
                $"Distance: {activity.Distance} km, " +
                $"Duration: {activity.Duration}, " +
                $"Date: {activity.Date.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture)}"
            );
        }
    }

    
}
