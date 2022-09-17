using SiteWithMySkills.Domain.Entities;
using SiteWithMySkills.Domain.Repositories.Abstract;
namespace SiteWithMySkills.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemRepository ServiceItems { get; set; }
        public ITovarsItemsRepository TovarsItems { get; set; }
        public IDataRepository DataItems { get; set; }
        public DataManager(ITextFieldsRepository txtRepos,IServiceItemRepository srRepos,ITovarsItemsRepository tvRepos,
            IDataRepository dtRepos)
        {
            TovarsItems = tvRepos; 
            TextFields = txtRepos;
            ServiceItems = srRepos;
            DataItems = dtRepos;
            
        }
    }
}
