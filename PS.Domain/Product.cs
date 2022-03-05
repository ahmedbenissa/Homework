using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PS.Domain
{
    public class Product : Concept
    {

        [DataType(DataType.Date)]
        [Column("Production Date")]
        public DateTime DateProd { get; set; }

        [DataType(DataType.MultilineText, ErrorMessage = "this is a TextField")]
        public String Description { get; set; }

        [Required(ErrorMessage ="this field is required")]
        [MaxLength(25,ErrorMessage ="hey this name must contain 25 chars")]
        [StringLength(50,ErrorMessage ="this field's length in the Db == 50")]

        public String Name { get; set; }
        [DataType(DataType.Currency,ErrorMessage ="this must be a currency")]
        public double Price { get; set; }

        public int ProductId { get; set; }
        [Range(0,100000000000,ErrorMessage = "error")]
        public int Quantity { get; set; }
        public IList<Provider> Providers { get; set; }
        public String Image { get; set; }
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public Category MyCategory { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("name :" + Name + " , quantity : " + Quantity);
        }
        public virtual void GetMyType()
        {
            Console.WriteLine("Product");
        }

    }
}
