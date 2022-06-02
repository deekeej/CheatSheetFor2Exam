namespace OrientationExamTryJava.Models
{
    public class MessageToBeSend
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Alias { get; set; }
        public int HitCount { get; set; }
        public MessageToBeSend(int id, string url, string alias, int hitCount)
        {
            Id = id;
            Url = url;
            Alias = alias;
            HitCount = hitCount;
        }
     
    }
}
