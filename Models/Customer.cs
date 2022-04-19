using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_BOP3.Models
{
    public abstract class Customer
    {
        #region Properties / Fields
        // All these are from the Database ERD
        public int CustomerId { get; set; } // INT(10), Primary Key
        public string CustomerName { get; set; } // VARCHAR(45)
        public int AddressId { get; set; } // INT(10), Foreign Key (Address)
        private byte Active { get; set; } // TINYINT in MySQL is just a byte (Also in User class)
        // Found on https://www.tutorialspoint.com/What-is-the-Chash-Equivalent-of-SQL-Server-DataTypes

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } // VARCHAR(40)
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } // VARCHAR(40)

        #endregion

        #region Constructors

        public Customer()
        {

        }

        public Customer(int customerId, string customerName, int addressId, byte active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            AddressId = addressId;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        #endregion
    }
}
