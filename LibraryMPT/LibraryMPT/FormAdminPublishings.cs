using LibraryMPT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryMPT
{
    public partial class FormAdminPublishings : Form
    {
        public FormAdminPublishings()
        {
            InitializeComponent();
        }

        private void FormAdminPublishings_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var publishings = API.GET<List<PublishingHouse>>("publishingHouses");
            publishingsGrid.DataSource = publishings;
            publishingsGrid.Columns[0].Visible = false;
            (Owner as FormAdminBookEdit).RefreshPublishingCombo();
        }

        private void publishingsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (publishingsGrid.SelectedRows.Count != 0)
            {
                nameBox.Text = publishingsGrid.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (publishingsGrid.SelectedRows.Count != 0)
            {
                var publishingToDelete = API.GET<PublishingHouse>($"publishingHouses/{publishingsGrid.SelectedRows[0].Cells[0].Value}");
                API.DELETE("publishingHouses", publishingToDelete, publishingToDelete.ID_PublishingHouse);
                RefreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                PublishingHouse publishingHouse = new PublishingHouse(nameBox.Text.Trim());
                API.POST("publishingHouses", publishingHouse);
                RefreshGrid();
            }
            else MessageBox.Show("Заполните наименование");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (publishingsGrid.SelectedRows.Count != 0)
            {
                if (!string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    PublishingHouse publishingHouse = new PublishingHouse(nameBox.Text.Trim());
                    publishingHouse.ID_PublishingHouse = int.Parse(publishingsGrid.SelectedRows[0].Cells[0].Value.ToString());
                    API.PUT("publishingHouses", publishingHouse, publishingHouse.ID_PublishingHouse);
                    RefreshGrid();
                }
                else MessageBox.Show("Заполните наименование");
            }
        }
    }
}
