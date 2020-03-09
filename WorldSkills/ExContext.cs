using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldSkills
{
    public class ExContext : ApplicationContext
    {
        public ExContext()
        {
            NextFormCreated = false;
            NextF = new TitleForm(this);
            NextF.Closed += new EventHandler(OnFormClosed);
            NextF.StartPosition = FormStartPosition.CenterScreen;
            NextF.Show();
        }
        public Form NextF;
        public bool NextFormCreated;
        public void SetNext(Form form, Form next)
        {
            NextF = next;
            NextF.StartPosition = FormStartPosition.Manual;
            NextF.Location = form.Location;
            NextF.Closed += new EventHandler(OnFormClosed);
            NextFormCreated = true;
        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            if (NextFormCreated)
            {
                NextFormCreated = false;
                NextF.Show();
            }
            else
            {
                ExitThread();
            }
        }
    }
}
