using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTracker.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BooksDB>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.MapGet("/", () => "Hello World!").ExcludeFromDescription();

// Fetch all books from DB
app.MapGet("/books", async (BooksDB db) =>
    await db.Books.ToListAsync()
)
    .Produces<List<Book>>(StatusCodes.Status200OK)
    .WithName("GetAllBooks").WithTags("Getters");

// Add new book to the DB
app.MapPost("/books",
    async ([FromBody] Book addbook, [FromServices] BooksDB db, HttpResponse response) =>
    {
        db.Books.Add(addbook);
        await db.SaveChangesAsync();
        response.StatusCode = 200;
        response.Headers.Location = $"books/{addbook.BookID}";
    })
    .Accepts<Book>("application/json")
    .Produces<Book>(StatusCodes.Status201Created)
    .WithName("AddNewBook").WithTags("Setters");

// Update an existing book title using ID
app.MapPut("/books",
    [AllowAnonymous] async (int bookID, string bookTitle, [FromServices] BooksDB db, HttpResponse response) =>
    {
        var mybook = db.Books.SingleOrDefault(s => s.BookID == bookID);
        if (mybook == null) return Results.NotFound();
        mybook.Title = bookTitle;
        await db.SaveChangesAsync();
        return Results.Created("/books", mybook);
    })
    .Produces<Book>(StatusCodes.Status201Created).Produces(StatusCodes.Status404NotFound)
    .WithName("UpdateBook").WithTags("Setters");

// Fetch a single book from DB
app.MapGet("/books/{id}", async (BooksDB db, int id) =>
    await db.Books.SingleOrDefaultAsync(s => s.BookID == id) is Book mybook ? Results.Ok(mybook) : Results.NotFound()
)
    .Produces<Book>(StatusCodes.Status200OK)
    .WithName("GetBookbyID").WithTags("Getters");

// Perform a search for a given keyword
app.MapGet("/books/search/{query}", (string query, BooksDB db) =>
    {
        var _selectedBooks = db.Books.Where(x => x.Title.ToLower().Contains(query.ToLower())).ToList();
        return _selectedBooks.Count > 0 ? Results.Ok(_selectedBooks) : Results.NotFound(Array.Empty<Book>());
    })
    .Produces<List<Book>>(StatusCodes.Status200OK)
    .WithName("Search").WithTags("Getters");


// Get Paginated Result set
//TODO: >>>

app.UseSwagger();
app.UseSwaggerUI();

app.Run();  // OR   app.Run(“http://localhost:3000");


//TODO: ++ Fluent (Model) Validation
//TODO: ++ Service(s) & Dependency Injection
//TODO: °° Quid Exception handling & logging ??