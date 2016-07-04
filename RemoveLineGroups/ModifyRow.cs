using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoveLineGroups
{
    public partial class ModifyRow : Form
    {
        public ModifyRow()
        {
            InitializeComponent();
        }
        public string PhraseFirstRow
        {
            get { return tbFirstRow.Text; }
            set { tbFirstRow.Text = value; }
        }
        public string PhraseSecondRow
        {
            get { return tbPhraseLastRow.Text; }
            set { tbPhraseLastRow.Text = value; }
        }
    }
}
