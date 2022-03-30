using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        { Notifications = new List<Notifies>(); }

        [NotMapped]
        public String NameProperty { get; set; }

        [NotMapped]
        public String Message { get; set; }

        [NotMapped]
        public List<Notifies> Notifications;

        public bool ValidatePropertyString(string value, String nameProperty)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Value must be greater than 0.",
                    NameProperty = nameProperty
                });
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidatePropertyString(int value, String nameProperty)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Value must be greater than 0.",
                    NameProperty = nameProperty
                });
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidatePropertyString(decimal value, String nameProperty)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Value must be greater than 0",
                    NameProperty = nameProperty
                });
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
