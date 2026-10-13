using PostService.DataAccess;
using PostService.Models;
namespace PostService.App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var repository = new GenericRepository<ContactPerson>();
            var person = new ContactPerson
            {
                Id = 1,
                Name = "Науменко Алла",
                PhoneNumber = "+380980034709",
                Email = "stoianovaallaua@gmail.com"
            };
            repository.Add(person);

            var savedPerson = repository.GetById(1);

            if (savedPerson != null)
            {
                savedPerson.Name = "Стоянова Алла";
                repository.Update(savedPerson);
            }
            var allPersons = repository.GetAll();
            repository.Delete(1);

            TestRunner.RunTests();
            ApplicationConfiguration.Initialize();
            Application.Run(new PostingList());
        }
    }
}