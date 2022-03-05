using System;
using System.Collections.Generic;
using System.Linq;
using PS.Domain;

namespace PS.Service
{
    public class ManageProduct
    {
        public List<Product> Products { get; set; }

        public List<Product> Get5Chemical(double price)
        {
            return (from prod in Products
                    where prod.Price > price && prod is Chemical
                    select prod).Take(5).ToList();
        }

        public List<Product> GetProductPrice(double price)
        {
            return (from prod in Products
                    where prod.Price > price
                    select prod).Skip(2).ToList();
        }

        public double GetAveragePrice()
        {
            return (from prod in Products
                    select prod.Price).Average();
        }

        public Product GetMaxPrice()
        {
            double max = (from prod in Products
                          select prod.Price).Max();

            return (from prod in Products
                    where prod.Price == max
                    select prod).FirstOrDefault();
        }
        public Product GetMaxPrice2()
        {
            return (from prod in Products
                    orderby prod.Price descending
                    select prod).FirstOrDefault();
        }

        public int GetCountProduct(string city)
        {
            return (from prod in Products
                    where prod is Chemical && ((Chemical)prod).MyAdress.City == city
                    select prod.Price).Count();
        }
        public List<Product> GetChemicalCity()
        {
            return (from pr in Products
                    where pr is Chemical
                    orderby ((Chemical)pr).MyAdress.City
                    select pr).ToList();
        }
        public IEnumerable<IGrouping<string, Product>> GetChemicalGroupByCity()
        {

            var result = (from pr in Products
                          where pr is Chemical
                          orderby ((Chemical)pr).MyAdress.City
                          group pr by ((Chemical)pr).MyAdress.City);
            //either groupby or select can't have both
            //select rturns IEnumerable<type>
            //group by: IEnumerable<IGrouping<string:type of city, Product>
            foreach (var gr in result)
            {
                Console.WriteLine(gr.Key);
                foreach (var p in gr)
                {
                    p.GetDetails();
                }
            }

            return result;

        }


        public List<Product> FindProduct(Char c)
        {
            return Products.Where(p => p.Name.StartsWith(c)).ToList();   //knows that variable p is related to products                                             
        }

        public void ScanProduct(Category cat)
        {
            var listPr = Products.Where(p => p.MyCategory.Name == cat.Name);//equal(impo for objet=objet but string=string yeah) with atts while = with classes
            foreach (var p in listPr)
            {
                p.GetDetails();
            }
        }


    }
}
