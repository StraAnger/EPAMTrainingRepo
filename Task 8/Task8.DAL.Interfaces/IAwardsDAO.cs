using Task8.Entities;

namespace Task8.DAL.Interfaces
{
    public interface IAwardsDAO
    {
        Award AddAward(string title);

        void RemoveAward(Guid id);

        void EditAward(Guid id, string newTitle);

        Award GetAward(Guid id);

        IEnumerable<Award> GetAwards(bool orderedById);

    }
}