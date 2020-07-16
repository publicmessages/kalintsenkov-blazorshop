﻿namespace BlazorShop.Models.Categories
{
    using System.ComponentModel.DataAnnotations;

    using static ErrorMessages;
    using static Data.ModelConstants.Common;

    public class CategoryRequestModel
    {
        [Required]
        [StringLength(
            MaxNameLength, 
            ErrorMessage = StringLengthErrorMessage, 
            MinimumLength = MinNameLength)]
        public string Name { get; set; }
    }
}