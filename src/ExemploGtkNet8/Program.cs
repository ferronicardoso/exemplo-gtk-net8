using System;
using Gtk;

namespace ExemploGtkNet8
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.ExemploGtkNet8.ExemploGtkNet8", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            var win = new frmMain();
            app.AddWindow(win);
            
            win.Show();
            Application.Run();
        }
    }
}