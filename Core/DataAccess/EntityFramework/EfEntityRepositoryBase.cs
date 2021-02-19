
using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DatAccess.EntityFramework
{
    public class EfEntityRepositoryBase<VEntity, VContext> : IEntityRepository<VEntity>
        where VEntity: class, IEntity, new()
        where VContext: DbContext,new()
    {
        public void Add(VEntity entity)
        {
            using (VContext context = new VContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(VEntity entity)
        {
            using (VContext context = new VContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public VEntity Get(Expression<Func<VEntity, bool>> filter)
        {
            using (VContext context = new VContext())
            {
                return context.Set<VEntity>().SingleOrDefault(filter);
            }
        }

        public List<VEntity> GetAll(Expression<Func<VEntity, bool>> filter = null)
        {
            using (VContext context = new VContext())
            {
                return filter == null
                    ? context.Set<VEntity>().ToList()
                    : context.Set<VEntity>().Where(filter).ToList();
            }
        }

        public void Update(VEntity entity)
        {
            using (VContext context = new VContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
