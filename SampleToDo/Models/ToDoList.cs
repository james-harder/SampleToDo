using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleToDo.Models
{
	public class ToDoList
	{
		[Key]
		[Column(Order=1)]
		public int ToDoListID { get; set; }

		public string Name { get; set; }
		public virtual ICollection<ToDoTask> ToDoTasks { get; set; }
	}
}