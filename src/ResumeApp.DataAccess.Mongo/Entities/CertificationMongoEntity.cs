namespace ResumeApp.DataAccess.Mongo.Entities
{
	public class CertificationMongoEntity
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public string Issuer { get; set; }

		public DateOnly IssueDate { get; set; }

		public DateOnly? ExpirationDate { get; set; }

		public Uri VerificationUrl { get; set; }
	}

}