using PostService.CommonTypes;
using PostService.DataAccess;
using PostService.Models;

namespace PostService.BusinessLogic;
public class PostingService : IPostingService
{
    private readonly IPostingRepository _repository;
    public PostingService(IPostingRepository repository)
    {
        _repository = repository;
    }
    public Posting Create(Posting newPosting)
    {
        newPosting.CreatedAt = DateTime.UtcNow;

        float baseRate = 30f;
        if (newPosting.DeliveryType == DeliveryType.ExpressCourier)
        {
            baseRate = 60f;
        }
        newPosting.Price = baseRate + (newPosting.Weight * 10f);

        var postingId = _repository.Create(newPosting);
        newPosting.Id = postingId;
        return newPosting;
    }
    public List<Posting> GetAll()
    {
        return _repository.GetList();
    }
    public Posting? Find(int postingId)
    {
        return _repository.GetById(postingId);
    }
    public Posting? Update(Posting posting)
    {
        var existing = _repository.GetById(posting.Id);
        if (existing == null)
        {
            return null;
        }

        float baseRate = 30f;
        if (posting.DeliveryType == DeliveryType.ExpressCourier)
        {
            baseRate = 60f;
        }
        posting.Price = baseRate + (posting.Weight * 10f);

        _repository.Update(posting);
        return posting;
    }
    public int Delete(int postingId)
    {
        return _repository.Delete(postingId);
    }
}