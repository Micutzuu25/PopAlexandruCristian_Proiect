using System;
using System.ComponentModel.DataAnnotations;

namespace PopAlexandru_Proiect2.Models.LibraryViewModels
{
    public class OrderGroup
    {
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        public int CarCount { get; set; }

    }
}

