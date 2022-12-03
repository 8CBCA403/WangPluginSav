using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WangPluginSav.WangDataBase
{
    public enum NV
    {
        [Description("进度1")]
        one,
        [Description("进度2")]
        two,
        [Description("进度3")]
        three,
        [Description("进度4")]
        four,
        [Description("进度5")]
        five,
    }
    public enum EV
    {
        [Description("进度1")]
        one,
        [Description("进度2")]
        two,
        [Description("进度3")]
        three,
        [Description("进度4")]
        four,
    }
    public enum Step
    {
        ADDone,
        Random,
    }
    public enum GameN
    {
        Scarlet,
        Violet,
    }
    public enum star
    {
        one,
        two,
        three,
        four,
        five,
        six,
    }
    public enum Gend
    {
        Male = 0,
        Female = 1,
        Genderless = 2,
        Random = 3
    }
}
