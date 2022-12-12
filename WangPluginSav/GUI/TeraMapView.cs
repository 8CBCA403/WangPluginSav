namespace WangPluginSav.GUI
{
    public partial class TeraMapView : Form
    {
        public TeraMapView(Image map)
        {
            InitializeComponent();
            Map.Image = map;
        }
    }
}
