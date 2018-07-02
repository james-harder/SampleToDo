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
		[Key]
		[Column(Order = 1)]
		public int ToDoTaskID { get; set; }
		// The ToDoList that this ToDoTask belongs to
		// Should there be the ability for one ToDOTask to be on more than one ToDOList ?

		public ToDoList ToDoList { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool TaskDone { get; set; }
		public DateTime DueDate { get; set; }
		public virtual ICollection<Reminder> Reminders { get; set; }
		
	}
}