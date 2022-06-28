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

app.MapGet("api/v1/books", () =>
{

});
app.MapGet("api/v1/books/{id}", (int id) =>
{
});
app.MapPost("api/v1/books", (APSCore_CRUD_BookStore.ViewModel.BookViewModel book) =>
{

});
app.MapPut("api/v1/books/{id}", (int id, APSCore_CRUD_BookStore.ViewModel.BookViewModel book) =>
{

});
app.MapDelete("api/b1/books/{id}", (int id) =>
{
});



app.Run();