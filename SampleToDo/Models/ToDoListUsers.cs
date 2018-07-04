using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SampleToDo.Models
{
	public class ToDoListUsers
	{
		[Required]
		[Key, Column(Order=1)]
		public int ToDoListId { get; set; }

		[Required]
		[Key, Column(Order = 2)]
		public string UserName { get; set; }
	}
}