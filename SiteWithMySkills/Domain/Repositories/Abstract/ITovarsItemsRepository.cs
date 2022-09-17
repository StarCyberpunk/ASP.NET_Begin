using SiteWithMySkills.Domain.Entities;

namespace SiteWithMySkills.Domain.Repositories.Abstract
{
    public interface ITovarsItemsRepository
    {
        List<Tovar> GetTovarsItems();
        List<Tovar> GetTovarsItems(int count);
        Tovar GetTovarItemById(Guid id);
        void SaveTovarItem(Tovar entity);
        void EditTovarItem(Tovar tov);
        void DeleteTovarItem(Guid id);
    }
}
