using ResumeApp.DataAccess.Mongo.Entities;
using ResumeApp.DataAccess.Sql.Entities;
using ResumeApp.Poco;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ResumeApp.UnitTests")]
namespace ResumeApp.BusinessLogic.Mappers
{
	internal static class EducationMapper
	{
		internal static Education ToEducationDto(this EducationSqlEntity entity)
		{
			if (entity == null) return null;

			return new Education
			{
				Id = entity.Id,
				Name = entity.Name,
				Degree = entity.Degree,
				FieldOfStudy = entity.FieldOfStudy,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Url = entity.Url
			};
		}

		internal static Education ToEducationDto(this EducationMongoEntity entity)
		{
			if (entity == null) return null;

			return new Education
            {
                Id = entity.Id,
                Name = entity.Name,
				Degree = entity.Degree,
				FieldOfStudy = entity.FieldOfStudy,
				StartDate = entity.StartDate,
				EndDate = entity.EndDate,
				Url = entity.Url
			};
		}

		internal static EducationMongoEntity ToEducationMongoEntity(this Education dto)
		{
			if (dto == null) return null;
			return new EducationMongoEntity
			{
				Id = dto.Id,
				Name = dto.Name,
				Degree = dto.Degree,
				FieldOfStudy = dto.FieldOfStudy,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Url = dto.Url
			};
		}

		internal static EducationSqlEntity ToEducationSqlEntity(this Education dto)
		{
			if (dto == null) return null;
			return new EducationSqlEntity
            {
                Id = dto.Id,
                Name = dto.Name,
				Degree = dto.Degree,
				FieldOfStudy = dto.FieldOfStudy,
				StartDate = dto.StartDate,
				EndDate = dto.EndDate,
				Url = dto.Url
			};
		}
	}
}
