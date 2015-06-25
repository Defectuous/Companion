using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using ArcheBuddy.Bot.Classes;

namespace DefaultNameSpace{
   public class DefaultClass : Core
   {
       public static string GetPluginAuthor()
       { return "Defectuous"; }
       public static string GetPluginVersion()
       { return "1.0.0.0"; }
       public static string GetPluginDescription()
       { return "ArcheBuddy Companion"; }

       //Call on plugin start
       public void PluginRun()
       {
       }
       //Call on plugin stop
       public void PluginStop()
       {
       }
   }
}
