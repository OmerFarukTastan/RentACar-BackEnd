﻿using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, RentACarContext>, IColorDal
    {
        //public void Add(Color item)
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var addedColor = context.Entry(item);
        //        addedColor.State = EntityState.Added;
        //        context.SaveChanges();
        //    }
        //}

        //public void DeleteByEntity(Color item)
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var deletedColor = context.Entry(item);
        //        deletedColor.State = EntityState.Deleted;
        //        context.SaveChanges();
        //    }
        //}

        //public Color Get(System.Linq.Expressions.Expression<Func<Color, bool>> filter)
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        return context.Set<Color>().SingleOrDefault(filter);
        //    }
        //}

        //public List<Color> GetAll(System.Linq.Expressions.Expression<Func<Color, bool>> filter = null)
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        return filter == null ?
        //            context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
        //    }
        //}

        //public void Update(Color item)
        //{
        //    using (RentACarContext context = new RentACarContext())
        //    {
        //        var updatedColor = context.Entry(item);
        //        updatedColor.State = EntityState.Modified;
        //        context.SaveChanges();
        //    }
        //}
    }
}
