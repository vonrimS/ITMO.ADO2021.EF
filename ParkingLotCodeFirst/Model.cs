using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkingLot
{

    

    public class Driver
    {
        public int DriverId { get; set; }
        //[Required]
        //[MaxLength(30)]
        public string FirstName { get; set; }
        //[Required]
        //[MaxLength(30)]
        public string SecondName { get; set; }
        //[Range(18, 80)]
        public int DriverAge { get; set; }
        //[Column(TypeName = "image")]
        public byte[] DriverPhoto { get; set; }
        //[Required]
        public string CarNum { get; set; }
        //[Required]
        //[Range(1, 8)]
        public int PlaceNum { get; set; }

        public override string ToString()
        {
            string s = "Имя: " + FirstName + " " + SecondName + "\n номер а/м: " + CarNum + "\n парковочное место: " + PlaceNum;
            return s;
        }

        // Ссылка на машины
        public virtual List<Car> Cars { get; set; }
        public Driver()
        {
            Cars = new List<Car>();
        }

        // Ссылка на машиноместо
        public ParkingPlace ParkingPlace { get; set; }
    }

    public class Car
    {
        public string CarId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }


        // Ссылка на водителя
        public Driver Driver { get; set; }

        public override string ToString()
        {
            string s = CarId + ", а/м: " + BrandName + " " + ModelName + ", цвет:" + Color;
            return s;
        }

    }

    public class ParkingPlace
    {
        public string ParkingPlaceId { get; set; }
        public int PlaceNum { get; set; }
        public bool Occupied { get; set; }

        ////ссылка на водителя
        //public Driver Driver { get; set; }
    }

    public class AuthUser
    {
        [Key]
        public string AuthUserId { get; set; }
        //[Required]
        //[MaxLength(10)]
        public string Username { get; set; }
        //[Required]
        //[MaxLength(10)]
        public string Password { get; set; }

    }
}
