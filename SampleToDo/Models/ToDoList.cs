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
		public int ToDoId { get; }
		public string Name { get; set; }
		//public int OwnerId { get; set; }
		public ICollection<ToDoTask> ToDoTasks { get; set; }
	}
}