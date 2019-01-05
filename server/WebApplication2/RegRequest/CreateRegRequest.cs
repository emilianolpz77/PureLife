using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.RegRequest
{
	public class CreateRegRequest
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string Interests { get; set; }
		[Required]
		public string Skills { get; set; }
	}

	public class UpdateRegRequest
	{
		[Required]
		public int? Id { get; set; }
	}
	public class DeleteRegRequest
	{
		[Required]
		public int Id { get; set; }
	}
}