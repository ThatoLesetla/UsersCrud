using System;
using AutoMapper;
using backend.DTOs;

namespace backend.Models
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Student, StudentDTO>();
			CreateMap<StudentDTO, Student>();
			CreateMap<User, UserDTO>();
			CreateMap<UserDTO, User>();
		}
	}
}

