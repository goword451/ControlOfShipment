using ControlofShipmentModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlOfShipmentTables
{
    public static class Tables
    {
        public static List<Data> dataGetList = new List<Data>();
        public static List<Data> dataGiveList = new List<Data>();

        public static BindingSource UpdateGetTable()
        {
            var bindingGetList = new BindingList<Data>(dataGetList);
            return new BindingSource(bindingGetList, null); 
        }

        public static BindingSource UpdateGiveTable()
        {
            var bindingGiveList = new BindingList<Data>(dataGiveList);
            return new BindingSource(bindingGiveList, null);
        }
    }
}
