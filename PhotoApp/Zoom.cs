using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoApp
{
    public partial class Zoom : Form
    {
        public Zoom()
        {
            InitializeComponent();
            OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        public float sz
        {
            get
            {
                return (Convert.ToInt32(sizeZoom.Text));
            }
            set
            {
                sizeZoom.Text = value.ToString();
            }
        }
    }
}
