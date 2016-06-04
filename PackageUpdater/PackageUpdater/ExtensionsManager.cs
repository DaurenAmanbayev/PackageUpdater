using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PackageUpdater
{
    public partial class ExtensionsManager : Form
    {
        List<string> extList = new List<string>();
        List<string> checkedList = new List<string>();
        public ExtensionsManager(List<string> extList)
        {
            InitializeComponent();
            this.extList = extList;
            foreach (var extension in extList)
            {
                checkedListBoxExtensions.Items.Add(extension);
            }
           
        }
        public List<string> GetCheckedList()
        {
            return checkedList;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (checkedListBoxExtensions.CheckedItems.Count != 0)
            {
                foreach (var item in checkedListBoxExtensions.CheckedItems)
                {
                    checkedList.Add(item.ToString());
                }
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
