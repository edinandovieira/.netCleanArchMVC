﻿using System.ComponentModel.DataAnnotations;

namespace CleanArchMVC.Application.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(3)]
        public string Name { get; set; }
    }
}