using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using EFMaraton.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFMaraton.BLL.Manager.Abstract
{
    public abstract class Manager<TModel, TEntity> : IManager<TModel> where TModel : class
    {
        private IMapper _mapper;
        protected IRepository<TEntity> _repository;

        public Manager()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.CreateMap<TModel, TEntity>().ReverseMap();
            });

            _mapper = new Mapper(config);
        }

        public void Add(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Insert(entity);
        }

        public void Delete(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Delete(entity);
        }

        public List<TModel> GetAll()
        {
            List<TEntity> entities = _repository.GetAll().ToList();

            List<TModel> models = new List<TModel>();

            foreach (TEntity entity in entities)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }

            return models;
        }

        public TModel GetById(int id)
        {
            TEntity entity = _repository.GetById(id);

            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }

        public TModel GetDeletedById(int id)
        {
            TEntity entity = _repository.GetDeletedById(id);

            TModel model = _mapper.Map<TModel>(entity);

            return model;
        }

        public void Update(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Update(entity);
        }
        public void UpdateDeletedValues(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.UpdateDeletedValues(entity);
        }


        public void Remove(TModel model)
        {
            TEntity entity = _mapper.Map<TEntity>(model);

            _repository.Remove(entity);
        }

        public List<TModel> Search(Expression<Func<TModel, bool>> predicate)
        {
            Expression<Func<TEntity, bool>> predicateEntity = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            List<TEntity> entities = _repository.Search(predicateEntity).ToList();
            //List<TModel> models = _mapper.Map<List<TModel>>(entities);
            List<TModel> models = new List<TModel>();

            foreach (TEntity entity in entities)
            {
                TModel model = _mapper.Map<TModel>(entity);
                models.Add(model);
            }

            return models;
        }


    }
}
