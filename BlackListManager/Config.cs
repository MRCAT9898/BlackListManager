using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace BlackListManager
{
    public class Config : IConfig
    {
        [Description("Pl Main")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Black List")] 
        public static List<string> BlackList { get; set; } = new List<string>()
        {
            "BadWord1",
            "BadWord2",
            "BadWord3"
        };
    }
}