using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPGA.Data.Models
{
	[NotMapped]
	public class DataModel_Base
	{
		public Guid ID { get; set; }
	}
}