using System.Windows.Forms;

namespace ccMonitor.Gui
{
    public partial class RigTab : UserControl
    {
        public RigController.RigInfo Rig { get; set; }
        public RigTab(RigController.RigInfo rig)
        {
            Rig = rig;

            InitializeComponent();
        }
    }
}
