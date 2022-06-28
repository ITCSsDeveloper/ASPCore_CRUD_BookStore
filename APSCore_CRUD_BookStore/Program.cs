using APSCore_CRUD_BookStore.Model;
using APSCore_CRUD_BookStore.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/v1/books", (string? search) =>
{
    return Results.Ok(BookService.GetBooks(search));
});

app.MapGet("api/v1/books/{id}", (int id) =>
{
    var book = BookService.GetBookById(id: id);
    if(book != null)
    {
        return Results.Ok(book);
    }
    else
    {
        return Results.NotFound();
    }
});

app.MapPost("api/v1/books", (BookModel book) =>
{
    if (BookService.CreateBook(book : book))
    {
        return Results.Created("","Create new Book complete.");
    }
    else
    {
        return Results.BadRequest("Can't Create new Book. Please Re Check Data Input.");
    }
});

app.MapPut("api/v1/books/{id}", (int id, BookModel book) =>
{
    if (BookService.UpdateBook(book))
    {
        return Results.Ok("Update Book Complete.");
    }
    else
    {
        return Results.BadRequest("Can't Update new Book. Please Re Check Data Input.");
    }
});


app.MapDelete("api/b1/books/{id}", (int id) =>
{
    if (BookService.DeleteBook(id : id))
    {
        return Results.Ok("Delete Book Complete.");
    }
    else
    {
        return Results.BadRequest("Can't Delete new Book. Please Re Check Data Input.");
    }
});



app.Run();