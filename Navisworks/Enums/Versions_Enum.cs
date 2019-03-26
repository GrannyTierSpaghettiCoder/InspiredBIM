using System.ComponentModel;

namespace inBIM.Navisworks.Enums
{
    public enum Versions
    {
        None = -1,

        [Description("Navisworks Freedom")]
        Freedom = 0,

        [Description("Navisworks Simulate")]
        Simulate = 1,

        [Description("Navisworks Manage")]
        Manage = 2,
    }
}