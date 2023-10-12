using BusinessObjects;
using EnvDTE100;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    internal class CartoonDAO
    {

        public static List<Cartoon> GetCartoons()
        {
            List<Cartoon> listCartoons = new List<Cartoon>();
            try
            {
                using (var context = new CarroonManagmentContext())
                {
                    listCartoons = context.Cartoons.Include(f => f.CartoonType).ToList();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return listCartoons;
        }

        public static Cartoon GetCartoonById(decimal id)
        {
            return new Cartoon();
        }

        public static void SaveCartoon(Cartoon cartoon)
        {

        }
        public static void DeleteCartoon(Cartoon cartoon)
        {

        }

        public static void UpdateCartoon(Cartoon cartoon)
        {

        }
    }
}
