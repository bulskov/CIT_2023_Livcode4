

using EF;

var db = new NorthwindContex();

foreach (var category in db.Categories.Where(x => x.Id > 5))
{
    Console.WriteLine(category);
}