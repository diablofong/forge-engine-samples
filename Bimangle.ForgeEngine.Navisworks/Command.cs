﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Navisworks.Api.Plugins;
using Bimangle.ForgeEngine.Navisworks.Config;
using Bimangle.ForgeEngine.Navisworks.Core;
using Bimangle.ForgeEngine.Navisworks.UI;

namespace Bimangle.ForgeEngine.Navisworks
{
    [Plugin(@"Bimangle.ForgeEngine.Sample", @"Bimangle",
        DisplayName = @"Export To Svfzip",
        ExtendedToolTip = @"Export To Svfzip",
        Options = PluginOptions.SupportsControls,
        ToolTip = @"Export To Svfzip"
    )]
    [AddInPlugin(AddInLocation.Export)]
    public class Command : AddInPlugin
    {
        public const string TITLE = @"Bimangle.ForgeEngine.Sample";

        #region Overrides of AddInPlugin

        public override int Execute(params string[] parameters)
        {
            var mainWindow = Autodesk.Navisworks.Api.Application.Gui.MainWindow;
            var appConfig = AppConfigManager.Load();

            var dialog = new FormExportSvfzip(appConfig);
            dialog.ShowDialog(mainWindow);

            return 0;
        }

        #endregion
    }
}
