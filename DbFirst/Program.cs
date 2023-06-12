using DbFirst.Models;

var context = new DbFirstContext();

var notes = context.Notes.ToList();

foreach(var note in notes)
{
    Console.WriteLine(note.Name);
}

//commant for connection
// Scaffold-DbContext "Server=localhost;Database=DbFirst;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force