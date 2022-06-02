using System.Text.Json.Serialization;

namespace OrientationExamTryJava.Models
{
	public class Aliaser
	{
		public int Id { get; set; }
		public string Url { get; set; }
		public string Alias { get; set; }
		public int HitCount{ get; set; }
		[JsonIgnore]
		public string SecretCode{ get; set; }

		public Aliaser(string url, string alias, string secretCode,int hitCount=0)
		{
			Url = url;
			Alias = alias;
			HitCount = hitCount;
			SecretCode = secretCode;
		}
	}
}
