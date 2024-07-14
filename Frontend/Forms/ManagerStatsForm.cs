

using TaskManagement.Core.Models.Manager;

namespace TaskManagement.Frontend.Forms
{
    public partial class ManagerStatsForm : Form
    {
        public ManagerStatsForm()
        {
            InitializeComponent();
        }

        public void Initialize(List<TaskStatistics> statistics)
        {
            lvStats.Items.Clear();
            foreach (var stat in statistics)
            {

                var item = new ListViewItem(stat.UserId.ToString());
                item.SubItems.Add(stat.Username);
                item.SubItems.Add(stat.Year.ToString());
                item.SubItems.Add(stat.Month.ToString());
                item.SubItems.Add(stat.TaskCount.ToString());

                lvStats.Items.Add(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
