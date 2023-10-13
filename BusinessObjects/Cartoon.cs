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
        public string Producer { get; set; }

        public virtual CartoonType CartoonTypeNavigation { get; set; }

        public Cartoon(decimal cartoonId, string cartoonName, DateTime launchDate, int cartoonType, string shortDescription, string actors, string director, string country, string producer)
        {
            CartoonId = cartoonId;
            CartoonName = cartoonName;
            LaunchDate = launchDate;
            CartoonType = cartoonType;
            ShortDescription = shortDescription;
            Actors = actors;
            Director = director;
            Country = country;
            Producer = producer;
        }
        public Cartoon(string cartoonName, DateTime launchDate, int cartoonType, string shortDescription, string actors, string director, string country, string producer)
        {
            CartoonName = cartoonName;
            LaunchDate = launchDate;
            CartoonType = cartoonType;
            ShortDescription = shortDescription;
            Actors = actors;
            Director = director;
            Country = country;
            Producer = producer;
        }

        public void Clone(Cartoon data)
        {
            CartoonName = data.CartoonName;
            LaunchDate = data.LaunchDate;
            CartoonType = data.CartoonType;
            ShortDescription = data.ShortDescription;
            Actors = data.Actors;
            Director = data.Director;
            Country = data.Country;
            Producer = data.Producer;
        }
    }
}
