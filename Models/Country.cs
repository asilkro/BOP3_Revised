using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_BOP3.Models
{
    public abstract class Country
    {
        #region Properties / Fields
        public int CountryId { get; set; } // INT(10), Primary Key
        public string Country1 { get; set; } // VARCHAR(50)

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } // VARCHAR(40)
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } // VARCHAR(40)
        #endregion

        #region Constructors
        // TODO: Flesh out constructors after figuring out the DATETIME
        public Country()
        {

        }

        public Country(int countryId, string country, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CountryId = countryId;
            Country1 = country;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }
        #endregion
    }
}
