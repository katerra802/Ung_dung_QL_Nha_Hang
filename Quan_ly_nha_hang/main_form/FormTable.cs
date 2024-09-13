using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main_form
{
    public partial class FormTable : Form
    {
        public FormTable()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.White;
            setupTable();
        }

        private void setupTable()
        {
            int buttonWidth = 110;
            int buttonHeight = 110;
            int marginleft = 210;
            int marginRigt = 50;
            int margintop = 30;

            for (int i = 1; i <= 18; i++)
            {
                Guna.UI2.WinForms.Guna2CircleButton tableButton = new Guna.UI2.WinForms.Guna2CircleButton();
                tableButton.Text = "Bàn " + i;
                tableButton.Width = buttonWidth;
                tableButton.Height = buttonHeight;
                tableButton.Font = new Font(tableButton.Font.FontFamily, 15);

                // Tính toán vị trí
                int row = (i - 1) / 3; // Hàng thứ mấy (bắt đầu từ 0)
                int column = (i - 1) % 3; // Cột thứ mấy trong hàng (bắt đầu từ 0)

                // Thiết lập vị trí cho nút
                tableButton.Left = column * (buttonWidth + marginRigt) + marginleft; // Cột
                tableButton.Top = row * (buttonHeight + margintop) + margintop; // Hàng

                // Gán sự kiện click cho nút
                tableButton.Click += TableButton_Click;

                // Thêm nút vào form hoặc panel
                this.Controls.Add(tableButton);
            }

        }

        private EventHandler TableButton_Click = (sender, e) =>
        {
            Button clickedButton = sender as Button;
            MessageBox.Show($"Bạn đã chọn {clickedButton.Text}");
        };

    }
}
