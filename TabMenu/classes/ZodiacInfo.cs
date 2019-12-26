using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabMenu.classes
{
    [Table ("ZodiacInfo")]
   public class ZodiacInfo
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }



    }
}
