using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventClasses;

namespace BeheerSysteem
{
    public partial class MateriaalDialog : Form
    {
        private EventClasses.Login val;
        private bool nw;
        private Materiaalcontrole mc = new Materiaalcontrole();
        private EventClasses.Object obj;
        public MateriaalDialog(EventClasses.Login val,bool nw,EventClasses.Object obj)
        {
            this.val = val;
            this.nw = nw;
            this.obj = obj;
            InitializeComponent();
            TbMerk.Text = obj.Brand;
            TbPrijs.Text = ""+obj.Rentprice;
            TbProduct.Text = obj.Productname;
            TbType.Text = "" + obj.Type;
        }
        public MateriaalDialog(EventClasses.Login val, bool nw)
        {
            this.val = val;
            this.nw = nw;
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
                    if (nw)
                    {
                        mc.AddProduct(brand, product, typenr, price);
                    }
                    else
                    {
                        obj.Update(brand, product, typenr, price);
                        mc.UpdateProduct(obj);
                    }
                }
                this.Dispose();
            }
        }
    }
}
