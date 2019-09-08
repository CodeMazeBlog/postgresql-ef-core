using System;

namespace EFCorePostgreSQL.Entities
{
	public class Student
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
