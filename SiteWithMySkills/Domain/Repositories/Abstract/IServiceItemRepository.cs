using SiteWithMySkills.Domain.Entities;
namespace SiteWithMySkills.Domain.Repositories.Abstract
{
    public interface IServiceItemRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
