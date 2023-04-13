using System;
using Microsoft.AspNetCore.Identity;

namespace backend.Models
{
	public class User : IdentityUser
	{
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string ImageUrl { get; set; }
	}
}

