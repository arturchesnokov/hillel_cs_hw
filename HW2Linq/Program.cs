using HW2Linq;

// task 1
Console.WriteLine("--- Task 1 ---");
var words = new List<string>
{
    "Apple",
    "Orange",
    "Apricot",
    "Peach"
};

words.Where(word => word.StartsWith('A'))
    .ToList()
    .ForEach(Console.WriteLine);

// task 2 
Console.WriteLine("--- Task 2 ---");
var nums1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
var nums2 = new[] { 5, 6, 7, 8, 9, 10 };

nums1.Intersect(nums2)
    .ToList()
    .ForEach(Console.WriteLine);

// task 3
Console.WriteLine("--- Task 3 ---");
var students = new List<Student>()
{
    new Student()
    {
        FirstName = "Oleh",
        LastName = "Petrenko",
        Mark = 8
    },
    new Student()
    {
        FirstName = "Dmytro",
        LastName = "Sidorenko",
        Mark = 9
    },
    new Student()
    {
        FirstName = "Hanna",
        LastName = "Ivanchenko",
        Mark = 10
    }
};

Console.WriteLine($"Student with the best mark: {students.MaxBy(student => student.Mark)}");

// task 4
Console.WriteLine("--- Task 4 ---");

var products = new List<Product>()
{
    new Product()
    {
        Name = "Milk",
        Category = "Food",
        Price = 8.0
    },
    new Product()
    {
        Name = "Cheese",
        Category = "Food",
        Price = 18.5
    },
    new Product()
    {
        Name = "Cream",
        Category = "Food",
        Price = 15.4
    },
    new Product()
    {
        Name = "Soap",
        Category = "Home Goods",
        Price = 2.6
    },
    new Product()
    {
        Name = "Dishwasher liquid",
        Category = "Home Goods",
        Price = 4.0
    },
    new Product()
    {
        Name = "Sponge",
        Category = "Home Goods",
        Price = 0.5
    }
};

products.GroupBy(
        product => product.Category,
        product => product.Price,
        (key, val) => new { Category = key, Prices = val.ToList().Average() })
    .ToList()
    .ForEach(Console.WriteLine);

// task 5
Console.WriteLine("--- Task 5 ---");
var employees = new List<Employee>()
{
    new Employee()
    {
        FirstName = "John",
        LastName = "Peterson",
        BirthDate = new DateOnly(1990, 1, 22),
        EmploymentDate = new DateOnly(2020, 1, 10)
    },
    new Employee()
    {
        FirstName = "Peter",
        LastName = "Parker",
        BirthDate = new DateOnly(1995, 5, 12),
        EmploymentDate = new DateOnly(2021, 1, 10)
    },
    new Employee()
    {
        FirstName = "Kanye",
        LastName = "West",
        BirthDate = new DateOnly(1977, 6, 9),
        EmploymentDate = new DateOnly(2000, 1, 1)
    },
};

var nowDate = DateOnly.FromDateTime(DateTime.Now);
employees.Where(employee => ((nowDate.DayNumber - employee.EmploymentDate.DayNumber) > 365 * 5))
    .ToList()
    .ForEach(Console.WriteLine);

// task 6
Console.WriteLine("--- Task 6 ---");

var books = new List<Book>()
{
    new Book()
    {
        Name = "Dune",
        Author = "Frank Herbert",
        Genre = "Science fiction",
        PublishingYear = 1965
    },
    new Book()
    {
        Name = "The Martian",
        Author = "Andy Weir",
        Genre = "Science fiction",
        PublishingYear = 2011
    },
    new Book()
    {
        Name = "Ready Player One",
        Author = "Ernest Cline",
        Genre = "Science fiction",
        PublishingYear = 2011
    },
    new Book()
    {
        Name = "Insurgent",
        Author = "Veronica Roth",
        Genre = "Fantasy",
        PublishingYear = 2012
    }
};

books.Where(book => book.PublishingYear > 2010 && book.Genre.Equals("Science fiction"))
    .ToList()
    .ForEach(Console.WriteLine);

// task 7
Console.WriteLine("--- Task 7 ---");

var customers = new List<Customer>()
{
    new Customer()
    {
        FirstName = "Veronica",
        LastName = "Roth",
        Adress = "Jefferson ave. 12 app. 2",
        Order = 1010.5
    },
    new Customer()
    {
        FirstName = "Ernest",
        LastName = "Cline",
        Adress = "McCale ave. 112 app. 21",
        Order = 2340.0
    },
    new Customer()
    {
        FirstName = "Andy",
        LastName = "Weir",
        Adress = "Adventurers str. 404 app. 0",
        Order = 140.0
    }
};

customers.Where(customer => customer.Order > 1000)
    .ToList()
    .ForEach(Console.WriteLine);