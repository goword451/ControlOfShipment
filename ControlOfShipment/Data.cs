using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ControlofShipmentModel
{
    public class Data
    {
        [DisplayName("Наименование")]
        public string Value { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }

        public Data (string value)
        {
            Value = value;
            Count = 1;
        }

        public static bool IsHexLetter(char ch)
        {
            return (ch >= 'A' && ch <= 'F') || (ch >= 'a' && ch <= 'F');
        }

        public static List<Data> AddDataToList(string[] inputString, List<Data> listAdd, List<Data> listChecked)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                bool matched = false;

                if (!String.IsNullOrWhiteSpace(inputString[i]))
                {
                    var data = new Data(inputString[i]);

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
                        if (listChecked.Exists(x => x.Value == data.Value))
                        {
                            foreach (var d in listChecked)
                            {
                                if (d.Value == data.Value)
                                {
                                    d.Count--;

                                    if (d.Count == 0)
                                    {
                                        listChecked.Remove(d);
                                    }

                                    break;
                                }
                            }
                        }

                        if (listAdd.Exists(x => x.Value == data.Value))
                        {
                            foreach (var d in listAdd)
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
                            listAdd.Add(data);
                        }
                    }
                }

                else
                {
                    continue;
                }
            }

            return listAdd;
        }
    }
}
