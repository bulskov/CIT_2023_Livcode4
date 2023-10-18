

using EF;

var db = new NorthwindContex();

//CreateCategory(db);

foreach (var entity in db.Categories)
{
    Console.WriteLine(entity);
}



static void CreateCategory(NorthwindContex db)
{
    var category = new Category
    {
        Id = 101,
        Name = "flksdflæsfj",
        Description = "dfsdfdfs"
    };

    db.Add(category);

    db.SaveChanges();
}