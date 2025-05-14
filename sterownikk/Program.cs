using System.Globalization;
using Opc.UaFx.Client;

namespace sterownikk
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}