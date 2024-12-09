using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismSubmission
{
	public class Employee : IQuittable
	{
		public string firstName { get; set; }
		public string lastName { get; set; }
		public void Quit()
		{
			Console.WriteLine($"{firstName} {lastName} has quit their job.");
		}

	}
}
