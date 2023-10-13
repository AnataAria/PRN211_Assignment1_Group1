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
    public class CartoonDAO
    {

        public static List<Cartoon> GetCartoons()
        {
            List<Cartoon> listCartoons = new List<Cartoon>();
            try
            {
                using (var context = new CarroonManagmentContext())
                {
                    listCartoons = context.Cartoons.Include(f => f.CartoonTypeNavigation).ToList();
                }
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return listCartoons;
        }

        public static Cartoon GetCartoonById(decimal id)
        {
            Cartoon data;
            try
            {
                using (var context = new CarroonManagmentContext())
                {
                    data = context.Cartoons.Include(i => i.CartoonTypeNavigation).FirstOrDefault(x => x.CartoonId.Equals(id));
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return data;
            
        }

        public static void SaveCartoon(Cartoon cartoon)
        {
            try
            {
                using (var context = new CarroonManagmentContext())
                {
                    context.Cartoons.Add(cartoon);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteCartoon(Cartoon cartoon)
        {
            try
            {
                using (var context = new CarroonManagmentContext())
                {
                    context.Cartoons.Remove(cartoon);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateCartoon(Cartoon cartoon)
        {
            try
            {
                using (var context = new CarroonManagmentContext())
                {
                    var a = context.Cartoons.Find(cartoon.CartoonId);
                    if(a != null)
                    {
                        a.Clone(cartoon);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
