using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAdministrationModule.Forms.Common
{
    public partial class FormLoader : Form
    {
        public Action Worker { get; set; }
        public FormLoader(Action worker)
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            if (worker == null)
            {
                throw new ArgumentNullException();
            }

            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(e => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
