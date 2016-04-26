using System.Collections.Generic;

namespace EventClasses
{
    public class Materiaalcontrole
    {
        private readonly DbAdmin _db = new DbAdmin();

        public List<Object> Geenmerk(string productnaam, int type)
        {
            return _db.Geenmerk(productnaam, type);
        }

        public List<Object> Geenproductnaam(string merk, int type)
        {
            return _db.Geenproductnaam(merk, type);
        }
        public List<Object> Geentype(string merk, string productnaam)
        {
            return _db.Geentype(merk, productnaam);
        }

        public List<Object> Alleenmerk(string merk)
        {
            return _db.Alleenmerk(merk);
        }
        public List<Object> Alleentype(int type)
        {
            return _db.Alleentype(type);
        }

        public List<Object> Alleenproductnaam(string productnaam)
        {
            return _db.Alleenproductnaam(productnaam);
        }
        public List<Object> Alles(string productnaam , string merk , int type)
        {
            return _db.Alles(productnaam , merk , type);
        }
        public List<Object> BeheerMateriaal()
        {
            return _db.BeheerMateriaal();
        }
        public void DeleteMateriaal(Object deleteMateriaal)
        {
           _db.DeleteMateriaal(deleteMateriaal);
        }

        public void UpdateProduct(Object obj)
        {
            _db.UpdateProduct(obj);
        }

        public void AddProduct(string brand, string product, int typenr, int price)
        {
            _db.AddProduct(brand, product, typenr, price);
        }
    }
}
