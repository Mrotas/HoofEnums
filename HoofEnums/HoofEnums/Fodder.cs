using System.ComponentModel;

namespace HoofEnums
{
    public enum Fodder
    {
        [Description("Sucha")]
        Dry = 1,

        [Description("Soczysta")]
        Juicy = 2,

        [Description("Treściwa")]
        Pithy = 3,

        [Description("Sól")]
        Salt = 4
    }
}
