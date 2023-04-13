using System;
using backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend.Configuration
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder) {
			builder.HasData(
				new Student {
					Id = Guid.NewGuid(),
					FirstName = "Thato",
					LastName = "Lesetla",
					Email = "tlesetla6198@gmail.com",
					Phone = "0684070734",
					Bio = "I love programming",
					Country = "South Afirca",
					Province = "Gauteng",
					City = "Randburg",
					PostalCode = "1575",
					Address = "Fairland"
				}
				);
		}
	}
}

