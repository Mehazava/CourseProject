using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorldSkills
{
    public partial class AboutWSForm : WorldSkills.BaseForm
    {
        protected override Form GetBackForm()
        {
            return new TitleForm(context);
        }
        public AboutWSForm()
        {
            InitializeComponent();
        }
        public AboutWSForm(ExContext exContext)
        {
            InitializeComponent();
            context = exContext;
        }
    }
}
