using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleToDo.Models
{
	public class Reminder
	{
		[Key]
		[Column(Order=1)]
		public int ReminderID { get; }
		public int TaskID { get; set; }
		public DateTime ReminderDate { get; set; }
		public bool Recurring { get; set; }
		public string ReminderType { get; set; }

	}
}