namespace MVCApplication.Models
{
    using MVCApplication.Validation;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(PersonMetadata))]
    public partial class Person
    {

    }

    public class PersonMetadata
    {
        [Required]
        public int Id { get; set; }

        [NameValidationRule]
        public string Name { get; set; }
    }
}
