using PostService.CommonTypes;
using PostService.DataAccess;
using PostService.Models;

namespace PostService.App;
public static class TestRunner
{
    public static void RunTests()
    {
        var postingRepository = new GenericRepository<Posting>();

        postingRepository.Add(new Posting
        {
            Id = 1,
            From = "Луцьк",
            To = "Стрий",
            Content = "Ноутбуки",
            DeliveryType = DeliveryType.Department,
            Weight = 5.5f,
            Price = 50000.0f,
            CreatedAt = DateTime.Now
        });

        postingRepository.Add(new Posting
        {
            Id = 2,
            From = "Рiвне",
            To = "Житомир",
            Content = "Книги",
            DeliveryType = DeliveryType.Courier,
            Weight = 1.5f,
            Price = 700.0f,
            CreatedAt = DateTime.Now
        });
        var posting = postingRepository.GetById(1);
        if (posting != null)
        {
            posting.To = "Трускавець";
            postingRepository.Update(posting);
        }
        postingRepository.Delete(2);
        var allPostings = postingRepository.GetAll();

        var contactRepository = new GenericRepository<ContactPerson>();

        int countContacts = contactRepository.GetAll().Count();
        int countPostings = allPostings.Count();
    }

}