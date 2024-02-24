namespace ex8;

public class Post
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public int LikeCount { get; set; }
    public bool IsPublished { get; set; }
    List<string> _comments =new List<string>();
    public void Publish()
    {
        System.Console.WriteLine("The post is published.");
    }
    public void Like()
    {
        LikeCount++;
    }
    public void  Comment(string message)
    {
        _comments.Add(message);
    }
    public List<string> GetComments()
    {
        return _comments;
    }
    // public string GetInfo()
    // {
    //     return $"Title: {Title}\nDescriptoin: {Description}\nLikeCount: {LikeCount}\nPublished: {IsPublished}\nComment: ";
    // }
    
}
