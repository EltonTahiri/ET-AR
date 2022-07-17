using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.RequestHelpers
{
    public class PagedList<T> : List<T>
    {
        public PagedList(List<T> items,int count, int pageNumber, int pageSize)
        {
            MetaData = new MetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };
            AddRange(items);
        }

        public MetaData MetaData { get; set; }
        
        public static async Task<PagedList<T>> ToPagedList(IQueryable<T> queyr, 
        int pageNumber, int pageSize)
        {
            var count = await queyr.CountAsync();
            var items = await queyr.Skip((pageNumber -1 ) * pageSize).Take(pageSize).ToListAsync();

            return new PagedList<T>(items,count,pageNumber,pageSize);
        }


    }
}