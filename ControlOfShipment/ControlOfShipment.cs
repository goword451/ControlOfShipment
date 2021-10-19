using System;
using System.Windows.Forms;
using ControlofShipmentModel;
using ControlOfShipmentTables;

namespace ControlOfShipment
{
    public partial class ControlOfShipment : Form
    {
        public ControlOfShipment()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            GetTable.Rows.Clear();
            GiveTable.Rows.Clear();
        }

        private void Get_CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string[] stringGet = Get.Text.Split(' ');

                Data.AddDataToList(stringGet, Tables.dataGetList, Tables.dataGiveList);

                GiveTable.DataSource = Tables.UpdateGiveTable();
                GetTable.DataSource = Tables.UpdateGetTable();

                Get.Clear();
            }
        }

        private void Give_CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string[] stringGive = Give.Text.Split(' ');

                Data.AddDataToList(stringGive, Tables.dataGiveList, Tables.dataGetList);

                GiveTable.DataSource = Tables.UpdateGiveTable();
                GetTable.DataSource = Tables.UpdateGetTable();

                Give.Clear();
            }
        }
    }
}
