using ComputerVisionVizualizer.Controls;
using Emgu.CV;
using System.Diagnostics;
using System.Reflection;

namespace ComputerVisionVizualizer
{

    public partial class CvVisualizer : Form
    {
        private void AddOperation<T>(T control) where T : CVIOBase
            => tabs.TabPages[tabs.SelectedIndex].Controls
                                                        .OfType<TableLayoutPanel>()
                                                        .First()
                                                        .Controls.Add(control);

        public CvVisualizer()
        {
            InitializeComponent();

            tabs.TabPages[0].Text = "main";
            var newOperationsPanel = new TableLayoutPanel() { ColumnCount = 1, Size = new Size(840, 520), AutoScroll = true };
            tabs.TabPages[0].Controls.Add(newOperationsPanel);

            var cvControls = GetType().Assembly.GetTypes();
            foreach (var cvControl in cvControls)
            {
                if (!cvControl.IsSubclassOf(typeof(CVIOBase))) continue;

                //var button = new Button() { Text = cvControl.GetCustomAttribute<CVIOBase.CvControlDisplayNameAttribute>()?.Name ?? cvControl.Name, AutoSize = true };
                Button button = new Button() { Text = "lol", AutoSize = true };

                button.Click += (s, e) => AddOperation((CVIOBase)Activator.CreateInstance(cvControl));

                buttonList.Controls.Add(button);
            }
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            tabs.TabPages.Add(new TabPage("new tab") { BackColor = Color.White });
            var newOperationsPanel = new TableLayoutPanel() { ColumnCount = 1, Size = new Size(840, 520), AutoScroll = true };
            tabs.TabPages[tabs.TabPages.Count - 1].Controls.Add(newOperationsPanel);
        }

        private void CloseTabButton_Click(object sender, EventArgs e)
        {
            if (tabs.TabPages.Count > 0) tabs.TabPages.Remove(tabs.TabPages[tabs.SelectedIndex]);
        }

        private void TransformationButton_Click(object sender, EventArgs e)
        {
            var tablePanel = tabs.TabPages[tabs.SelectedIndex].Controls.OfType<TableLayoutPanel>().Last();
            tablePanel.Controls.Add(new Transformaion());
        }

        private void TabName_TextChanged(object sender, EventArgs e) => tabs.TabPages[tabs.SelectedIndex].Text = TabName.Text;
    }
}
