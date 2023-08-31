using Shop.Domain;
using System.Collections.Generic;

namespace Shop.Service
{
    public interface IMenuService
    {
        void Create(Menu entity);
        void Delete(Menu entity);
        Menu Find(int id);
        List<Menu> List();
        List<Menu> Search(string search);
        List<Menu> Sort(bool des, string colName);
        void Update(Menu entity);
    }
}