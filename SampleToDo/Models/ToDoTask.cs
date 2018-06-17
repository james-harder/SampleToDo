using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleToDo.Models
{
	public class ToDoTask
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public bool TaskDone { get; set; }
		public DateTime DueDate { get; set; }
		public ICollection<Reminder> Reminders { get; set; }
		[Key]
		[Column(Order=1)]
		public int TaskID { get; }
		//public int OwnerID { get; set; }
	}
}