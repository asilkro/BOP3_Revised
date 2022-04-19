using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_BOP3.Models
{
    public abstract class Address
    {
        #region Properties / Fields
        public int AddressId { get; set; } // INT(10), Primary Key
        public string Address1 { get; set; } // VARCHAR(50)
        public string Address2 { get; set; } // VARCHAR(50)
        public int CityId { get; set; } // INT(10), Foreign Key (City)
        public string PostalCode { get; set; } // VARCHAR(10)
        public string Phone { get; set; } // VARCHAR(20)

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } // VARCHAR(40)
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } // VARCHAR(40)
        #endregion

        #region Constructors

        public Address()
        {

        }
        public Address(int addressId, string address1, string address2, int cityId, string postalCode, string phone, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AddressId = addressId;
            Address1 = address1;
            Address2 = address2;
            CityId = cityId;
            PostalCode = postalCode;
            Phone = phone;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        #endregion
    }
}
