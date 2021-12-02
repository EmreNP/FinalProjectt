using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
             ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categorManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categorManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var p in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(p.ProductName+"        //          "+p.CategoryName);
            }
        }
    }
}
