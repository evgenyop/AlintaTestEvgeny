﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AlintaTestEvgeny.RESTful.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Role
    {
        /// <summary>
        /// Initializes a new instance of the Role class.
        /// </summary>
        public Role() { }

        /// <summary>
        /// Initializes a new instance of the Role class.
        /// </summary>
        public Role(string name = default(string), string actor = default(string))
        {
            Name = name;
            Actor = actor;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "actor")]
        public string Actor { get; set; }

    }
}
