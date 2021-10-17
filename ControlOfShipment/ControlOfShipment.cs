using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using ControlofShipmentModel;

namespace ControlOfShipment
{
    public partial class ControlOfShipment : Form
    {
        public List<Data> dataGetList = new List<Data>();
        public List<Data> dataGiveList = new List<Data>();

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
                string[] stringGet = Get.Text.Split(' ');

                for (int i = 0; i < stringGet.Length; i++)
                {
                    bool matched = false;
                    var data = new Data(stringGet[i].ToUpper());

                    for (int j = 0; j < data.Value.Length; j++)
                    {
                        if (IsHexLetter(data.Value[j]) || char.IsDigit(data.Value[j]))
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
                        if (dataGiveList.Exists(x => x.Value == data.Value))
                        {
                            foreach (var d in dataGiveList)
                            {
                                if (d.Value == data.Value)
                                {
                                    d.Count--;

                                    if (d.Count == 0)
                                    {
                                        dataGiveList.Remove(d);
                                    }

                                    break;
                                }
                            }
                        }

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
                        var bindingGiveList = new BindingList<Data>(dataGiveList);
                        var sourceGive = new BindingSource(bindingGiveList, null);
                        GiveTable.DataSource = sourceGive;
                    }

                    else
                    {
                        MessageBox.Show($"Неверный идендификатор {stringGet[i]}, либо введён пустой символ.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               

                Get.Clear();
            }
        }

        private void Give_CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string[] stringGive = Give.Text.Split(' ');

                for (int i = 0; i < stringGive.Length; i++)
                {
                    bool matched = false;
                    var data = new Data(stringGive[i].ToUpper());

                    for (int j = 0; j < data.Value.Length; j++)
                    {
                        if (IsHexLetter(data.Value[j]) || char.IsDigit(data.Value[j]))
                        {
                            char.ToUpper(data.Value[j]);
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
                                    d.Count--;

                                    if (d.Count == 0)
                                    {
                                        dataGetList.Remove(d);
                                    }

                                    break;
                                }
                            }
                        }

                        if (dataGiveList.Exists(x => x.Value == data.Value))
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


                        var bindingGetList = new BindingList<Data>(dataGetList);
                        var sourceGet = new BindingSource(bindingGetList, null);
                        GetTable.DataSource = sourceGet;
                        var bindingGiveList = new BindingList<Data>(dataGiveList);
                        var sourceGive = new BindingSource(bindingGiveList, null);
                        GiveTable.DataSource = sourceGive;
                    }

                    else
                    {
                        MessageBox.Show($"Неверный идендификатор {stringGive[i]}, либо введён пустой символ.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                Give.Clear();
            }
        }
    }
}
