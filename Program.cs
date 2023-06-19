using Library;
using Library.Repository.Interfaces;
using Library.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddSwaggerGen();
var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddTransient<IPublication, PublicationRepository>();
builder.Services.AddTransient<IBook, BookRepository>();
builder.Services.AddTransient<IStudents, StudentRepository>();
builder.Services.AddTransient<IDepartment, DepartmentRepository>();
builder.Services.AddTransient<IissueBook, IssueBookRepository>();
//Permission
builder.Services.AddTransient<IPermission, PermissionRepository>();
builder.Services.AddTransient<IUserRole, UserRoleRepository>();
builder.Services.AddTransient<IRoleAssignment, RoleAssignmentRepository>();
builder.Services.AddDbContext<LibraryContext>(item => item.UseSqlServer(configuration.GetConnectionString("LibraryProject")));
var app = builder.Build();

//Configure the HTTP request pipeline.
if(!app.Environment.IsDevelopment())
    {
    app.UseExceptionHandler("/Home/Error");
    }
app.UseStaticFiles();

app.UseRouting();
app.UseSwagger();
app.UseSwaggerUI(o =>
{
    o.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    
});
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
