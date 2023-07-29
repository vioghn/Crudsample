using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace EFcodefirstApp.Models
{
    public class users
    {
        [Key]
        public int ID { get; set; }
        public String Name { get; set; }

        public String ContactNo { get; set; }


    }
}
