using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_BOP3.Models
{
    public abstract class City
    {
        #region Properties / Fields
        public int CityId { get; set; } // INT(10), Primary Key
        public string City1 { get; set; } // VARCHAR(50) // TODO: Refactor to CityName
        public int CountryId { get; set; } // INT(10), Foreign Key (Country)

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } // VARCHAR(40)
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } // VARCHAR(40)
        #endregion

        #region Constructors
        public City()
        {

        }

        public City(int cityId, string city, int countryId, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CityId = cityId;
            City1 = city;
            CountryId = countryId;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        #endregion
    }
}
