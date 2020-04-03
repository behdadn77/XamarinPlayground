using System;
using System.Collections.Generic;
using System.Text;

namespace App4
{
    public static class ApplicationStatics
    {
        public static string DBLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
                + @"\FartDB.sqlite";
    }
}
