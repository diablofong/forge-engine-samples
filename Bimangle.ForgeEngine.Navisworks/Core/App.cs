﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bimangle.ForgeEngine.Navisworks.Core
{
    static class App
    {
        public const string CLIENT_ID = @"BimAngle";
        public const string PRODUCT_NAME = @"Forge Engine Samples";

        public static LicenseSession CreateSession()
        {
            return new LicenseSession(CLIENT_ID, PRODUCT_NAME);
        }

        public static void ShowLicenseDialog(IWin32Window parent = null)
        {
            LicenseSession.ShowLicenseDialog(CLIENT_ID, PRODUCT_NAME, parent);
        }
    }
}
