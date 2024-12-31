using Emgu.CV;
using Emgu.CV.Stitching;

namespace ComputerVisionVizualizer
{
    internal static class Program
    {
        public static Dictionary<string, Mat> SavedImages;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new CvVisualizer());
        }
    }
}