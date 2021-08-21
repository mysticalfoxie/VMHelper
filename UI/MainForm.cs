using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioProcessHelper.Services;

namespace AudioProcessHelper.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeData();
            MapEvents();
        }

        private void InitializeData()
        {
            foreach (var process in ConfigService.Load().Processes)
            {
                var index = _processList.Items.Add(process.Name);
                _processList.SetItemChecked(index, process.Checked);
            }
        }

        private void MapEvents()
        {
            _startButton.Click += OnStart;
            _addButton.Click += OnAdd;
            _removeButton.Click += OnRemove;
            _processList.SelectedValueChanged += OnCheckedChange;
            _processNameInput.GotFocus += OnInputFocus;
        }

        private void OnCheckedChange(object sender, EventArgs e)
        {
            var session = _processList.ReadSession();
            ConfigService.Save(session);
        }

        private void OnInputFocus(object sender, EventArgs e)
        {
            var processes = Process.GetProcesses().Select(x => x.ProcessName).ToArray();
            _processNameInput.AutoCompleteCustomSource.Clear();
            _processNameInput.AutoCompleteCustomSource.AddRange(processes);
        }

        private void OnRemove(object sender, EventArgs e)
        {
            if (_processList.SelectedIndex == -1) return;

            _processList.Items.RemoveAt(_processList.SelectedIndex);

            var session = _processList.ReadSession();
            ConfigService.Save(session);
        }

        private void OnAdd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_processNameInput.Text)) return;

            var index = _processList.Items.Add(_processNameInput.Text.Trim());
            _processList.SetItemChecked(index, true);

            var session = _processList.ReadSession();
            ConfigService.Save(session);

            _processNameInput.Text = string.Empty;
        }

        private void OnStart(object sender, EventArgs e)
        {
            Disable();

            StartHandled(() =>
            {
                var names = _processList.CheckedItems.Cast<string>().ToArray();
                var processes = ProcessService.GetProcesses(names);
                ProcessService.IncreasePriority(processes);
                ProcessService.SetAffinity(processes);
                var result = MessageBox.Show($"Perfect! Everything done!\nShould I leave now? 😁\n\nOk: Stay! Please!\nCancel: We're done here!", "Done!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Cancel)
                    LeaveTheRoomCrying();
            });

            Enable();
        }

        private static void StartHandled(Action action)
        {
            try 
                {
                action();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured when trying change your processes.\n\n{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LeaveTheRoomCrying()
        {
            _description.Text = "😭";
            _description.TextAlign = ContentAlignment.MiddleCenter;
            _description.Font = new Font("Segoe UI", 100, FontStyle.Regular, GraphicsUnit.Pixel);
            Task.Delay(2000).Wait();
            Application.Exit();
        }

        private void Disable()
        {
            _processList.Enabled = false;
            _processNameInput.Enabled = false;
            _addButton.Enabled = false;
            _removeButton.Enabled = false;
            _startButton.Enabled = false;
        }

        private void Enable()
        {
            _processList.Enabled = true;
            _processNameInput.Enabled = true;
            _addButton.Enabled = true;
            _removeButton.Enabled = true;
            _startButton.Enabled = true;
        }
    }
}
