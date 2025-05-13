using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nikulnikov_demoexam_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "никульниковDataSet._Material_type_import_". При необходимости она может быть перемещена или удалена.
            this.material_type_import_TableAdapter.Fill(this.никульниковDataSet._Material_type_import_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "никульниковDataSet._Product_type_import_". При необходимости она может быть перемещена или удалена.
            this.product_type_import_TableAdapter.Fill(this.никульниковDataSet._Product_type_import_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "никульниковDataSet._Products_import_". При необходимости она может быть перемещена или удалена.
            this.products_import_TableAdapter.Fill(this.никульниковDataSet._Products_import_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "никульниковDataSet._Partner_products_import_". При необходимости она может быть перемещена или удалена.
            this.partner_products_import_TableAdapter.Fill(this.никульниковDataSet._Partner_products_import_);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "никульниковDataSet._Partners_import_". При необходимости она может быть перемещена или удалена.
            this.partners_import_TableAdapter.Fill(this.никульниковDataSet._Partners_import_);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
