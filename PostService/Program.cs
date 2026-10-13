using PostService.BusinessLogic;
using PostService.DataAccess;
using PostService.Dtos;
using PostService.Mappings;
using PostService.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});
builder.Services.AddScoped<IPostingRepository, PostingRepository>();
builder.Services.AddScoped<IPostingService, PostingService>();
builder.Services.AddScoped<IRepository<ContactPerson>, GenericRepository<ContactPerson>>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var repository = scope.ServiceProvider.GetRequiredService<IPostingRepository>();
    repository.CreateDb();
}
app.UseCors(policy => policy
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapGet("/postings", (IPostingService postingService) =>
{
    var postings = postingService.GetAll();
    var dtos = postings.Select(p => PostingMapper.ToPostingGetDto(p));
    return Results.Ok(dtos);
});

app.MapGet("/postings/{id}", (int id, IPostingService postingService) =>
{
    var posting = postingService.Find(id);
    if (posting == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(PostingMapper.ToPostingGetDto(posting));
});

app.MapPost("/postings", (PostingPostDto postDto, IPostingService postingService) =>
{
    Posting newPosting = PostingMapper.ToPosting(postDto);
    Posting savedPosting = postingService.Create(newPosting);
    PostingGetDto resultDto = PostingMapper.ToPostingGetDto(savedPosting);

    return Results.Created($"/postings/{resultDto.Id}", resultDto);
});

app.MapPut("/postings/{id}", (int id, PostingPutDto putDto, IPostingService postingService) =>
{
    if (id != putDto.Id)
    {
        return Results.BadRequest();
    }

    Posting postingToUpdate = PostingMapper.ToPosting(putDto);
    Posting? updatedPosting = postingService.Update(postingToUpdate);

    if (updatedPosting == null)
    {
        return Results.NotFound();
    }

    return Results.Ok(PostingMapper.ToPostingGetDto(updatedPosting));
});

app.MapDelete("/postings/{id}", (int id, IPostingService postingService) =>
{
    int deletedCount = postingService.Delete(id);
    if (deletedCount == 0)
    {
        return Results.NotFound();
    }

    return Results.NoContent();
});
app.MapGet("/contacts", (IRepository<ContactPerson> contactRepo) =>
{
    var contacts = contactRepo.GetAll();
    return Results.Ok(contacts);
});

app.MapPost("/contacts", (ContactPerson person, IRepository<ContactPerson> contactRepo) =>
{
    contactRepo.Add(person);
    return Results.Created($"/contacts/{person.Id}", person);
});
app.Run();