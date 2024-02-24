

using ex8;

var post1 = new Post();
post1.Title="Weekend";
post1.Description="nature,travel";
post1.LikeCount=5;
post1.IsPublished=true;
post1.Publish();
post1.Like();
post1.Like();
post1.Like();
post1.Like();
post1.Like();
post1.Comment("Crazy");
post1.Comment("Cool");
post1.Comment("Super");
post1.Comment("blabla");
post1.Comment("invn");
// System.Console.WriteLine(post.GetInfo());
post1.GetComments();
foreach (var item in post1.GetComments())
{
    System.Console.WriteLine($"Title:{post1.Title}\nDescription:{post1.Description}\nNumber of Likes:{post1.LikeCount}\nPublished:{post1.IsPublished}");
    break ;
}
System.Console.WriteLine("Comments :" );
foreach (var item in post1.GetComments())
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("----------------------------");
var post2 = new Post();
post2.Title="C#";
post2.Description="OOP programming";
post2.LikeCount=0;
post2.IsPublished=true;
post2.Publish();
post2.Like();
post2.Like();
post2.Like();
post2.Like();
post2.Like();
post2.Comment("skdvnskv");
post2.Comment("sdk sdv ");
post2.Comment("sd vsdv");
post2.Comment("kdnskflDF");
post2.Comment("FMWKF IWEFMK");
// System.Console.WriteLine(post.GetInfo());
post2.GetComments();
foreach (var item in post2.GetComments())
{
    System.Console.WriteLine($"Title:{post2.Title}\nDescription:{post2.Description}\nNumber of Likes:{post2.LikeCount}\nPublished:{post2.IsPublished}");
    break ;
}
System.Console.WriteLine("Comments :" );
foreach (var item in post2.GetComments())
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("----------------------------");
var post3 = new Post();
post3.Title="JS";
post3.Description="Course of Java Script";
post3.LikeCount=0;
post3.IsPublished=true;
post3.Publish();
post3.Like();
post3.Like();
post3.Like();
post3.Like();
post3.Like();
post3.Comment("infin");
post3.Comment("lsdem1");
post3.Comment("34234");
post3.Comment("skdsdkn3");
post3.Comment("s,skd`");
// System.Console.WriteLine(post.GetInfo());
post3.GetComments();
foreach (var item in post3.GetComments())
{
    System.Console.WriteLine($"Title:{post3.Title}\nDescription:{post3.Description}\nNumber of Likes:{post3.LikeCount}\nPublished:{post3.IsPublished}");
    break ;
}
System.Console.WriteLine("Comments :" );
foreach (var item in post3.GetComments())
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("----------------------------");
var post4 = new Post();
post4.Title="DotNet";
post4.Description="Course of Dotnet dsss";
post4.LikeCount=93;
post4.IsPublished=true;
post4.Publish();
post4.Like();
post4.Like();
post4.Like();
post4.Like();
post4.Like();
post4.Comment("vmkdfns");
post4.Comment("kdvkdvn");
post4.Comment("kvkvasdmsd");
post4.Comment(",cvmakdmvdf");
post4.Comment("s,sdvskvn`");
// System.Console.WriteLine(post.GetInfo());
post4.GetComments();
foreach (var item in post4.GetComments())
{
    System.Console.WriteLine($"Title:{post4.Title}\nDescription:{post4.Description}\nNumber of Likes:{post4.LikeCount}\nPublished:{post4.IsPublished}");
    break ;
}
System.Console.WriteLine("Comments :" );
foreach (var item in post4.GetComments())
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("----------------------------");