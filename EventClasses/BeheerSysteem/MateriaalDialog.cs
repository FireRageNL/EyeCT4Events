using System;
using System.Windows.Forms;
using EventClasses;
using Object = EventClasses.Object;

namespace BeheerSysteem
{
    public partial class MateriaalDialog : Form
    {
        private readonly bool _nw;
        private readonly Materiaalcontrole _mc = new Materiaalcontrole();
        private readonly Object _obj;
        public MateriaalDialog(bool nw,Object obj)
        {
            _nw = nw;
            _obj = obj;
            InitializeComponent();
            TbMerk.Text = obj.Brand;
            TbPrijs.Text = ""+obj.Rentprice;
            TbProduct.Text = obj.Productname;
            TbType.Text = "" + obj.Type;
        }
        public MateriaalDialog(bool nw)
        {
            _nw = nw;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (TbMerk.Text == "" || TbPrijs.Text == "" || TbProduct.Text == "" || TbType.Text == "")
            {
                MessageBox.Show("Vul alle velden in a.u.b");
            }
            else
            {
                string brand = TbMerk.Text;
                string product = TbProduct.Text;
                int typenr;
                int price;
                bool type = int.TryParse(TbPrijs.Text, out price);
                bool pr = int.TryParse(TbType.Text, out typenr);
                if (type && pr)
                {
                    if (_nw)
                    {
                        _mc.AddProduct(brand, product, typenr, price);
                    }
                    else
                    {
                        _obj.Update(brand, product, typenr, price);
                        _mc.UpdateProduct(_obj);
                    }
                }
                Dispose();
            }
        }
    }
}
