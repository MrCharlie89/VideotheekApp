﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VideotheekApp.LIB.DATA;

namespace VideotheekApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        AppDBContext ctx = AppDBContext.Instance(System.Configuration.ConfigurationManager.ConnectionStrings["Videotheek"].ConnectionString);
    }
}
