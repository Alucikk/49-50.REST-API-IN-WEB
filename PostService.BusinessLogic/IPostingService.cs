using PostService.Models;
namespace PostService.BusinessLogic;
public interface IPostingService
{
    Posting Create(Posting newPosting);
    List<Posting> GetAll();
    Posting? Find(int postingId);
    Posting? Update(Posting posting);
    int Delete(int postingId);
}