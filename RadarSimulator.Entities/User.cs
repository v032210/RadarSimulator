namespace RadarSimulator.Entities
{
	public class User: IEntity
	{
		
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string Midname { get; set; }
		public string Troop { get; set; }
	}
}
