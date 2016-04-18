// ------------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="">
//   
// </copyright>
// <summary>
//   The person view model.
// </summary>
// ------------------------------------------------------------------------------------------------------------------------
namespace lcsFirstSteps.Models
{
    using System;

    /// <summary>The person view model.</summary>
    public class Person
    {
        /// <summary>Gets or sets the age.</summary>
        public int Age { get; set; }

        /// <summary>Gets or sets the date of birth.</summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>Gets or sets the first name.</summary>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the last name.</summary>
        public string LastName { get; set; }
    }
}