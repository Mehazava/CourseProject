using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        public BaseForm(ExContext exContext)
        {
            InitializeComponent();
            context = exContext;
        }
        public ExContext context;
        //type of form to call on "back" button
        protected virtual Form GetBackForm()
        {
            return new TitleForm(context);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            labelTime.Text = TimeToContest.RemainingTime;
            TimeToContest.Label = labelTime;
            logoPic.Image = Properties.Resources.Logo100_50;
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimeToContest.Label = null;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            context.SetNext(this, GetBackForm());
            this.Close();
        }
    }
}
