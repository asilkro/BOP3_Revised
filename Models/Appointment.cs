using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silkroski_BOP3.Models
{
    public abstract class Appointment
    {
        #region Properties / Fields
        public int AppointmentId { get; set; } // INT(10), Primary Key
        public int CustomerId { get; set; } // INT(10), Foreign Key (Customer)
        public int UserId { get; set; } // INT from User.cs, Foreign Key (User)
        public string Title { get; set; } // VARCHAR(255)
        public string Description { get; set; } // TEXT
        public string Location { get; set; } // TEXT
        public string Contact { get; set; } // TEXT
        public string Type { get; set; } // TEXT
        public string Url { get; set; } // VARCHAR(255)
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        //These need to be in every class based on ERD
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } // VARCHAR(40)      
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; } // VARCHAR(40)   
        #endregion

        #region Constructors
        public Appointment()
        {

        }
        
        public Appointment(int appointmentId, int customerId, int userId, string title, string description,
        string location, string contact, string type, string url, DateTime createDate, string createdBy, DateTime lastUpdate, string lastUpdateBy)
        {
            AppointmentId = appointmentId;
            CustomerId = customerId;
            UserId = userId;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Url = url;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = lastUpdateBy;
        }

        #endregion
    }
}
