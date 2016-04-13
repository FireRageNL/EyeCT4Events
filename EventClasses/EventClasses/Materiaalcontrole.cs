using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventClasses
{
    public class Materiaalcontrole
    {
        private DBAdmin db = new DBAdmin();

        public List<Object> Geenmerk(string productnaam, int type)
        {
            return db.Geenmerk(productnaam, type);
        }

        public List<Object> Geenproductnaam(string merk, int type)
        {
            return db.Geenproductnaam(merk, type);
        }
        public List<Object> Geentype(string merk, string productnaam)
        {
            return db.Geentype(merk, productnaam);
        }

        public List<Object> Alleenmerk(string merk)
        {
            return db.Alleenmerk(merk);
        }
        public List<Object> Alleentype(int type)
        {
            return db.Alleentype(type);
        }

        public List<Object> Alleenproductnaam(string productnaam)
        {
            return db.Alleenproductnaam(productnaam);
        }
        public List<Object> Alles(string productnaam , string merk , int type)
        {
            return db.Alles(productnaam , merk , type);
        }
        public List<Object> BeheerMateriaal()
        {
            return db.BeheerMateriaal();
        }
        public void DeleteMateriaal(Object DeleteMateriaal)
        {
           db.DeleteMateriaal(DeleteMateriaal);
        }

        public void UpdateProduct(Object obj)
        {
            db.UpdateProduct(obj);
        }

        public void AddProduct(string brand, string product, int typenr, int price)
        {
            db.AddProduct(brand, product, typenr, price);
        }
    }
}
