using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Rest;

using AlintaTestEvgeny.RESTful;
using System.Configuration;

namespace AlintaTestEvgeny.Models.Movie
{
    public class MovieCharacterByActor
    {
        private string actorName;
        public string ActorName {
            get
            {
                return string.IsNullOrWhiteSpace(actorName) ? "[blank]" : actorName;
            }
            set
            {
                actorName = value;
            }
        }
        public List<MovieCharacter> CharacterList { get; set; }
    }
}