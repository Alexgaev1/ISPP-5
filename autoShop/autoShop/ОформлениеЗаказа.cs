using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoShop
{
    public partial class ОформлениеЗаказа : Form
    {
        public ОформлениеЗаказа()
        {
            InitializeComponent();
        }

        private void ОформлениеЗаказа_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "autoShopDataSet1.Skladi". При необходимости она может быть перемещена или удалена.
            this.skladiTableAdapter.Fill(this.autoShopDataSet1.Skladi);

        }
    }
}
