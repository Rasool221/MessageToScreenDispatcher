using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageToScreenDispatcher
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string MessageText
        {
            get
            {
                return this.messageTextBox.Text;
            }
            set
            {
                this.messageTextBox.Text = value;
            }
        }

        public RichTextBox MessageLabel
        {
            get
            {
                return this.messageTextBox;
            }
        }
    }
}
