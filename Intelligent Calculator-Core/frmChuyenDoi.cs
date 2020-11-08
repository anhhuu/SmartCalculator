using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intelligent_Calculator_Core
{
    public partial class frmChuyenDoi : Form
    {
        public frmChuyenDoi()
        {
            InitializeComponent();
        }

        private void rdnhietdo_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbCuoi.Items.Clear();
            cbDau.Items.Add("Độ C");
            cbDau.Items.Add("Độ F");
            cbDau.Items.Add("Độ K");
            cbCuoi.Items.Add("Độ C");
            cbCuoi.Items.Add("Độ F");
            cbCuoi.Items.Add("Độ K");
            cbDau.Text = "Độ C";
            cbCuoi.Text = "Độ C";
            txtCuoi.Text = "";
        }

        private void rddodai_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("Met");
            cbDau.Items.Add("Kilomet");
            cbDau.Items.Add("Xentimet");
            cbDau.Items.Add("Decamet");
            cbDau.Items.Add("Deximet");
            cbDau.Items.Add("Hectomet");
            cbDau.Items.Add("Micromet");
            cbDau.Items.Add("Nanomet");
            cbDau.Items.Add("Picomet");
            cbDau.Items.Add("Milimet");
            cbDau.Items.Add("Mile");
            cbDau.Items.Add("Inch");
            cbDau.Items.Add("Hải lí");
            cbCuoi.Items.Clear();
            cbDau.Items.Add("Deximet");
            cbCuoi.Items.Add("Met");
            cbCuoi.Items.Add("Kilomet");
            cbCuoi.Items.Add("Xentimet");
            cbCuoi.Items.Add("Decamet");
            cbCuoi.Items.Add("Hectomet");
            cbCuoi.Items.Add("Micromet");
            cbCuoi.Items.Add("Nanomet");
            cbCuoi.Items.Add("Picomet");
            cbDau.Items.Add("Milimet");
            cbCuoi.Items.Add("Mile");
            cbCuoi.Items.Add("Inch");
            cbCuoi.Items.Add("Hải lí");
            cbDau.Text = "Met";
            cbCuoi.Text = "Met";
            txtCuoi.Text = "";
        }

        private void rdapsuat_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("Pa");
            cbDau.Items.Add("Atm");
            cbDau.Items.Add("mmHg");
            cbCuoi.Items.Clear();
            cbCuoi.Items.Add("Pa");
            cbCuoi.Items.Add("Atm");
            cbCuoi.Items.Add("mmHg");
            cbDau.Text = "Pa";
            cbCuoi.Text = "Pa";
            txtCuoi.Text = "";
        }

        private void rdnangluong_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("Jun");
            cbDau.Items.Add("Calo");
            cbCuoi.Items.Clear();
            cbCuoi.Items.Add("Jun");
            cbCuoi.Items.Add("Calo");
            cbDau.Text = "Jun";
            cbCuoi.Text = "Jun";
            txtCuoi.Text = "";
        }

        private void rddungluong_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("Byte");
            cbDau.Items.Add("KiloByte");
            cbDau.Items.Add("MegaByte");
            cbDau.Items.Add("GigaByte");
            cbDau.Items.Add("PetaByte");
            cbDau.Items.Add("TeraByte");
            cbCuoi.Items.Clear();
            cbCuoi.Items.Add("Byte");
            cbCuoi.Items.Add("KiloByte");
            cbCuoi.Items.Add("MegaByte");
            cbCuoi.Items.Add("Gigabyte");
            cbCuoi.Items.Add("PetaByte");
            cbCuoi.Items.Add("TeraByte");
            cbDau.Text = "Byte";
            cbCuoi.Text = "Byte";
            txtCuoi.Text = "";
        }

        private void rdhecoso_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("Nhị phân");
            cbDau.Items.Add("Thập phân");
            cbDau.Items.Add("Hệ Hexa");
            cbCuoi.Items.Clear();
            cbCuoi.Items.Add("Nhị phân");
            cbCuoi.Items.Add("Thập phân");
            cbCuoi.Items.Add("Hệ Hexa");
            cbDau.Text = "Nhị phân";
            cbCuoi.Text = "Nhị phân";
            txtCuoi.Text = "";
        }

        private void rdvantoc_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("m/s");
            cbDau.Items.Add("km/h");
            cbCuoi.Items.Clear();
            cbCuoi.Items.Add("m/s");
            cbCuoi.Items.Add("km/h");
            cbDau.Text = "m/s";
            cbCuoi.Text = "m/s";
            txtCuoi.Text = "";
        }

        private void rddientich_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("mét vuông");
            cbDau.Items.Add("cm vuông");
            cbDau.Items.Add("dm vuông");
            cbDau.Items.Add("mm vuông");
            cbDau.Items.Add("dam vuông");
            cbDau.Items.Add("km vuông");
            cbDau.Items.Add("sào");
            cbDau.Items.Add("mẫu");
            cbCuoi.Items.Clear();
            cbCuoi.Items.Add("mét vuông");
            cbCuoi.Items.Add("cm vuông");
            cbCuoi.Items.Add("dm vuông");
            cbCuoi.Items.Add("mm vuông");
            cbCuoi.Items.Add("dag vuông");
            cbCuoi.Items.Add("km vuông");
            cbCuoi.Items.Add("sào");
            cbCuoi.Items.Add("mẫu");
            cbDau.Text = "mét vuông";
            cbCuoi.Text = "mét vuông";
            txtCuoi.Text = "";
        }

        private void rdthetich_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("mm khối");
            cbDau.Items.Add("cm khối (ml)");
            cbDau.Items.Add("dm khối (l)");
            cbDau.Items.Add("m khối");
            cbCuoi.Items.Clear();
            cbCuoi.Items.Add("mm khối");
            cbCuoi.Items.Add("cm khối (ml)");
            cbCuoi.Items.Add("dm khối (l)");
            cbCuoi.Items.Add("m khối");
            cbDau.Text = "mm khối";
            cbCuoi.Text = "mm khối";
            txtCuoi.Text = "";
        }

        private void rdkhoiluong_CheckedChanged(object sender, EventArgs e)
        {
            cbDau.Items.Clear();
            cbDau.Items.Add("g");
            cbDau.Items.Add("dag");
            cbDau.Items.Add("hg");
            cbDau.Items.Add("kg");
            cbDau.Items.Add("yến");
            cbDau.Items.Add("tạ");
            cbDau.Items.Add("tấn");
            cbDau.Items.Add("Pound");
            cbCuoi.Items.Clear();
            cbCuoi.Items.Add("g");
            cbCuoi.Items.Add("dag");
            cbCuoi.Items.Add("hg");
            cbCuoi.Items.Add("kg");
            cbCuoi.Items.Add("yến");
            cbCuoi.Items.Add("tạ");
            cbCuoi.Items.Add("tấn");
            cbCuoi.Items.Add("Pound");
            cbDau.Text = "g";
            cbCuoi.Text = "g";
            txtCuoi.Text = "";
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                double dblGiatri1 = Convert.ToDouble(txtDau.Text);
                if (rdnhietdo.Checked == true)
                {
                    if (cbDau.Text == "Độ C")
                    {
                        if (cbCuoi.Text == "Độ C")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Độ F")
                        {
                            txtCuoi.Text = ((dblGiatri1 * 1.8) + 32).ToString();
                        }
                        else if (cbCuoi.Text == "Độ K")
                        {
                            txtCuoi.Text = (dblGiatri1 + 273).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Độ F")
                    {
                        if (cbCuoi.Text == "Độ F")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Độ C")
                        {
                            txtCuoi.Text = ((dblGiatri1 - 32) / 1.8).ToString();
                        }
                        else if (cbCuoi.Text == "Độ K")
                        {
                            txtCuoi.Text = (((dblGiatri1 - 32) / 1.8) + 273).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Độ K")
                    {
                        if (cbCuoi.Text == "Độ K")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Độ C")
                        {
                            txtCuoi.Text = (dblGiatri1 - 273).ToString();
                        }
                        else if (cbCuoi.Text == "Độ F")
                        {
                            txtCuoi.Text = ((dblGiatri1 * 1.8) + 32 -273).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (rddodai.Checked == true)
                {
                    if (cbDau.Text == "Met")
                    {
                        if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Milimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100).ToString();
                        }
                        else if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10).ToString();
                        }
                        else if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10).ToString();
                        }
                        else if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100).ToString();
                        }
                        else if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1852).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1609).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Kilomet")
                    {
                        if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Milimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100).ToString();
                        }
                        else if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10).ToString();
                        }
                        else if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000000 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000 / 1852).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000 / 1609).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787 * 1000).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if (cbDau.Text == "Milimet")
                    {
                        if (cbCuoi.Text == "Miliet")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                        }
                        else if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10).ToString();
                        }
                        else if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100).ToString();
                        }
                        else if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10000).ToString();
                        }
                        else if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100000).ToString();
                        }
                        else if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000 / 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000 / 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000000 / 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 / (1852 * 1000)).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 / (1609 * 1000)).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787 / 1000).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Xentimet")
                    {
                        if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100000).ToString();
                        }
                        else if (cbCuoi.Text == "Milimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10).ToString();
                        }
                        else if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100).ToString();
                        }
                        else if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10).ToString();
                        }
                        else if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10000).ToString();
                        }
                        else if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10000000).ToString();
                        }
                        else if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 / 185200).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 / 160900).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787 / 100).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Deximet")
                    {
                        if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10000).ToString();
                        }
                        else if (cbCuoi.Text == "Milimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100).ToString();
                        }
                        else if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10).ToString();
                        }
                        else if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10).ToString();
                        }
                        else if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100).ToString();
                        }
                        else if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100000000).ToString();
                        }
                        else if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 / 18520).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 / 16090).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787 / 10).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Decamet")
                    {
                        if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100).ToString();
                        }
                        else if (cbCuoi.Text == "Milimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10000).ToString();
                        }
                        else if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100).ToString();
                        }
                        else if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10).ToString();
                        }
                        else if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10).ToString();
                        }
                        else if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10000000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10000000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1852 * 10).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1609 * 10).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787 * 10).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Hectomet")
                    {
                        if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10).ToString();
                        }
                        else if (cbCuoi.Text == "Milimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100000).ToString();
                        }
                        else if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10000).ToString();
                        }
                        else if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                        }
                        else if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10).ToString();
                        }
                        else if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100).ToString();
                        }
                        else if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100000000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100000000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1852 * 100).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1609 * 100).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787 * 100).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Nanomet")
                    {

                        if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Milimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000 / 1000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100 / 1000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10 / 1000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000 / 1000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000000 / 1000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 / (1852000000000)).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 / (1609000000000)).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787 / 1000000000).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Micromet")
                    {
                        if (cbCuoi.Text == "Micromet")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Kilomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000000000).ToString();
                        }
                        else if (cbCuoi.Text == "Milimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000 / 1000000).ToString();
                        }
                        else if (cbCuoi.Text == "Xentimet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 100 / 1000000).ToString();
                        }
                        else if (cbCuoi.Text == "Deximet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 10 / 1000000).ToString();
                        }
                        else if (cbCuoi.Text == "Decamet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 10000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hectomet")
                        {
                            txtCuoi.Text = (dblGiatri1 / 100000000).ToString();
                        }
                        else if (cbCuoi.Text == "Nanomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000 / 1000000).ToString();
                        }
                        else if (cbCuoi.Text == "Met")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                        }
                        else if (cbCuoi.Text == "Picomet")
                        {
                            txtCuoi.Text = (dblGiatri1 * 1000000000000 / 1000000).ToString();
                        }
                        else if (cbCuoi.Text == "Hải lí")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1852000000).ToString();
                        }
                        else if (cbCuoi.Text == "Mile")
                        {
                            txtCuoi.Text = (dblGiatri1 / 1609000000).ToString();
                        }
                        else if (cbCuoi.Text == "Inch")
                        {
                            txtCuoi.Text = (dblGiatri1 * 39.3700787 / 1000000).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Picomet")
                    {
                        switch (cbCuoi.Text)
                        {

                            case "Picomet":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "Kilomet":
                                txtCuoi.Text = (dblGiatri1 / (1000000000000000)).ToString();
                                break;
                            case "Milimet":
                                txtCuoi.Text = (dblGiatri1 / 1000000000).ToString();
                                break;
                            case "Xentimet":
                                txtCuoi.Text = (dblGiatri1 / 10000000000).ToString();
                                break;
                            case "Deximet":
                                txtCuoi.Text = (dblGiatri1 / 100000000000).ToString();
                                break;
                            case "Decamet":
                                txtCuoi.Text = (dblGiatri1 / 10000000000000).ToString();
                                break;
                            case "Hectomet":
                                txtCuoi.Text = (dblGiatri1 / 100000000000000).ToString();
                                break;
                            case "Nanomet":
                                txtCuoi.Text = (dblGiatri1 / 1000).ToString();
                                break;
                            case "Micromet":
                                txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                                break;
                            case "Met":
                                txtCuoi.Text = (dblGiatri1 / 1000000000000).ToString();
                                break;
                            case "Hải lí":
                                txtCuoi.Text = (dblGiatri1 / 1852000000000000).ToString();
                                break;
                            case "Mile":
                                txtCuoi.Text = (dblGiatri1 / 1609000000000000).ToString();
                                break;
                            case "Inch":
                                txtCuoi.Text = (dblGiatri1 * 39.3700787 / 1000000000000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "Hải lí")
                    {
                        switch (cbCuoi.Text)
                        {

                            case "Hải lí":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "Kilomet":
                                txtCuoi.Text = (dblGiatri1 / (1.852)).ToString();
                                break;
                            case "Milimet":
                                txtCuoi.Text = (dblGiatri1 / 1852000).ToString();
                                break;
                            case "Xentimet":
                                txtCuoi.Text = (dblGiatri1 / 185200).ToString();
                                break;
                            case "Deximet":
                                txtCuoi.Text = (dblGiatri1 / 18520).ToString();
                                break;
                            case "Decamet":
                                txtCuoi.Text = (dblGiatri1 / 185.2).ToString();
                                break;
                            case "Hectomet":
                                txtCuoi.Text = (dblGiatri1 / 18.52).ToString();
                                break;
                            case "Nanomet":
                                txtCuoi.Text = (dblGiatri1 / 1852000000000).ToString();
                                break;
                            case "Micromet":
                                txtCuoi.Text = (dblGiatri1 / 1852000000).ToString();
                                break;
                            case "Met":
                                txtCuoi.Text = (dblGiatri1 / 1852).ToString();
                                break;
                            case "Picomet":
                                txtCuoi.Text = (dblGiatri1 / 1852000000000000).ToString();
                                break;
                            case "Mile":
                                txtCuoi.Text = (dblGiatri1 * 1609 / 1852).ToString();
                                break;
                            case "Inch":
                                txtCuoi.Text = (dblGiatri1 * 39.3700787 / 1852).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "Mile")
                    {
                        switch (cbCuoi.Text)
                        {

                            case "Mile":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "Kilomet":
                                txtCuoi.Text = (dblGiatri1 / (1.609)).ToString();
                                break;
                            case "Milimet":
                                txtCuoi.Text = (dblGiatri1 / 1609000).ToString();
                                break;
                            case "Xentimet":
                                txtCuoi.Text = (dblGiatri1 / 160900).ToString();
                                break;
                            case "Deximet":
                                txtCuoi.Text = (dblGiatri1 / 16090).ToString();
                                break;
                            case "Decamet":
                                txtCuoi.Text = (dblGiatri1 / 160.9).ToString();
                                break;
                            case "Hectomet":
                                txtCuoi.Text = (dblGiatri1 / 16.09).ToString();
                                break;
                            case "Nanomet":
                                txtCuoi.Text = (dblGiatri1 / 1609000000000).ToString();
                                break;
                            case "Micromet":
                                txtCuoi.Text = (dblGiatri1 / 1609000000).ToString();
                                break;
                            case "Met":
                                txtCuoi.Text = (dblGiatri1 / 1609).ToString();
                                break;
                            case "Picomet":
                                txtCuoi.Text = (dblGiatri1 / 1609000000000000).ToString();
                                break;
                            case "Hải lí":
                                txtCuoi.Text = (dblGiatri1 * 1852 / 1609).ToString();
                                break;
                            case "Inch":
                                txtCuoi.Text = (dblGiatri1 * 39.3700787 / 1609).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "Inch")
                    {
                        switch (cbCuoi.Text)
                        {

                            case "Inch":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "Kilomet":
                                txtCuoi.Text = (dblGiatri1 / (0.0000254)).ToString();
                                break;
                            case "Milimet":
                                txtCuoi.Text = (dblGiatri1 * 25.4).ToString();
                                break;
                            case "Xentimet":
                                txtCuoi.Text = (dblGiatri1 * 2.54).ToString();
                                break;
                            case "Deximet":
                                txtCuoi.Text = (dblGiatri1 * 0.254).ToString();
                                break;
                            case "Decamet":
                                txtCuoi.Text = (dblGiatri1 * 0.00254).ToString();
                                break;
                            case "Hectomet":
                                txtCuoi.Text = (dblGiatri1 * 0.000254).ToString();
                                break;
                            case "Nanomet":
                                txtCuoi.Text = (dblGiatri1 * 0.0254 * 1000000000).ToString();
                                break;
                            case "Micromet":
                                txtCuoi.Text = (dblGiatri1 * 0.0254 * 1000000).ToString();
                                break;
                            case "Met":
                                txtCuoi.Text = (dblGiatri1 * 0.0254).ToString();
                                break;
                            case "Picomet":
                                txtCuoi.Text = (dblGiatri1 * 0.0254 * 1000000000000).ToString();
                                break;
                            case "Mile":
                                txtCuoi.Text = (dblGiatri1 * 0.0254 / 1609).ToString();
                                break;
                            case "Hải lí":
                                txtCuoi.Text = (dblGiatri1 * 0.0254 / 1852).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (rddientich.Checked == true)
                {
                    if (cbDau.Text == "mét vuông")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "cm vuông":
                                txtCuoi.Text = (dblGiatri1 * 10000).ToString();
                                break;
                            case "dm vuông":
                                txtCuoi.Text = (dblGiatri1 * 100).ToString();
                                break;
                            case "mét vuông":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mm vuông":
                                txtCuoi.Text = (dblGiatri1 * 1000000).ToString();
                                break;
                            case "dam vuông":
                                txtCuoi.Text = (dblGiatri1 / 100).ToString();
                                break;
                            case "km vuông":
                                txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                                break;
                            case "sào":
                                txtCuoi.Text = (dblGiatri1 / 497).ToString();
                                break;
                            case "mẫu":
                                txtCuoi.Text = (dblGiatri1 / 4970).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "cm vuông")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "mét vuông":
                                txtCuoi.Text = (dblGiatri1 / 10000).ToString();
                                break;
                            case "dm vuông":
                                txtCuoi.Text = (dblGiatri1 / 100).ToString();
                                break;
                            case "cm vuông":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mm vuông":
                                txtCuoi.Text = (dblGiatri1 * 100).ToString();
                                break;
                            case "dam vuông":
                                txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                                break;
                            case "km vuông":
                                txtCuoi.Text = (dblGiatri1 / 10000000000).ToString();
                                break;
                            case "sào":
                                txtCuoi.Text = (dblGiatri1 / 4970000).ToString();
                                break;
                            case "mẫu":
                                txtCuoi.Text = (dblGiatri1 / 49700000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "dm vuông")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "cm vuông":
                                txtCuoi.Text = (dblGiatri1 * 100).ToString();
                                break;
                            case "mét vuông":
                                txtCuoi.Text = (dblGiatri1 / 100).ToString();
                                break;
                            case "dm vuông":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mm vuông":
                                txtCuoi.Text = (dblGiatri1 * 10000).ToString();
                                break;
                            case "dam vuông":
                                txtCuoi.Text = (dblGiatri1 / 10000).ToString();
                                break;
                            case "km vuông":
                                txtCuoi.Text = (dblGiatri1 / 100000000).ToString();
                                break;
                            case "sào":
                                txtCuoi.Text = (dblGiatri1 / 49700).ToString();
                                break;
                            case "mẫu":
                                txtCuoi.Text = (dblGiatri1 / 497000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "mm vuông")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "cm vuông":
                                txtCuoi.Text = (dblGiatri1 / 100).ToString();
                                break;
                            case "dm vuông":
                                txtCuoi.Text = (dblGiatri1 / 10000).ToString();
                                break;
                            case "mm vuông":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mét vuông":
                                txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                                break;
                            case "dam vuông":
                                txtCuoi.Text = (dblGiatri1 / 100000000).ToString();
                                break;
                            case "km vuông":
                                txtCuoi.Text = (dblGiatri1 / 1000000000000).ToString();
                                break;
                            case "sào":
                                txtCuoi.Text = (dblGiatri1 / 497000000).ToString();
                                break;
                            case "mẫu":
                                txtCuoi.Text = (dblGiatri1 / 4970000000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "dam vuông")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "cm vuông":
                                txtCuoi.Text = (dblGiatri1 * 10000 * 100).ToString();
                                break;
                            case "dm vuông":
                                txtCuoi.Text = (dblGiatri1 * 100 * 100).ToString();
                                break;
                            case "dam vuông":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mm vuông":
                                txtCuoi.Text = (dblGiatri1 * 1000000 * 100).ToString();
                                break;
                            case "mét vuông":
                                txtCuoi.Text = (dblGiatri1 * 100).ToString();
                                break;
                            case "km vuông":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 100).ToString();
                                break;
                            case "sào":
                                txtCuoi.Text = (dblGiatri1 / 497 * 100).ToString();
                                break;
                            case "mẫu":
                                txtCuoi.Text = (dblGiatri1 / 4970 * 100).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "km vuông")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "cm vuông":
                                txtCuoi.Text = (dblGiatri1 * 10000 * 1000000).ToString();
                                break;
                            case "dm vuông":
                                txtCuoi.Text = (dblGiatri1 * 100 * 1000000).ToString();
                                break;
                            case "km vuông":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mm vuông":
                                txtCuoi.Text = (dblGiatri1 * 1000000 * 1000000).ToString();
                                break;
                            case "dam vuông":
                                txtCuoi.Text = (dblGiatri1 / 100 * 1000000).ToString();
                                break;
                            case "mét vuông":
                                txtCuoi.Text = (dblGiatri1 * 1000000).ToString();
                                break;
                            case "sào":
                                txtCuoi.Text = (dblGiatri1 / 497 * 1000000).ToString();
                                break;
                            case "mẫu":
                                txtCuoi.Text = (dblGiatri1 / 4970 * 1000000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "sào")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "cm vuông":
                                txtCuoi.Text = (dblGiatri1 * 10000 * 497).ToString();
                                break;
                            case "dm vuông":
                                txtCuoi.Text = (dblGiatri1 * 100 * 497).ToString();
                                break;
                            case "sào":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mm vuông":
                                txtCuoi.Text = (dblGiatri1 * 1000000 * 497).ToString();
                                break;
                            case "dam vuông":
                                txtCuoi.Text = (dblGiatri1 / 100 * 497).ToString();
                                break;
                            case "km vuông":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 497).ToString();
                                break;
                            case "mét vuông":
                                txtCuoi.Text = (dblGiatri1 * 497).ToString();
                                break;
                            case "mẫu":
                                txtCuoi.Text = (dblGiatri1 / 4970 * 497).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "mẫu")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "cm vuông":
                                txtCuoi.Text = (dblGiatri1 * 10000 * 4970).ToString();
                                break;
                            case "dm vuông":
                                txtCuoi.Text = (dblGiatri1 * 100 * 4970).ToString();
                                break;
                            case "mẫu":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mm vuông":
                                txtCuoi.Text = (dblGiatri1 * 1000000 * 4970).ToString();
                                break;
                            case "dam vuông":
                                txtCuoi.Text = (dblGiatri1 / 100 * 4970).ToString();
                                break;
                            case "km vuông":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 4970).ToString();
                                break;
                            case "sào":
                                txtCuoi.Text = (dblGiatri1 / 497 * 4970).ToString();
                                break;
                            case "mét vuông":
                                txtCuoi.Text = (dblGiatri1 * 4970).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (rdthetich.Checked == true)
                {
                    if (cbDau.Text == "mm khối")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "mm khối":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "cm khối (ml)":
                                txtCuoi.Text = (dblGiatri1 / 1000).ToString();
                                break;
                            case "dm khối (l)":
                                txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                                break;
                            case "m khối":
                                txtCuoi.Text = (dblGiatri1 / 1000000000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "cm khối (ml)")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "mm khối":
                                txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                                break;
                            case "cm khối (ml)":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dm khối (l)":
                                txtCuoi.Text = (dblGiatri1 / 1000).ToString();
                                break;
                            case "m khối":
                                txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "dm khối (l)")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "mm khối":
                                txtCuoi.Text = (dblGiatri1 * 1000 * 1000).ToString();
                                break;
                            case "dm khối (l)":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "cm khối (ml)":
                                txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                                break;
                            case "m khối":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 1000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "m khối")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "mm khối":
                                txtCuoi.Text = (dblGiatri1 * 1000 * 1000000).ToString();
                                break;
                            case "m khối":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dm khối (l)":
                                txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                                break;
                            case "cm khối (ml)":
                                txtCuoi.Text = (dblGiatri1 * 1000000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (rdkhoiluong.Checked == true)
                {
                    if (cbDau.Text == "g")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "g":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dag":
                                txtCuoi.Text = (dblGiatri1 / 10).ToString();
                                break;
                            case "hg":
                                txtCuoi.Text = (dblGiatri1 / 100).ToString();
                                break;
                            case "kg":
                                txtCuoi.Text = (dblGiatri1 / 1000).ToString();
                                break;
                            case "yến":
                                txtCuoi.Text = (dblGiatri1 / 10000).ToString();
                                break;
                            case "tạ":
                                txtCuoi.Text = (dblGiatri1 / 100000).ToString();
                                break;
                            case "tấn":
                                txtCuoi.Text = (dblGiatri1 / 1000000).ToString();
                                break;
                            case "Pound":
                                txtCuoi.Text = (dblGiatri1 * 0.00220462262).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "dag")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "dag":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "g":
                                txtCuoi.Text = (dblGiatri1 * 10).ToString();
                                break;
                            case "hg":
                                txtCuoi.Text = (dblGiatri1 / 100 * 10).ToString();
                                break;
                            case "kg":
                                txtCuoi.Text = (dblGiatri1 / 1000 * 10).ToString();
                                break;
                            case "yến":
                                txtCuoi.Text = (dblGiatri1 / 10000 * 10).ToString();
                                break;
                            case "tạ":
                                txtCuoi.Text = (dblGiatri1 / 100000 * 10).ToString();
                                break;
                            case "tấn":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 10).ToString();
                                break;
                            case "Pound":
                                txtCuoi.Text = (dblGiatri1 * 0.00220462262 * 10).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "hg")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "hg":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dag":
                                txtCuoi.Text = (dblGiatri1 / 10 * 100).ToString();
                                break;
                            case "g":
                                txtCuoi.Text = (dblGiatri1 * 100).ToString();
                                break;
                            case "kg":
                                txtCuoi.Text = (dblGiatri1 / 1000 * 100).ToString();
                                break;
                            case "yến":
                                txtCuoi.Text = (dblGiatri1 / 10000 * 100).ToString();
                                break;
                            case "tạ":
                                txtCuoi.Text = (dblGiatri1 / 100000 * 100).ToString();
                                break;
                            case "tấn":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 100).ToString();
                                break;
                            case "Pound":
                                txtCuoi.Text = (dblGiatri1 * 0.00220462262 * 100).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "kg")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "kg":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dag":
                                txtCuoi.Text = (dblGiatri1 / 10 * 1000).ToString();
                                break;
                            case "hg":
                                txtCuoi.Text = (dblGiatri1 / 100 * 1000).ToString();
                                break;
                            case "g":
                                txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                                break;
                            case "yến":
                                txtCuoi.Text = (dblGiatri1 / 10000 * 1000).ToString();
                                break;
                            case "tạ":
                                txtCuoi.Text = (dblGiatri1 / 100000 * 1000).ToString();
                                break;
                            case "tấn":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 1000).ToString();
                                break;
                            case "Pound":
                                txtCuoi.Text = (dblGiatri1 * 0.00220462262 * 1000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "yến")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "yến":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dag":
                                txtCuoi.Text = (dblGiatri1 / 10 * 1000 * 10).ToString();
                                break;
                            case "hg":
                                txtCuoi.Text = (dblGiatri1 / 100 * 1000 * 10).ToString();
                                break;
                            case "g":
                                txtCuoi.Text = (dblGiatri1 * 1000 * 10).ToString();
                                break;
                            case "kg":
                                txtCuoi.Text = (dblGiatri1 * 10).ToString();
                                break;
                            case "tạ":
                                txtCuoi.Text = (dblGiatri1 / 100000 * 1000 * 10).ToString();
                                break;
                            case "tấn":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 1000 * 10).ToString();
                                break;
                            case "Pound":
                                txtCuoi.Text = (dblGiatri1 * 0.00220462262 * 1000 * 10).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "tạ")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "tạ":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dag":
                                txtCuoi.Text = (dblGiatri1 / 10 * 1000 * 100).ToString();
                                break;
                            case "hg":
                                txtCuoi.Text = (dblGiatri1 / 100 * 1000 * 100).ToString();
                                break;
                            case "g":
                                txtCuoi.Text = (dblGiatri1 * 1000 * 100).ToString();
                                break;
                            case "yến":
                                txtCuoi.Text = (dblGiatri1 / 10000 * 1000 * 100).ToString();
                                break;
                            case "kg":
                                txtCuoi.Text = (dblGiatri1 * 100).ToString();
                                break;
                            case "tấn":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 1000 * 100).ToString();
                                break;
                            case "Pound":
                                txtCuoi.Text = (dblGiatri1 * 0.00220462262 * 1000 * 100).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "tấn")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "tấn":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dag":
                                txtCuoi.Text = (dblGiatri1 / 10 * 1000 * 1000).ToString();
                                break;
                            case "hg":
                                txtCuoi.Text = (dblGiatri1 / 100 * 1000 * 1000).ToString();
                                break;
                            case "g":
                                txtCuoi.Text = (dblGiatri1 * 1000 * 1000).ToString();
                                break;
                            case "yến":
                                txtCuoi.Text = (dblGiatri1 / 10000 * 1000 * 1000).ToString();
                                break;
                            case "tạ":
                                txtCuoi.Text = (dblGiatri1 / 100000 * 1000 * 1000).ToString();
                                break;
                            case "kg":
                                txtCuoi.Text = (dblGiatri1 * 1000).ToString();
                                break;
                            case "Pound":
                                txtCuoi.Text = (dblGiatri1 * 0.00220462262 * 1000 * 1000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "Pound")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "Pound":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "dag":
                                txtCuoi.Text = (dblGiatri1 / 10 * 1000 * 0.45359237).ToString();
                                break;
                            case "hg":
                                txtCuoi.Text = (dblGiatri1 / 100 * 1000 * 0.45359237).ToString();
                                break;
                            case "g":
                                txtCuoi.Text = (dblGiatri1 * 1000 * 0.45359237).ToString();
                                break;
                            case "yến":
                                txtCuoi.Text = (dblGiatri1 / 10000 * 1000 * 0.45359237).ToString();
                                break;
                            case "tạ":
                                txtCuoi.Text = (dblGiatri1 / 100000 * 1000 * 0.45359237).ToString();
                                break;
                            case "tấn":
                                txtCuoi.Text = (dblGiatri1 / 1000000 * 1000 * 0.45359237).ToString();
                                break;
                            case "kg":
                                txtCuoi.Text = (dblGiatri1 * 0.45359237).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (rdapsuat.Checked == true)
                {
                    if (cbDau.Text == "Pa")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "Pa":
                                txtCuoi.Text = dblGiatri1.ToString();
                                break;
                            case "Atm":
                                txtCuoi.Text = (dblGiatri1 / 100000).ToString();
                                break;
                            case "mmHg":
                                txtCuoi.Text = (dblGiatri1 * 76 / 100000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "Atm")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "Atm":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "mmHg":
                                txtCuoi.Text = (dblGiatri1 * 76).ToString();
                                break;
                            case "Pa":
                                txtCuoi.Text = (dblGiatri1 * 100000).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "mmHg")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "Atm":
                                txtCuoi.Text = (dblGiatri1 / 76).ToString();
                                break;
                            case "mmHg":
                                txtCuoi.Text = (dblGiatri1).ToString();
                                break;
                            case "Pa":
                                txtCuoi.Text = (dblGiatri1 * 100000 / 76).ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (rdvantoc.Checked == true)
                {
                    if (cbDau.Text == "m/s")
                    {
                        if (cbCuoi.Text == "m/s")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "km/h")
                        {
                            txtCuoi.Text = (dblGiatri1 * 3.6).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "km/h")
                    {
                        if (cbCuoi.Text == "km/h")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "m/s")
                        {
                            txtCuoi.Text = (dblGiatri1 / 3.6).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (rdnangluong.Checked == true)
                {
                    if (cbDau.Text == "Calo")
                    {
                        if (cbCuoi.Text == "Calo")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Jun")
                        {
                            txtCuoi.Text = (dblGiatri1 * 4.2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbDau.Text == "Jun")
                    {
                        if (cbCuoi.Text == "Jun")
                        {
                            txtCuoi.Text = dblGiatri1.ToString();
                        }
                        else if (cbCuoi.Text == "Calo")
                        {
                            txtCuoi.Text = (dblGiatri1 / 4.2).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập đúng loại giá trị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rdhecoso.Checked == true)
            {
                if (cbDau.Text == "Nhị phân")
                {
                    if (cbCuoi.Text == "Thập phân")
                    {

                        string st1 = Convert.ToString(txtDau.Text);
                        if (st1.Contains("2") == true || st1.Contains("3") == true || st1.Contains("4") == true || st1.Contains("5") == true || st1.Contains("6") == true || st1.Contains("7") == true || st1.Contains("8") == true || st1.Contains("9") == true)
                        {
                            MessageBox.Show("Vui lòng nhập dãy số hệ nhị phân (0 hoặc 1)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            double tp = 0;
                            for (int i = 0; i < st1.Length; i++)
                            {
                                double k = Convert.ToDouble(st1.Length);
                                if (st1[i].ToString() == "1")
                                {
                                    tp = tp + (Math.Pow(2, k - i - 1));
                                }
                            }
                            txtCuoi.Text = tp.ToString();
                        }
                    }
                    else if (cbCuoi.Text == "Nhị phân")
                    {
                        string st1 = Convert.ToString(txtDau.Text);
                        if (st1.Contains("2") == true || st1.Contains("3") == true || st1.Contains("4") == true || st1.Contains("5") == true || st1.Contains("6") == true || st1.Contains("7") == true || st1.Contains("8") == true || st1.Contains("9") == true)
                        {
                            MessageBox.Show("Vui lòng nhập dãy số hệ nhị phân (0 hoặc 1)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            txtCuoi.Text = st1;
                        }
                    }
                    else if (cbCuoi.Text == "Hệ Hexa")
                    {
                        txtCuoi.Text = "";
                        string st1 = Convert.ToString(txtDau.Text);
                        if (st1.Contains("2") == true || st1.Contains("3") == true || st1.Contains("4") == true || st1.Contains("5") == true || st1.Contains("6") == true || st1.Contains("7") == true || st1.Contains("8") == true || st1.Contains("9") == true)
                        {
                            MessageBox.Show("Vui lòng nhập dãy số hệ nhị phân (0 hoặc 1)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            double tp = 0;
                            for (int i = 0; i < st1.Length; i++)
                            {
                                double k = Convert.ToDouble(st1.Length);
                                if (st1[i].ToString() == "1")
                                {
                                    tp = tp + (Math.Pow(2, k - i - 1));
                                }
                            }
                            string str = "";
                            string STR = "";
                            while (tp != 0)
                            {
                                int du = (Convert.ToInt32(tp)) % 16;
                                tp = Convert.ToInt32(tp) / 16;
                                if (du == 10)
                                {
                                    str = str + "A";
                                }
                                else if (du == 11)
                                {
                                    str = str + "B";
                                }
                                else if (du == 12)
                                {
                                    str = str + "C";
                                }
                                else if (du == 13)
                                {
                                    str = str + "D";
                                }
                                else if (du == 14)
                                {
                                    str = str + "E";
                                }
                                else if (du == 15)
                                {
                                    str = str + "F";
                                }
                                else
                                {
                                    str = str + du.ToString();
                                }
                            }
                            for (int i = (str.Length - 1); i >= 0; i--)
                            {
                                STR = STR + str[i];
                            }
                            txtCuoi.Text = STR;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cbDau.Text == "Thập phân")
                {
                    if (cbCuoi.Text == "Thập phân")
                    {
                        txtCuoi.Text = txtDau.Text;
                    }
                    else if (cbCuoi.Text == "Nhị phân")
                    {
                        try
                        {
                            string str = "";
                            string STR = "";
                            int GiaTri = Convert.ToInt32(txtDau.Text);
                            while (GiaTri != 0)
                            {
                                int du = GiaTri % 2;
                                GiaTri = GiaTri / 2;
                                str = str + du.ToString();
                            }
                            for (int i = (str.Length - 1); i >= 0; i--)
                            {
                                STR = STR + str[i];
                            }
                            txtCuoi.Text = STR;
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập đúng loại giá trị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (cbCuoi.Text == "Hệ Hexa")
                    {
                        try
                        {
                            string str = "";
                            string STR = "";
                            int GiaTri = Convert.ToInt32(txtDau.Text);
                            while (GiaTri != 0)
                            {
                                int du = GiaTri % 16;
                                GiaTri = GiaTri / 16;
                                if (du == 10)
                                {
                                    str = str + "A";
                                }
                                else if (du == 11)
                                {
                                    str = str + "B";
                                }
                                else if (du == 12)
                                {
                                    str = str + "C";
                                }
                                else if (du == 13)
                                {
                                    str = str + "D";
                                }
                                else if (du == 14)
                                {
                                    str = str + "E";
                                }
                                else if (du == 15)
                                {
                                    str = str + "F";
                                }
                                else
                                {
                                    str = str + du.ToString();
                                }
                            }
                            for (int i = (str.Length - 1); i >= 0; i--)
                            {
                                STR = STR + str[i];
                            }
                            txtCuoi.Text = STR;
                        }
                        catch
                        {
                            MessageBox.Show("Vui lòng nhập đúng loại giá trị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cbDau.Text == "Hệ Hexa")
                {
                    try
                    {
                        int GiaTri = int.Parse(txtDau.Text);
                        switch (cbCuoi.Text)
                        {
                            case "Hệ Hexa":
                                txtCuoi.Text = Convert.ToString(GiaTri, 16);
                                break;
                            case "Thập phân":
                                txtCuoi.Text = Convert.ToString(GiaTri, 10);
                                break;
                            case "Nhị phân":
                                txtCuoi.Text = Convert.ToString(GiaTri, 2);
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng loại giá trị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (rddungluong.Checked == true)
            {
                try
                {
                    double GiaTri = double.Parse(txtDau.Text);
                    if (cbDau.Text == "Byte")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "KiloByte":
                                txtCuoi.Text = (GiaTri / 1024).ToString();
                                break;
                            case "MegaByte":
                                txtCuoi.Text = (GiaTri / (1024 * 1024)).ToString();
                                break;
                            case "GigaByte":
                                txtCuoi.Text = (GiaTri / (1024 * 1024 * 1024)).ToString();
                                break;
                            case "TeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 4))).ToString();
                                break;
                            case "PeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 5))).ToString();
                                break;
                            case "Byte":
                                txtCuoi.Text = GiaTri.ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi, hoặc có lỗi xảy ra.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "KiloByte")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "Byte":
                                txtCuoi.Text = (GiaTri * 1024).ToString();
                                break;
                            case "MegaByte":
                                txtCuoi.Text = (GiaTri / (1024)).ToString();
                                break;
                            case "GigaByte":
                                txtCuoi.Text = (GiaTri / (1024 * 1024)).ToString();
                                break;
                            case "TeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 3))).ToString();
                                break;
                            case "PeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 4))).ToString();
                                break;
                            case "KiloByte":
                                txtCuoi.Text = GiaTri.ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi, hoặc có lỗi xảy ra.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "MegaByte")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "KiloByte":
                                txtCuoi.Text = (GiaTri * 1024).ToString();
                                break;
                            case "Byte":
                                txtCuoi.Text = (GiaTri * (1024 * 1024)).ToString();
                                break;
                            case "GigaByte":
                                txtCuoi.Text = (GiaTri / (1024)).ToString();
                                break;
                            case "TeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 2))).ToString();
                                break;
                            case "PeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 3))).ToString();
                                break;
                            case "MegaByte":
                                txtCuoi.Text = GiaTri.ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi, hoặc có lỗi xảy ra.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "GigaByte")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "KiloByte":
                                txtCuoi.Text = (GiaTri * 1024 * 1024).ToString();
                                break;
                            case "MegaByte":
                                txtCuoi.Text = (GiaTri * 1024).ToString();
                                break;
                            case "Byte":
                                txtCuoi.Text = (GiaTri * (1024 * 1024 * 1024)).ToString();
                                break;
                            case "TeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 1))).ToString();
                                break;
                            case "PeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 2))).ToString();
                                break;
                            case "GigaByte":
                                txtCuoi.Text = GiaTri.ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi, hoặc có lỗi xảy ra.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "TeraByte")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "KiloByte":
                                txtCuoi.Text = (GiaTri * 1024 * 1024 * 1024).ToString();
                                break;
                            case "MegaByte":
                                txtCuoi.Text = (GiaTri * 1024 * 1024).ToString();
                                break;
                            case "Byte":
                                txtCuoi.Text = (GiaTri * (1024 * 1024 * 1024) * 1024).ToString();
                                break;
                            case "GigaByte":
                                txtCuoi.Text = (GiaTri * (Math.Pow(1024, 1))).ToString();
                                break;
                            case "PeraByte":
                                txtCuoi.Text = (GiaTri / (Math.Pow(1024, 1))).ToString();
                                break;
                            case "TeraByte":
                                txtCuoi.Text = GiaTri.ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi, hoặc có lỗi xảy ra.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else if (cbDau.Text == "PetaByte")
                    {
                        switch (cbCuoi.Text)
                        {
                            case "KiloByte":
                                txtCuoi.Text = (GiaTri * 1024 * 1024 * 1024 * 1024).ToString();
                                break;
                            case "MegaByte":
                                txtCuoi.Text = (GiaTri * 1024 * 1024 * 1024).ToString();
                                break;
                            case "Byte":
                                txtCuoi.Text = (GiaTri * (Math.Pow(1024, 5))).ToString();
                                break;
                            case "TeraByte":
                                txtCuoi.Text = (GiaTri * (Math.Pow(1024, 1))).ToString();
                                break;
                            case "GigaByte":
                                txtCuoi.Text = (GiaTri * (Math.Pow(1024, 2))).ToString();
                                break;
                            case "PetaByte":
                                txtCuoi.Text = GiaTri.ToString();
                                break;
                            default:
                                MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi, hoặc có lỗi xảy ra.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã chọn sai đơn vị chuyển đổi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đúng loại giá trị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDau.Text = "";
            txtCuoi.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
