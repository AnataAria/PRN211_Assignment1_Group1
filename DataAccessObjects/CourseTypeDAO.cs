using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CourseTypeDAO
    {
        public static List<CartoonType> GetCartoonTypes()
        {
            List<CartoonType> listCartoonType = new List<CartoonType>();
            try
            {
                using (var context = new CarroonManagmentContext())
                {
                    listCartoonType = context.CartoonTypes.ToList();
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listCartoonType; 
        }
    }
}
