using System;
using System.Collections.Generic;

namespace BusinessObjects
{
    public partial class Cartoon
    {
        public decimal CartoonId { get; set; }
        public string CartoonName { get; set; }
        public DateTime LaunchDate { get; set; }
        public int CartoonType { get; set; }
        public string ShortDescription { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string Country { get; set; }

        public virtual CartoonType CartoonTypeNavigation { get; set; }
    }
}
