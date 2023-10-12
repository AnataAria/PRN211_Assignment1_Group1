using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class CartoonType
    {
        public CartoonType()
        {
            Cartoons = new HashSet<Cartoon>();
        }

        public int CartoonTypeId { get; set; }
        public string CartoonName { get; set; }

        public virtual ICollection<Cartoon> Cartoons { get; set; }
    }
}
