using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Rest;

using AlintaTestEvgeny.RESTful;
using System.Configuration;

namespace AlintaTestEvgeny.Models.Movie
{
    public class MovieCharacter
    {
        public string CharacterName { get; set; }
        public string ActorName { get; set; }
        public string MovieName { get; set; }

        internal static List<MovieCharacterByActor> GetList()
        {
            var credentials = new BasicAuthenticationCredentials();
            var uri = new Uri(ConfigurationManager.AppSettings["MoviesService.BaseURL"]);
            var restClient = new RESTfulClient(uri, credentials);
            var list = restClient.ApiMoviesGet().SelectMany(m => m.Roles, (m, r) => new MovieCharacter
            {
                MovieName = m.Name,
                ActorName = r.Actor,
                CharacterName = r.Name
            }).
            GroupBy(r => r.ActorName).
            Select(group => new MovieCharacterByActor {
                ActorName = group.Key,
                CharacterList = group.OrderBy(c => c.MovieName).ToList()
            }).
            OrderBy(r => r.ActorName).ToList();

            return list;
        }
    }
}