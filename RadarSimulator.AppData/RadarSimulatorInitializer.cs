namespace RadarSimulator.AppData
{
	using System.Data.Entity;
	using RadarSimulator.Entities;

	public class RadarSimulatorInitializer: 
		DropCreateDatabaseAlways<Context>
	{
		protected override void Seed(Context context)
		{
			base.Seed(context);

			var user1 = new User
			{
				Name = "Leha",
				Surname = "Gruzd",
				Midname = "Dmitrievich",
				Troop = "032210"
			};

			context.Users.Add(user1);

			var user2 = new User
			{
				Name = "Dimka",
				Surname = "Horoviets",
				Midname = "Valerievich",
				Troop = "032210"
			};

			context.Users.Add(user2);

			context.SaveChanges();

		}
	}
}
