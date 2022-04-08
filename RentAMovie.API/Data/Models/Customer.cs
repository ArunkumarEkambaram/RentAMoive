using System;

namespace RentAMovie.API.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }

        //Auditable Column
        public DateTime AddedDate{ get; set; }
        public DateTime? ModifiedDate{ get; set; }
    }
}
