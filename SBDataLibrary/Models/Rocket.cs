﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace SBDataLibrary.Models
{
    [System.Serializable]
    public class Rocket
    {
        public int Id { get; set; }
        [Required]
        public int LaunchId { get; set; }
        [Required]
        public string RocketId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Type { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        public int Mass { get; set; }
        public byte[] Image { get; set; }

        public Rocket(string rocketId, string name, string type, string country, int mass, byte[] image)
        {
            this.RocketId = rocketId;
            this.Name = name;
            this.Type = type;
            this.Country = country;
            this.Mass = mass;
            this.Image = image;
        }
    }
}