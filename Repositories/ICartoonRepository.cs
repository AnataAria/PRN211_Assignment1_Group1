using BusinessObjects;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICartoonRepository
    {
        void SaveCartoon(Cartoon p);
        void DeleteCartoon(Cartoon p);
        void UpdateCartoon(Cartoon p);
        List<CartoonType> GetCartoonTypes();
        List<Cartoon> GetCartoons();
        Cartoon GetCartoonById(int id);
    }
}
