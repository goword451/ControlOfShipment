using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using ControlofShipmentModel;

namespace ControlOfShipment
{
    public partial class ControlOfShipment : Form
    {
        private List<Data> dataGetList = new List<Data>();
        private List<Data> dataGiveList = new List<Data>();

        public ControlOfShipment()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            GetTable.Rows.Clear();
            GiveTable.Rows.Clear();
        }

        private static bool IsHexLetter(char ch)
        {
            return (ch >= 'A' && ch <= 'F') || (ch >= 'a' && ch <= 'F');
        }


        private void Get_CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bool matched = false;
                var data = new Data(Get.Text.ToUpper());

                for (int i = 0; i < data.Value.Length; i++)
                {
                    if (IsHexLetter(data.Value[i]) || char.IsDigit(data.Value[i]))
                    {
                        matched = true;
                    }

                    else
                    {
                        matched = false;
                        continue;
                    }
                }

                if (matched && data.Value.Length == 24)
                {
                    if (dataGetList.Exists(x => x.Value == data.Value))
                    {
                        foreach (var d in dataGetList)
                        {
                            if (d.Value == data.Value)
                            {
                                d.Count++;
                                break;
                            }
                        }
                    }

                    else
                    {
                        dataGetList.Add(data);
                    }

                    var bindingGetList = new BindingList<Data>(dataGetList);
                    var sourceGet = new BindingSource(bindingGetList, null);
                    GetTable.DataSource = sourceGet;
                }

                else
                {
                    MessageBox.Show("Неверный идендификатор", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Get.Clear();
            }
        }

        private void Give_CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                bool matched = false;
                var data = new Data(Give.Text.ToUpper());

                for (int i = 0; i < data.Value.Length; i++)
                {
                    if (IsHexLetter(data.Value[i]) || char.IsDigit(data.Value[i]))
                    {
                        char.ToUpper(data.Value[i]);
                        matched = true;
                    }

                    else
                    {
                        matched = false;
                        continue;
                    }
                }

                if (matched && data.Value.Length == 24)
                {
                    if(dataGiveList.Exists(x => x.Value == data.Value))
                    {
                        foreach (var d in dataGiveList)
                        {
                            if (d.Value == data.Value)
                            {
                                d.Count++;
                                break;
                            }
                        }
                    }
                    else
                    {
                        dataGiveList.Add(data);
                    }


                    var bindingGiveList = new BindingList<Data>(dataGiveList);
                    var sourceGive = new BindingSource(bindingGiveList, null);
                    GiveTable.DataSource = sourceGive;
                }

                else
                {
                    MessageBox.Show("Неверный идендификатор", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Give.Clear();
            }
        }
    }
}
