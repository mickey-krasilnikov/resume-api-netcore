﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using ResumeApp.DataAccess.Abstractions.Entities;
using ResumeApp.DataAccess.Mongo.Attributes;

namespace ResumeApp.DataAccess.Mongo.Entities
{
	[BsonCollection("resumes")]
	public class ResumeMongoEntity : IResumeEntity
	{
		[BsonId(IdGenerator = typeof(GuidGenerator))]
		public Guid Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Title { get; set; }

		public string Summary { get; set; }

		public IEnumerable<IContactEntity> Contacts { get; set; } = new HashSet<ContactMongoEntity>();

		public IEnumerable<ISkillEntity> Skills { get; set; } = new HashSet<SkillMongoEntity>();

		public IEnumerable<IExperienceEntity> Experience { get; set; } = new HashSet<ExperienceMongoEntity>();

		public IEnumerable<ICertificationEntity> Certifications { get; set; } = new HashSet<CertificationMongoEntity>();

		public IEnumerable<IEducationEntity> Education { get; set; } = new HashSet<EducationMongoEntity>();
	}
}