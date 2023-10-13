using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;
namespace Repositories
{
    public class CartoonRepository : ICartoonRepository
    {
        public void DeleteCartoon(Cartoon p)
        {
            CartoonDAO.DeleteCartoon(p);
        }

        public Cartoon GetCartoonById(int id)
        {
            return CartoonDAO.GetCartoonById(id);
        }

        public List<Cartoon> GetCartoons()
        {
            return CartoonDAO.GetCartoons();
        }

        public List<CartoonType> GetCartoonTypes()
        {
            return CourseTypeDAO.GetCartoonTypes();
        }

        public void SaveCartoon(Cartoon p)
        {
            
            CartoonDAO.SaveCartoon(p);
        }

        public void UpdateCartoon(Cartoon p)
        {
            CartoonDAO.UpdateCartoon(p);
        }
    }
}
