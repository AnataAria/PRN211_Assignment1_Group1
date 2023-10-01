using BusinessObjects;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public interface ICartoonRepository
    {
        IEnumerable<Cartoon> GetCartoons();
        Cartoon AddCartoon(Cartoon cartoon);
        Cartoon UpdateCartoon(Cartoon cartoon);

    }
}