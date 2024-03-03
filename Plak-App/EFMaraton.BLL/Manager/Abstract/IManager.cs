using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.BLL.Manager.Abstract
{
    public interface IManager<TModel> where TModel : class
    {
        void Add(TModel model);
        void Delete(TModel model);
        void Update(TModel model);


        void UpdateDeletedValues(TModel model);

        void Remove(TModel model);

        TModel GetById(int id);

        TModel GetDeletedById(int id);
        List<TModel> GetAll();

        List<TModel> Search(Expression<Func<TModel, bool>> predicate);
    }
}
