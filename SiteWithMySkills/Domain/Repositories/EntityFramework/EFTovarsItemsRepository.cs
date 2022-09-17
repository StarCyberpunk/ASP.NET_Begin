using SiteWithMySkills.Domain.Entities;
using SiteWithMySkills.Domain.Repositories.Abstract;

namespace SiteWithMySkills.Domain.Repositories.EntityFramework
{
    public class EFTovarsItemsRepository : ITovarsItemsRepository
    {
        private readonly AppDbContext context;
        public EFTovarsItemsRepository(AppDbContext context)
        {
            this.context = context;
        }
        public void DeleteTovarItem(Guid id)
        {
            var itme = context.TovarsItems.Where(p => p.id == id).First();
            if (itme != null)
            {
                context.TovarsItems.Remove(itme);
            }
            else
            {
                throw new Exception();
            }
            context.SaveChanges();
        }

        public void EditTovarItem(Tovar tov)
        {
            var itme = context.TovarsItems.Where(p => p.id == tov.id).First();
             context.TovarsItems.Remove(itme);
            context.TovarsItems.Add(tov);
            
            context.SaveChanges();
        }

        public Tovar GetTovarItemById(Guid id)
        {
           var res=  context.TovarsItems.Where(t => t.id == id).FirstOrDefault();
            if (res != null)
            {
                return res;
            }
            else
            {
                throw new Exception();
            }
            
        }

        public List<Tovar> GetTovarsItems()
        {

            return context.TovarsItems.ToList() ;
        }
        public List<Tovar> GetTovarsItems(int count)
        {

            return context.TovarsItems.Take(count).ToList();
        }

        public void SaveTovarItem(Tovar entity)
        {
            context.TovarsItems.Add(entity);
            context.SaveChanges();
        }
        

       
    }
}
