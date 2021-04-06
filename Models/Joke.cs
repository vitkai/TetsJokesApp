using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TetsJokesApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }

        public Joke()
        {

        }
    }
}
