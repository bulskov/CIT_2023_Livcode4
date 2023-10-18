

using DataLayer;

var ds = new DataService();

ds.CreateCategory("some name", " asfsdsdfsdf");

var categories = ds.GetCategories();

foreach (var entity in categories)
{
    Console.WriteLine(entity);
}
