namespace WangPluginSav
{
    public partial class HelpForm : Form
    {
        public HelpForm(string Version)
        {
            Vers = Version;
            InitializeComponent();
        }

        string Vers;
        private void HelpForm_Load(object sender, EventArgs e)
        {
            label3.Text = "You can report bugs on our Github page, on our\n" +
                            "Project Pokémon page or on Discord!\n\n" +

                            "**Read this before submitting a bug report!\n" +
                            "Please include\n" +
                            " - Your game type, Sword or Shield\n" +
                            " - Your Version Number(of this plugin)\n" +
                            " - Whether you have the DLC or not\n" +
                            " - A detailed explanation of the error\n";
            label2.Text = "This save block editor for Pokémon Sword/ Shield\n" +
                            "was a callaborative effort father / son project created\n" +
                            "out of love for the Pokémon franchise in order to\n" +
                            "edit and adjust various blocks of memory allowing\n" +
                            "the user to re -catch one - time only pokemon.";

            versionLBL.Text = $"Version: {Vers}";
        }

        private void cpyclip1_BTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("RadixComet#3669");
        }

        private void cpyclip2_BTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Darthfiggy#9205");
        }

        private void github_BTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/darkfiggy/dmaxplugin");
        }

        private void projpok_BTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://projectpokemon.org/home/forums/topic/58250-pkhex-plugin-dynamax-adventure-reset-issuesrequestsdiscussion/#");
        }
    }
}
