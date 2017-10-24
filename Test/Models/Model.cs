using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace Test.Models
{
    public class Model
    {
        [Required(ErrorMessage = "Please Enter Your Depart Station")]
        public   string Depart{ get; set; }
        [Required(ErrorMessage = "Please Enter Your Arrive Station")]
        public string Arrive{ get; set; }

        [Required(ErrorMessage = "Please Enter Your Depart Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DepartDate { get; set; }



        public bool oneWay { get; set; }
        public bool Ch1 { get; set; }
        public bool Ch2 { get; set; }
        public bool Ch3 { get; set; }
        public bool Ch4 { get; set; }
        public bool Ch5 { get; set; }

        public double total{ get; set; }
        public double averPrice { get; set; }
        public double averDuration { get; set; }

        [Required(ErrorMessage = "Please Enter The Number Of Passengers")]
        public int Adults { get; set; }

        public int Kids { get; set; }

        [Required(ErrorMessage = "Please Enter A Valid Return Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> ReturnDate { get; set; }


    }

 
    }