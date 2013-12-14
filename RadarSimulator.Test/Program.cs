using System;
using System.Linq;

namespace RadarSimulator.Test
{
	using RadarSimulator.AppData;

	class Program
	{
		static void Main()
		{
			var db = new Context();

			//var initializer = new RadarSimulatorInitializer();

			//initializer.InitializeDatabase(db);


			var query = from b in db.Users
						orderby b.Name
						select b;

			foreach (var user in query)
			{
				Console.WriteLine(user.Id);
			}

		}
	}
}
