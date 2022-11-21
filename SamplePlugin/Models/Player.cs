using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFSpeedDate.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public Gender Gender { get; set; }
        public List<Gender> Preferences { get; set; }
    }
}
