using sampleapp.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sampleapp.Models
{
    public class Class1
    {
        public static SelectList GetProductNamesList()
        {
            using (var dbObj = new RutulTrailEntities1())
            {
                var result = dbObj.Product_table.ToList();

                result = result.OrderBy(m => m.Product_Name).ToList();
                List<SelectListItem> sl = result.ConvertAll(a =>
                {
                    return new SelectListItem()
                    {
                        Text = a.Product_Name,
                        Value = a.ID.ToString()
                    };
                });
                return new SelectList(sl, "Value", "text");
            }
        }

        public static SelectList GetProductBrandList()
        {
            using (var dbObj = new RutulTrailEntities1())
            {
                var result = dbObj.Product_table.ToList();

                result = result.OrderBy(m => m.Brand).ToList();
                List<SelectListItem> sl = result.ConvertAll(a =>
                {
                    return new SelectListItem()
                    {
                        Text = a.Brand,
                        Value = a.Brand
                    };
                });
                return new SelectList(sl, "Value", "text");
            }
        }

        public static SelectList GetProductTypeList()
        {
            using (var dbObj = new RutulTrailEntities1())
            {
                var result = dbObj.Product_table.ToList();
                result = result.OrderBy(m => m.Product_Type).ToList();

               List<SelectListItem> sl = result.ConvertAll(m =>
               {
                   return new SelectListItem()
                   {
                       Text = m.Product_Type,
                       Value = m.Product_Type
                   };
               });
            return new SelectList(sl, "Value", "Text");
            }
        }

        public static SelectList GetUserNameList()
        {
            using (var dbObj = new RutulTrailEntities1())
            {
                var result = dbObj.UserTables.ToList();

                result = result.OrderBy(m => m.UserName).ToList();
                List<SelectListItem> sl = result.ConvertAll(a =>
                {
                    return new SelectListItem()
                    {
                        Text = a.UserName,
                        Value = a.ID.ToString()
                    };
                });
                return new SelectList(sl, "Value", "text");
            }
        }
    }
}