﻿using System;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Identity;

namespace backend.Models
{
	[XmlRoot(Namespace = "")]
	public class User 
	{
		public string Id { get; set; }
		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }
	}
}

