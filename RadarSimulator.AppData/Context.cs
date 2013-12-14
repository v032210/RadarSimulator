namespace RadarSimulator.AppData
{
	using System.Data.Entity;
	using RadarSimulator.Entities;

	public class Context: DbContext
	{
		public DbSet<User> Users { get; set; }
	}
}
