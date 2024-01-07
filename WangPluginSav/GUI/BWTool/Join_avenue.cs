/*
 * Created by SharpDevelop.
 * User: LAURA
 * Date: 16/06/2016
 * Time: 21:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Reflection;
using System.Resources;
using System.Text;

namespace BW_tool
{
    /// <summary>
    /// Description of Join_avenue.
    /// </summary>
    public partial class Join_avenue : Form
    {
        AVENUE ja;
        int avenue_block = 67;

        ResourceManager resources = new ResourceManager("BW_tool.Join_avenue", Assembly.GetExecutingAssembly());
        Bitmap sprites_data;
        Rectangle cloneRect;
        Bitmap cloneBitmap;

        public Join_avenue()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //

            InitializeComponent();

            ja = new AVENUE(BWToolMainForm.save.getBlock(avenue_block));
            load_data();


            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void load_npc()
        {
            npc_name.Text = ja.npc[(int)npc.Value].name;
            npc_gender.SelectedIndex = ja.npc[(int)npc.Value].gender;
            npc_text1.Text = ja.npc[(int)npc.Value].text1;
            npc_text1.Text = ja.npc[(int)npc.Value].text2;
            npc_spoken.Checked = ja.npc[(int)npc.Value].spoken;
        }
        void set_npc()
        {
            ja.npc[(int)npc.Value].name = npc_name.Text;
            ja.npc[(int)npc.Value].gender = npc_gender.SelectedIndex;
            ja.npc[(int)npc.Value].text1 = npc_text1.Text;
            ja.npc[(int)npc.Value].text2 = npc_text1.Text;
            ja.npc[(int)npc.Value].spoken = npc_spoken.Checked;
        }
        void Npc_applyClick(object sender, EventArgs e)
        {
            set_npc();
        }
        void NpcValueChanged(object sender, EventArgs e)
        {
            load_npc();
        }

        void load_data()
        {
            rank.Value = ja.rank;
            color.SelectedIndex = ja.color;
            favorite.Text = ja.fav_phrase;
            Impressed.Text = ja.imp_phrase;
            title.Text = ja.title;
            name.Text = ja.name;

            load_shop();
            load_visitor();
            load_npc();
            load_helper();

            shop.Value = 0;
            visitor.Value = 0;
            npc.Value = 0;
            helper.SelectedIndex = 0;
        }
        void set_data()
        {
            ja.rank = (int)rank.Value;
            ja.color = color.SelectedIndex;
            ja.fav_phrase = favorite.Text;
            ja.imp_phrase = Impressed.Text;
            ja.title = title.Text;
            ja.name = name.Text;

            ja.set_people();
        }
        void Exit_butClick(object sender, EventArgs e)
        {
            this.Close();
        }
        void Saveexit_butClick(object sender, EventArgs e)
        {
            set_data();
            BWToolMainForm.save.setBlock(ja.Data, avenue_block);
            this.Close();
        }
        void Helper_countrySelectedIndexChanged(object sender, EventArgs e)
        {

            helper_subregion.SelectedIndex = 0;
            helper_subregion.Items.Clear();
            object[] a;
            switch (helper_country.SelectedIndex)
            {
                case 9:
                    a = new object[helper_subregion_argentina.Items.Count];
                    helper_subregion_argentina.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 12:
                    a = new object[helper_subregion_australia.Items.Count];
                    helper_subregion_australia.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 28:
                    a = new object[helper_subregion_brazil.Items.Count];
                    helper_subregion_brazil.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 36:
                    a = new object[helper_subregion_canada.Items.Count];
                    helper_subregion_canada.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 43:
                    a = new object[helper_subregion_china.Items.Count];
                    helper_subregion_china.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 72:
                    a = new object[helper_subregion_finland.Items.Count];
                    helper_subregion_finland.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 73:
                    a = new object[helper_subregion_france.Items.Count];
                    helper_subregion_france.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 79:
                    a = new object[helper_subregion_germany.Items.Count];
                    helper_subregion_germany.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 95:
                    a = new object[helper_subregion_india.Items.Count];
                    helper_subregion_india.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 102:
                    a = new object[helper_subregion_italy.Items.Count];
                    helper_subregion_italy.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 105:
                    a = new object[helper_subregion_japan.Items.Count];
                    helper_subregion_japan.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 155:
                    a = new object[helper_subregion_norway.Items.Count];
                    helper_subregion_norway.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 166:
                    a = new object[helper_subregion_poland.Items.Count];
                    helper_subregion_poland.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 174:
                    a = new object[helper_subregion_russia.Items.Count];
                    helper_subregion_russia.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 195:
                    a = new object[helper_subregion_spain.Items.Count];
                    helper_subregion_spain.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 200:
                    a = new object[helper_subregion_sweeden.Items.Count];
                    helper_subregion_sweeden.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 218:
                    a = new object[helper_subregion_england.Items.Count];
                    helper_subregion_england.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                case 220:
                    a = new object[helper_subregion_USA.Items.Count];
                    helper_subregion_USA.Items.CopyTo(a, 0);
                    helper_subregion.Items.AddRange(a);
                    break;
                default:
                    helper_subregion.Items.Add("0 无");
                    break;
            }
        }
        void load_helper()
        {

            helper_name.Text = ja.helper[helper_value].name;
            helper_met.Text = ja.helper[helper_value].text0;
            helper_greet1.Text = ja.helper[helper_value].text1;
            helper_greet2.Text = ja.helper[helper_value].text2;
            helper_sprite.Value = ja.helper[helper_value].sprite;
            helper_country.SelectedIndex = ja.helper[helper_value].country;
            helper_subregion.SelectedIndex = ja.helper[helper_value].subregion;
            helper_date.Value = ja.helper[helper_value].met;
        }
        void set_helper()
        {
            ja.helper[helper_value].name = helper_name.Text;
            ja.helper[helper_value].text0 = helper_met.Text;
            ja.helper[helper_value].text1 = helper_greet1.Text;
            ja.helper[helper_value].text2 = helper_greet2.Text;
            ja.helper[helper_value].sprite = (int)helper_sprite.Value;
            ja.helper[helper_value].country = helper_country.SelectedIndex;
            ja.helper[helper_value].subregion = helper_subregion.SelectedIndex;
            ja.helper[helper_value].met = helper_date.Value;
        }
        void Helper_applyClick(object sender, EventArgs e)
        {
            set_helper();
            load_helper();
        }
        int helper_value = 0;
        void HelperSelectedIndexChanged(object sender, EventArgs e)
        {
            helper_value = helper.SelectedIndex;
            load_helper();
        }

        //SHOP
        void Shop_countrySelectedIndexChanged(object sender, EventArgs e)
        {
            shop_handleCountry();
        }
        void shop_handleCountry()
        {
            shop_subregion.SelectedIndex = 0;
            shop_subregion.Items.Clear();
            object[] a;
            switch (shop_country.SelectedIndex)
            {
                case 9:
                    a = new object[helper_subregion_argentina.Items.Count];
                    helper_subregion_argentina.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 12:
                    a = new object[helper_subregion_australia.Items.Count];
                    helper_subregion_australia.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 28:
                    a = new object[helper_subregion_brazil.Items.Count];
                    helper_subregion_brazil.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 36:
                    a = new object[helper_subregion_canada.Items.Count];
                    helper_subregion_canada.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 43:
                    a = new object[helper_subregion_china.Items.Count];
                    helper_subregion_china.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 72:
                    a = new object[helper_subregion_finland.Items.Count];
                    helper_subregion_finland.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 73:
                    a = new object[helper_subregion_france.Items.Count];
                    helper_subregion_france.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 79:
                    a = new object[helper_subregion_germany.Items.Count];
                    helper_subregion_germany.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 95:
                    a = new object[helper_subregion_india.Items.Count];
                    helper_subregion_india.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 102:
                    a = new object[helper_subregion_italy.Items.Count];
                    helper_subregion_italy.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 105:
                    a = new object[helper_subregion_japan.Items.Count];
                    helper_subregion_japan.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 155:
                    a = new object[helper_subregion_norway.Items.Count];
                    helper_subregion_norway.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 166:
                    a = new object[helper_subregion_poland.Items.Count];
                    helper_subregion_poland.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 174:
                    a = new object[helper_subregion_russia.Items.Count];
                    helper_subregion_russia.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 195:
                    a = new object[helper_subregion_spain.Items.Count];
                    helper_subregion_spain.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 200:
                    a = new object[helper_subregion_sweeden.Items.Count];
                    helper_subregion_sweeden.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 218:
                    a = new object[helper_subregion_england.Items.Count];
                    helper_subregion_england.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                case 220:
                    a = new object[helper_subregion_USA.Items.Count];
                    helper_subregion_USA.Items.CopyTo(a, 0);
                    shop_subregion.Items.AddRange(a);
                    break;
                default:
                    shop_subregion.Items.Add("0 无");
                    break;
            }
        }
        void load_shop()
        {

            shop_name.Text = ja.shop[(int)shop.Value].name;
            shop_shout.Text = ja.shop[(int)shop.Value].shout;
            shop_greeting.Text = ja.shop[(int)shop.Value].greeting;
            shop_farewell.Text = ja.shop[(int)shop.Value].farewell;
            shop_gender.SelectedIndex = ja.shop[(int)shop.Value].gender;

            shop_country.SelectedIndex = ja.shop[(int)shop.Value].country;
            shop_handleCountry();
            int i = 0;
            for (i = 0; i < country_subbed.Length; i++)
            {
                if (ja.shop[(int)shop.Value].country == country_subbed[i])
                    shop_subregion.SelectedIndex = ja.shop[(int)shop.Value].subregion;
            }
            shop_subregion.SelectedIndex = ja.shop[(int)shop.Value].subregion;
            shop_sprite.Value = ja.shop[(int)shop.Value].sprite;

            load_shop_sprite();

            shop_date.Value = ja.shop[(int)shop.Value].met;
            shop_recruit.Value = ja.shop[(int)shop.Value].recruitlvl;

            //  shop_type.SelectedIndex = ja.shop[(int)shop.Value].shop_version;//有报错 819
            shop_rank.SelectedIndex = ja.shop[(int)shop.Value].shop_level;
            shop_store.SelectedIndex = ja.shop[(int)shop.Value].shop_type;
            shop_exp.Value = ja.shop[(int)shop.Value].shop_exp;
            shop_ishuman.Checked = ja.shop[(int)shop.Value].isplayer;
            shop_inventory.Checked = ja.shop[(int)shop.Value].inventory;

            shop_debug.Text = ja.shop[(int)shop.Value].ShopBytes().ToString("X");

        }
        void set_shop()
        {
            ja.shop[(int)shop.Value].name = shop_name.Text;
            ja.shop[(int)shop.Value].shout = shop_shout.Text;
            ja.shop[(int)shop.Value].greeting = shop_greeting.Text;
            ja.shop[(int)shop.Value].farewell = shop_farewell.Text;
            ja.shop[(int)shop.Value].gender = shop_gender.SelectedIndex;


            ja.shop[(int)shop.Value].country = shop_country.SelectedIndex;
            ja.shop[(int)shop.Value].subregion = shop_subregion.SelectedIndex;
            ja.shop[(int)shop.Value].sprite = (int)shop_sprite.Value;
            ja.shop[(int)shop.Value].met = shop_date.Value;
            ja.shop[(int)shop.Value].recruitlvl = (int)shop_recruit.Value;

            ja.shop[(int)shop.Value].shop_version = shop_type.SelectedIndex;
            ja.shop[(int)shop.Value].shop_level = shop_rank.SelectedIndex;
            ja.shop[(int)shop.Value].shop_type = shop_store.SelectedIndex;
            ja.shop[(int)shop.Value].shop_exp = (int)shop_exp.Value;
            ja.shop[(int)shop.Value].isplayer = shop_ishuman.Checked;
            ja.shop[(int)shop.Value].inventory = shop_inventory.Checked;

            ja.shop[(int)shop.Value].set_ShopBytes();
        }
        void Shop_applyClick(object sender, EventArgs e)
        {
            set_shop();
        }
        void ShopValueChanged(object sender, EventArgs e)
        {
            load_shop();
        }
        void load_shop_sprite()
        {

            // Create a Bitmap object from a file.
            sprites_data = (Bitmap)WangPluginSav.Properties.Resources.all_sprites;
            if (((int)shop_sprite.Value) < 32)
            {
                cloneRect = new Rectangle((int)((shop_sprite.Value) * 32), 0, 32, 32);
            }
            else if (((int)shop_sprite.Value) < 64)
            {
                cloneRect = new Rectangle((int)((shop_sprite.Value - 32) * 32), 32, 32, 32);
            }
            else if (((int)shop_sprite.Value) < 96)
            {
                cloneRect = new Rectangle((int)((shop_sprite.Value - 64) * 32), 64, 32, 32);
            }
            else if (((int)shop_sprite.Value) < 128)
            {
                cloneRect = new Rectangle((int)((shop_sprite.Value - 96) * 32), 96, 32, 32);
            }
            else if (((int)shop_sprite.Value) < 160)
            {
                cloneRect = new Rectangle((int)((shop_sprite.Value - 128) * 32), 128, 32, 32);
            }
            else if (((int)shop_sprite.Value) < 192)
            {
                cloneRect = new Rectangle((int)((shop_sprite.Value - 160) * 32), 160, 32, 32);
            }
            else if (((int)shop_sprite.Value) < 224)
            {
                cloneRect = new Rectangle((int)((shop_sprite.Value - 192) * 32), 192, 32, 32);
            }
            else if (((int)shop_sprite.Value) < 256)
            {
                cloneRect = new Rectangle((int)((shop_sprite.Value - 224) * 32), 224, 32, 32);
            }


            cloneBitmap = sprites_data.Clone(cloneRect, sprites_data.PixelFormat);
            shop_pic.Image = cloneBitmap;
        }
        void Shop_spriteValueChanged(object sender, EventArgs e)
        {
            load_shop_sprite();
        }

        //VISITOR
        void Visitor_countrySelectedIndexChanged(object sender, EventArgs e)
        {
            visitor_handleCountry();
        }
        void visitor_handleCountry()
        {

            visitor_subregion.SelectedIndex = 0;
            visitor_subregion.Items.Clear();
            object[] a;
            switch (visitor_country.SelectedIndex)
            {
                case 9:
                    a = new object[helper_subregion_argentina.Items.Count];
                    helper_subregion_argentina.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 12:
                    a = new object[helper_subregion_australia.Items.Count];
                    helper_subregion_australia.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 28:
                    a = new object[helper_subregion_brazil.Items.Count];
                    helper_subregion_brazil.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 36:
                    a = new object[helper_subregion_canada.Items.Count];
                    helper_subregion_canada.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 43:
                    a = new object[helper_subregion_china.Items.Count];
                    helper_subregion_china.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 72:
                    a = new object[helper_subregion_finland.Items.Count];
                    helper_subregion_finland.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 73:
                    a = new object[helper_subregion_france.Items.Count];
                    helper_subregion_france.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 79:
                    a = new object[helper_subregion_germany.Items.Count];
                    helper_subregion_germany.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 95:
                    a = new object[helper_subregion_india.Items.Count];
                    helper_subregion_india.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 102:
                    a = new object[helper_subregion_italy.Items.Count];
                    helper_subregion_italy.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 105:
                    a = new object[helper_subregion_japan.Items.Count];
                    helper_subregion_japan.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 155:
                    a = new object[helper_subregion_norway.Items.Count];
                    helper_subregion_norway.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 166:
                    a = new object[helper_subregion_poland.Items.Count];
                    helper_subregion_poland.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 174:
                    a = new object[helper_subregion_russia.Items.Count];
                    helper_subregion_russia.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 195:
                    a = new object[helper_subregion_spain.Items.Count];
                    helper_subregion_spain.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 200:
                    a = new object[helper_subregion_sweeden.Items.Count];
                    helper_subregion_sweeden.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 218:
                    a = new object[helper_subregion_england.Items.Count];
                    helper_subregion_england.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                case 220:
                    a = new object[helper_subregion_USA.Items.Count];
                    helper_subregion_USA.Items.CopyTo(a, 0);
                    visitor_subregion.Items.AddRange(a);
                    break;
                default:
                    visitor_subregion.Items.Add("0 无");
                    break;
            }
        }
        int[] country_subbed = new int[]
        {
            009, 012, 028, 036, 043, 072, 073, 079, 095, 102,
            105, 155, 166, 174, 195, 200, 218, 220
        };
        void load_visitor()
        {

            visitor_name.Text = ja.visitor[(int)visitor.Value].name;
            visitor_shout.Text = ja.visitor[(int)visitor.Value].shout;
            visitor_greeting.Text = ja.visitor[(int)visitor.Value].greeting;
            visitor_farewell.Text = ja.visitor[(int)visitor.Value].farewell;
            visitor_gender.SelectedIndex = ja.visitor[(int)visitor.Value].gender;

            visitor_country.SelectedIndex = ja.visitor[(int)visitor.Value].country;
            visitor_handleCountry();
            int i = 0;
            for (i = 0; i < country_subbed.Length; i++)
            {
                if (ja.visitor[(int)visitor.Value].country == country_subbed[i])
                {
                    visitor_subregion.SelectedIndex = ja.visitor[(int)visitor.Value].subregion;
                    break;
                }
            }
            visitor_sprite.Value = ja.visitor[(int)visitor.Value].sprite;
            load_visitor_sprite();

            visitor_date.Value = ja.visitor[(int)visitor.Value].met;
            visitor_recruit.Value = ja.visitor[(int)visitor.Value].recruitlvl;

            visitor_ishuman.Checked = ja.visitor[(int)visitor.Value].isplayer;
        }
        void set_visitor()
        {
            ja.visitor[(int)visitor.Value].name = visitor_name.Text;
            ja.visitor[(int)visitor.Value].shout = visitor_shout.Text;
            ja.visitor[(int)visitor.Value].greeting = visitor_greeting.Text;
            ja.visitor[(int)visitor.Value].farewell = visitor_farewell.Text;
            ja.visitor[(int)visitor.Value].gender = visitor_gender.SelectedIndex;


            ja.visitor[(int)visitor.Value].country = visitor_country.SelectedIndex;
            ja.visitor[(int)visitor.Value].subregion = visitor_subregion.SelectedIndex;
            ja.visitor[(int)visitor.Value].sprite = (int)visitor_sprite.Value;
            ja.visitor[(int)visitor.Value].met = visitor_date.Value;
            ja.visitor[(int)visitor.Value].recruitlvl = (int)visitor_recruit.Value;

            ja.visitor[(int)visitor.Value].isplayer = visitor_ishuman.Checked;
        }
        void Visitor_applyClick(object sender, EventArgs e)
        {
            set_visitor();
        }
        void VisitorValueChanged(object sender, EventArgs e)
        {
            load_visitor();
        }
        void Visitor_importClick(object sender, EventArgs e)
        {
            AV_OCCUPANT import = new AV_OCCUPANT();
            string path = null;
            int filesize = FileIO.load_file(ref import.Data, ref path, "汇合大道顾客|*.pjv|所有文件(*.*)|*.*");
            if (filesize == 0xC4)
            {
                ja.set_visitor(import, (int)visitor.Value);
                ja.load_people();
                load_visitor();
            }
            else
            {
                MessageBox.Show("无效文件");
            }

        }
        void Visitor_exportClick(object sender, EventArgs e)
        {
            FileIO.save_file(ja.visitor[(int)visitor.Value].Data, "汇合大道顾客|*.pjv|所有文件(*.*)|*.*");
        }
        void load_visitor_sprite()
        {
            // Create a Bitmap object from a file.
            sprites_data = (Bitmap)WangPluginSav.Properties.Resources.all_sprites;
            if (((int)visitor_sprite.Value) < 32)
            {
                cloneRect = new Rectangle((int)((visitor_sprite.Value) * 32), 0, 32, 32);
            }
            else if (((int)visitor_sprite.Value) < 64)
            {
                cloneRect = new Rectangle((int)((visitor_sprite.Value - 32) * 32), 32, 32, 32);
            }
            else if (((int)visitor_sprite.Value) < 96)
            {
                cloneRect = new Rectangle((int)((visitor_sprite.Value - 64) * 32), 64, 32, 32);
            }
            else if (((int)visitor_sprite.Value) < 128)
            {
                cloneRect = new Rectangle((int)((visitor_sprite.Value - 96) * 32), 96, 32, 32);
            }
            else if (((int)visitor_sprite.Value) < 160)
            {
                cloneRect = new Rectangle((int)((visitor_sprite.Value - 128) * 32), 128, 32, 32);
            }
            else if (((int)visitor_sprite.Value) < 192)
            {
                cloneRect = new Rectangle((int)((visitor_sprite.Value - 160) * 32), 160, 32, 32);
            }
            else if (((int)visitor_sprite.Value) < 224)
            {
                cloneRect = new Rectangle((int)((visitor_sprite.Value - 192) * 32), 192, 32, 32);
            }
            else if (((int)visitor_sprite.Value) < 256)
            {
                cloneRect = new Rectangle((int)((visitor_sprite.Value - 224) * 32), 224, 32, 32);
            }


            cloneBitmap = sprites_data.Clone(cloneRect, sprites_data.PixelFormat);
            visitor_pic.Image = cloneBitmap;
        }

        public class AVENUE
        {
            internal int Size = BWToolMainForm.save.getBlockLength(67);//Block 67

            public byte[] Data;
            public AVENUE(byte[] data = null)
            {
                Data = data ?? new byte[Size];

                load_people();

            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }


            //Variables
            public AV_OCCUPANT[] visitor = new AV_OCCUPANT[8];
            public AV_OCCUPANT[] shop = new AV_OCCUPANT[8];
            public AV_NPC[] npc = new AV_NPC[12];
            public AV_HELPER[] helper = new AV_HELPER[4];

            //Visitors
            int VISITOR_SIZE = 0xC4;
            int VISITOR_OFFSET = 0x08;
            int VISITOR_TOTAL = 8 - 1;
            public AV_OCCUPANT get_visitor(int index)
            {
                if (index > VISITOR_TOTAL) index = VISITOR_TOTAL;
                return new AV_OCCUPANT(getData(VISITOR_OFFSET + (VISITOR_SIZE * index), VISITOR_SIZE));
            }
            public void set_visitor(AV_OCCUPANT visitant, int index)
            {
                if (index > VISITOR_TOTAL) index = VISITOR_TOTAL;
                setData(visitant.Data, VISITOR_OFFSET + (VISITOR_SIZE * index));
            }

            //NPC Fans
            int NPC_SIZE = 0x60;
            int NPC_OFFSET = 0x62C;
            int NPC_TOTAL = 12 - 1;
            public AV_NPC get_npc(int index)
            {
                if (index > NPC_TOTAL) index = NPC_TOTAL;
                return new AV_NPC(getData(NPC_OFFSET + (NPC_SIZE * index), NPC_SIZE));
            }
            public void set_npc(AV_NPC npc, int index)
            {
                if (index > NPC_TOTAL) index = NPC_TOTAL;
                setData(npc.Data, NPC_OFFSET + (NPC_SIZE * index));
            }

            //Occupants
            int OCCUPANT_SIZE = 0xC4;
            int OCCUPANT_OFFSET = 0xAAC;
            int OCCUPANT_TOTAL = 8 - 1;
            public AV_OCCUPANT get_occupant(int index)
            {
                if (index > OCCUPANT_TOTAL) index = OCCUPANT_TOTAL;
                return new AV_OCCUPANT(getData(OCCUPANT_OFFSET + (OCCUPANT_SIZE * index), OCCUPANT_SIZE));
            }
            public void set_occupant(AV_OCCUPANT occupant, int index)
            {
                if (index > OCCUPANT_TOTAL) index = OCCUPANT_TOTAL;
                setData(occupant.Data, OCCUPANT_OFFSET + (OCCUPANT_SIZE * index));
            }

            //Helpers
            int HELPER_SIZE = 0x58;
            int HELPER_OFFSET = 0x10CC;
            int HELPER_TOTAL = 4 - 1;
            public AV_HELPER get_helper(int index)
            {
                if (index > HELPER_TOTAL) index = HELPER_TOTAL;
                return new AV_HELPER(getData(HELPER_OFFSET + (HELPER_SIZE * index), HELPER_SIZE));
            }
            public void set_helper(AV_HELPER helper, int index)
            {
                if (index > HELPER_TOTAL) index = HELPER_TOTAL;
                setData(helper.Data, HELPER_OFFSET + (HELPER_SIZE * index));
            }

            public void load_people()
            {
                int i = 0;
                for (i = 0; i < 8; i++)
                {
                    visitor[i] = get_visitor(i);
                    shop[i] = get_occupant(i);
                }
                for (i = 0; i < 12; i++)
                {
                    npc[i] = get_npc(i);
                }
                for (i = 0; i < 4; i++)
                {
                    helper[i] = get_helper(i);
                }
            }
            public void set_people()
            {

                int i = 0;
                for (i = 0; i < 8; i++)
                {
                    set_visitor(visitor[i], i);
                    set_occupant(shop[i], i);
                }
                for (i = 0; i < 12; i++)
                {
                    set_npc(npc[i], i);
                }
                for (i = 0; i < 4; i++)
                {
                    set_helper(helper[i], i);
                }
            }

            public int rank
            {
                get { return (int)BitConverter.ToUInt16(getData(0x13CC, 2), 0); }
                set { setData(BitConverter.GetBytes((UInt16)value), 0x13CC); }
            }
            //00 Orange 01 Purple 02 Blue 03 Green
            public int color
            {
                get { return (int)BitConverter.ToUInt16(getData(0x13CE, 2), 0); }
                set { setData(BitConverter.GetBytes((UInt16)value), 0x13CE); }
            }


            //Helper functions from pkhex
            internal static string TrimFromFFFF(string input)
            {
                int index = input.IndexOf((char)0xFFFF);
                return index < 0 ? input : input.Substring(0, index);
            }
            public string fav_phrase
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12AC, 0x10))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0x10 / 2)
                        value = value.Substring(0, 0x10 / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12AC);
                }
            }
            public string imp_phrase
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12BC, 0x10))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0x10 / 2)
                        value = value.Substring(0, 0x10 / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12BC);
                }
            }
            public string name
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x12F4, 0x1A))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0x1A / 2)
                        value = value.Substring(0, 0x1A / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x12F4);
                }
            }
            public string title
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x131E, 0x10))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0x10 / 2)
                        value = value.Substring(0, 0x10 / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x131E);
                }
            }
            /*TO DO:
            START OFFSET: 23C00

            0x24E8C-0x24E9B - Player Trivia (set by avenue NPCs, see next post)
            0x24E9C-0x24EA7 - Player Activities (recent happenings to player ^)
            0x24EA8-0x24EAB - 00000000 (nothing, unused)
            0x24EAC - Your Favorite Phrase (0x10)
            0x24EBC - Your Impressed Phrase (0x10)
            0x24EF4 - Join Avenue's Name (11 characters + terminator, 0x18)
            0x24F1E - Your Title (0x10)
            */
        }

        public class AV_NPC
        {
            public byte[] Data;
            public AV_NPC(byte[] data = null)
            {
                Data = data ?? new byte[0x60];
            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }
            public string name
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
                }
            }
            public int gender
            {
                get
                {
                    if (Data[0x22] == 0x10)
                        return 1;
                    else
                        return 0;
                }
                set
                {
                    if (value == 1)
                        Data[0x22] = 0x10;
                    else
                        Data[0x22] = 0;
                }
            }
            public string text1
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x2C, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x2C);
                }
            }
            public string text2
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x3C, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x3C);
                }
            }
            public bool spoken
            {
                get
                {
                    if (Data[0x4F] == 1)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0x4F] = 1;
                    else
                        Data[0x4F] = 0;
                }
            }
            //Helper functions from pkhex
            internal static string TrimFromFFFF(string input)
            {
                int index = input.IndexOf((char)0xFFFF);
                return index < 0 ? input : input.Substring(0, index);
            }
        }
        public class AV_HELPER
        {
            public byte[] Data;
            public AV_HELPER(byte[] data = null)
            {
                Data = data ?? new byte[0x58];
            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }

            public string name
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
                }
            }
            public string text0
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x10, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x10);
                }
            }
            public string text1
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x34, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x34);
                }
            }
            public string text2
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x44, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x44);
                }
            }
            public int sprite
            {
                get
                {
                    return Data[0x2A];
                }
                set
                {
                    Data[0x2A] = (value > 0xFF ? (byte)0xFF : (byte)value);
                }
            }
            public int country
            {
                get
                {
                    return Data[0xE];
                }
                set
                {
                    Data[0xE] = (value > 0xFF ? (byte)0xFF : (byte)value);
                }
            }
            public int subregion
            {
                get
                {
                    return Data[0xF];
                }
                set
                {
                    Data[0xF] = (value > 0xFF ? (byte)0xFF : (byte)value);
                }
            }
            public DateTime met
            {
                get
                {
                    if (Data[0x30] != 0 && Data[0x31] != 0 && Data[0x32] != 0)
                        return new DateTime(2000 + Data[0x30], Data[0x31], Data[0x32]);
                    else
                        return new DateTime(2000, 1, 1);
                }
                set
                {
                    Data[0x30] = (byte)(value.Year - 2000);
                    Data[0x31] = (byte)value.Month;
                    Data[0x32] = (byte)value.Day;
                }
            }
            //Helper functions from pkhex
            internal static string TrimFromFFFF(string input)
            {
                int index = input.IndexOf((char)0xFFFF);
                return index < 0 ? input : input.Substring(0, index);
            }
        }
        public class AV_OCCUPANT
        {
            public byte[] Data;
            public AV_OCCUPANT(byte[] data = null)
            {
                Data = data ?? new byte[0xC4];
            }
            public byte[] getData(int Offset, int Length)
            {
                return Data.Skip(Offset).Take(Length).ToArray();
            }
            public void setData(byte[] input, int Offset)
            {
                input.CopyTo(Data, Offset);
            }

            public string name
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0);
                }
            }
            public int country
            {
                get
                {
                    return Data[0xE];
                }
                set
                {
                    Data[0xE] = (value > 0xFF ? (byte)0xFF : (byte)value);
                }
            }
            public int subregion
            {
                get
                {
                    return Data[0xF];
                }
                set
                {
                    Data[0xF] = (value > 0xFF ? (byte)0xFF : (byte)value);
                }
            }
            public string shout
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x10, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x10);
                }
            }
            public int gender
            {
                get
                {
                    if (Data[0x22] == 0x10)
                        return 1;
                    else
                        return 0;
                }
                set
                {
                    if (value == 1)
                        Data[0x22] = 0x10;
                    else
                        Data[0x22] = 0;
                }
            }
            public int sprite
            {
                get
                {
                    return Data[0x2A];
                }
                set
                {
                    Data[0x2A] = (value > 0xFF ? (byte)0xFF : (byte)value);
                }
            }
            public int recruitlvl
            {
                get
                {
                    return Data[0x2C];
                }
                set
                {
                    Data[0x2C] = (value > 0xFF ? (byte)0xFF : (byte)value);
                }
            }
            public string greeting
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x80, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x80);
                }
            }
            public string farewell
            {
                get
                {
                    return TrimFromFFFF(Encoding.Unicode.GetString(Data, 0x90, 0xE))
                        .Replace("\uE08F", "\u2640") // nidoran
                        .Replace("\uE08E", "\u2642") // nidoran
                        .Replace("\u2019", "\u0027"); // farfetch'd
                }
                set
                {
                    if (value.Length > 0xE / 2)
                        value = value.Substring(0, 0xE / 2); // Hard cap
                    string TempNick = value // Replace Special Characters and add Terminator
                        .Replace("\u2640", "\uE08F") // nidoran
                        .Replace("\u2642", "\uE08E") // nidoran
                        .Replace("\u0027", "\u2019") // farfetch'd
                        .PadRight(value.Length + 1, (char)0xFFFF); // Null Terminator
                    Encoding.Unicode.GetBytes(TempNick).CopyTo(Data, 0x90);
                }
            }
            public bool isplayer
            {
                get
                {
                    if (Data[0xA0] == 1)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0xA0] = (byte)1;
                    else
                        Data[0xA0] = (byte)0;
                }
            }
            public DateTime met
            {
                get
                {
                    if (Data[0xA3] != 0 && Data[0xA4] != 0 && Data[0xA5] != 0)
                        return new DateTime(2000 + Data[0xA3], Data[0xA4], Data[0xA5]);
                    else
                        return new DateTime(2000, 1, 1);
                }
                set
                {
                    Data[0xA3] = (byte)(value.Year - 2000);
                    Data[0xA4] = (byte)value.Month;
                    Data[0xA5] = (byte)value.Day;
                }
            }

            public int av_occupant_rank //Rank of player's own avenue, visitors use it. Disabled since not used in gui
            {
                get
                {
                    return Data[0xAB];
                }
                set
                {
                    Data[0xAB] = (value > 0xFF ? (byte)0xFF : (byte)value);
                }
            }

            public int shop_rank
            {
                get
                {
                    return Data[0xAD];
                }
                set
                {
                    Data[0xAD] = (value > 10 ? (byte)10 : (byte)value);
                }
            }

            public int shop_exp
            {
                get
                {
                    return BitConverter.ToUInt16(getData(0xAD, 2), 0);
                }
                set
                {
                    UInt16 exp = 0;
                    if (value > 0xFFFF)
                        exp = (UInt16)0xFFFF;
                    else
                        exp = (UInt16)value;
                    setData(BitConverter.GetBytes(exp), 0xAD);
                }
            }

            public bool inventory
            {
                get
                {
                    if (Data[0xB0] == 1)
                        return true;
                    else
                        return false;
                }
                set
                {
                    if (value == true)
                        Data[0xB0] = (byte)1;
                    else
                        Data[0xB0] = (byte)0;
                }
            }

            //Note: 0xB4 = FF when there's no shop

            public UInt16 ShopBytes()
            {
                return BitConverter.ToUInt16(getData(0xB4, 2), 0);
            }
            public void set_ShopBytes()
            {
                UInt16 bytes = (UInt16)(1 + Shop_version * 0x50 + Shop_type * 0xA + Shop_level);
                setData(BitConverter.GetBytes(bytes), 0xB4);
            }

            private int Shop_version;
            public int shop_version //0 black, 1 white, 2 black2, 3 white3
            {
                get
                {
                    return ShopBytes() / 0x50;
                }
                set
                {
                    if (value > 3)
                    {
                        Shop_version = 3;
                    }
                    else
                    {
                        Shop_version = value;
                    }
                }
            }
            private int Shop_level;
            public int shop_level // 0-9 (1-10)
            {
                get
                {
                    if (ShopBytes() % 0x50 == 0) //Last shop, level 10, remainder of negative number not correctly behaving...
                        return 9;
                    else
                        return (((ShopBytes() % 0x50) - 1) % 0xA);
                }
                set
                {
                    if (value > 0x9)
                        Shop_level = 0x9;
                    else
                        Shop_level = value;
                }
            }
            private int Shop_type;
            public int shop_type // 0=raffle, 1=salon, 2 = market, 3=florist, 4 = dojo, 5=nurse, 6=antique, 7=cafe
            {
                get
                {

                    if (shop_level == 9)
                    { //Level 10 gives problems... just consider it a level 9 shop for type return
                      //MessageBox.Show((ShopBytes() % 0x50).ToString() + "  -"+((ShopBytes() % 0x50)/0xA).ToString());
                        return (((ShopBytes() - 1) % 0x50) / 0xA);
                    }
                    else
                    {
                        return ((ShopBytes() % 0x50) / 0xA);
                    }
                    //
                    // return ((ShopBytes() % 0x50) / 0xA);
                }
                set
                {
                    if (value > 0x7)
                        Shop_type = 0x7;
                    else
                        Shop_type = value;
                }
            }

            //Helper functions from pkhex
            internal static string TrimFromFFFF(string input)
            {
                int index = input.IndexOf((char)0xFFFF);
                return index < 0 ? input : input.Substring(0, index);
            }
        }

        private void visitor_apply_Click(object sender, EventArgs e)
        {

        }
    }
}
