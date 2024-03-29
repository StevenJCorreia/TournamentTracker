﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for this person.
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// The first name of this person.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The last name of this person.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The email address of this person.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The cell phone number of this person.
        /// </summary>
        public string Cellphone { get; set; }

        public string FullName
        {
            get { return $"{ FirstName } { LastName }"; }
        }

    }
}
