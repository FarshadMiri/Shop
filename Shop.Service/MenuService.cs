using Shop.Core;
using Shop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service
{
    public class MenuService : IMenuService
    {
        private IRepository<Menu> _repository { get; }
        public MenuService(IRepository<Menu> repository)
        {
            _repository = repository;

        }
        public void Create(Menu entity)
        {
            _repository.Create(entity);
        }
        public void Update(Menu entity)
        {
            _repository.Update(entity);
        }
        public void Delete(Menu entity)
        {
            _repository.Delete(entity);
        }
        public List<Menu> List()
        {
            return _repository.List();
        }
        public Menu Find(int id)
        {
            return List().FirstOrDefault(x => x.Id == id);
        }
        public List<Menu> Search(string search)
        {
            List<Menu> list = List();
            return list
                .Where(x => x.Title.Contains(search) || x.Link.Contains(search))
                .ToList();



        }
        public List<Menu> Sort(bool des, string colName)
        {
            List<Menu> list = List();
            switch (colName)
            {
                case "id":
                    return des ?
                            list.OrderByDescending(x => x.Id).ToList() :
                            list;
                case "title":
                    return des ?
                        list.OrderByDescending(x => x.Title).ToList() :
                        list.OrderBy(x => x.Title).ToList();


                default:

                    return list;
            }
        }


    }
}
