using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeLayer;
using FacadeLayer.Dal;

namespace BusinessLogicLayer.BL
{
    public class BLCategory
    {
        public static List<EntityCategory> BLCategoryList()
        {
            //yetkisi var mı
            return DALCategory.CategoryList();
        }
        public void BLCategoryAdd(EntityCategory entityCategory)
        {
            if (entityCategory.Categoryname != "" && entityCategory.Categoryname.Length <= 30 && entityCategory.Categoryname.Length >= 5)
            {
                DALCategory.AddCategory(entityCategory);
            }
            else
            {
                //hata
            }
        }
        public void BLCategoryDelete(int id)
        {
            if (id != 0)
            {
                DALCategory.DeleteCategory(id);
            }
            else
            {
                //hata mesajı
            }
        }
        public void BLCategoryUpdate(EntityCategory entityCategory)
        {
            if(entityCategory.Categoryname!="" && entityCategory.Categoryname.Length >= 5)
            {
                DALCategory.UpdateCategory(entityCategory);
            }
        }
    }
}
