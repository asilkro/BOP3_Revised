using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_BOP3.Models
{
    public class User // user == consultant per FAQ
    {
        #region Properties / Fields
        // All these are from the Database ERD
        public int UserId { get; set; } // INT, Primary Key
        public string UserName { get; set; } // VARCHAR(50) //TODO: should these be private
        public SecureString Password { get; protected set; } // VARCHAR(50) //TODO: should these be private
        // Not sure this will be used but can come back to it.
        private byte Active { get; set; } // TINYINT in MySQL is just a byte
        // Found on https://www.tutorialspoint.com/What-is-the-Chash-Equivalent-of-SQL-Server-DataTypes

        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } // VARCHAR(40)
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } // VARCHAR(40)

        #endregion

        #region Constructors

        public User()
        {

        }

        public User(int userId, string userName, SecureString password, byte active, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;

        }
        #endregion
    }
}
