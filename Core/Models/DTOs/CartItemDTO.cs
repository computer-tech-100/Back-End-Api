using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AngularShoppingCartApp.Core.Models.DbEntities;

namespace AngularShoppingCartApp.Core.Models.DTOs
{
    //This is model for CartItem that represents one product in the cart
    public class CartItemDTO
    {
        [Key]
        public int ProductId { get; set; }//ProductId is both Foreign key and Primary Key
        [ForeignKey("ProductId")]//Foreign Key 
        public Product Product { get; set; } 
        public decimal Price{ get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get {return Quantity * Price;} }
    } 
}