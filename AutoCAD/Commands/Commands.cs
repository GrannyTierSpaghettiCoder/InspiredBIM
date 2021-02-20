﻿using inBIM.AutoCAD.Singleton;
using AAR = Autodesk.AutoCAD.Runtime;

namespace inBIM.AutoCAD.Commands
{
    public class Commands
    {
        public const string PALETTESET_COMMAND = "AWESOME_APP";

        [AAR.CommandMethod(PALETTESET_COMMAND)]
        public void ShowPaletteSet()
        {
            PaletteSet.Current.Load();
        }
    }
}