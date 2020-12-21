using System.Collections.Generic;


namespace ProjetoMVC.Models.ViewModels
{
    public class SellerFormVieModel
    {
        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
