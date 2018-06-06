using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System;
using static Simple_Injector.Logger;

namespace Simple_Injector
{
    public partial class Interface : Form, IStatusLogger
    {
        private readonly DataTable _processTable = new DataTable("processTable");
       
        private string _dllPath;

        private bool _closeAfterInject;

        private bool _autoInject;
        
        private Injector _injector;
        
        public Interface()
        {
            InitializeComponent();
        }

        public void LogStatus(string status)
        {
            // Display the status

            StatusLabel.Text += status + Environment.NewLine + Environment.NewLine;
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            InitializeDataTable();

            // Set the datasource of the datagrid

            processDataGrid.DataSource = _processTable;

            PopulateDataTable();

            // Sort the processes

            processDataGrid.Sort(processDataGrid.Columns["Name"], ListSortDirection.Ascending);
            
            // Create an instance of Injector
            
            _injector = new Injector(this);
        }

        private void InitializeDataTable()
        {
            // Add columns to datatable

            _processTable.Columns.Add("Name", typeof(string));
        }

        private void PopulateDataTable()
        {
            // Populate the datatable

            var processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                _processTable.Rows.Add(process.ProcessName);
            }

        }

        private void ProcessDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the process that has been clicked

            var process = processDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Set the text of SelectedProcessTextBox to the process name

            selectedProcessTextBox.Text = Convert.ToString(process.FormattedValue);

            // If _autoInject is true and a dll has been chosen then inject
            
            if (_autoInject & dllFileTextBox.Text.Length > 1)
            {
                // Get the chosen process
                
                var processName = selectedProcessTextBox.Text;

                _injector.Inject(processName, _dllPath);
                
                // Close the injector if _closeAfterInject is true
            
                if (_closeAfterInject)
                {
                    Application.Exit();
                }
            }

        }

        private void ChooseDLLButton_Click(object sender, EventArgs e)
        {
            // Open a file dialog

            FileDialog.ShowDialog();

            // Get the file path of the chosen dll

            var dll = _dllPath = FileDialog.FileName;

            // Set the text of DLLFileTextBox to the dll name

            dllFileTextBox.Text = Path.GetFileNameWithoutExtension(dll);
            
            // If _autoInject is true and a dll has been chosen then inject
            
            if (_autoInject & selectedProcessTextBox.Text.Length > 1)
            {
                // Get the chosen process
                
                var processName = selectedProcessTextBox.Text;

                _injector.Inject(processName, _dllPath);
                
                // Close the injector if _closeAfterInject is true
            
                if (_closeAfterInject)
                {
                    Application.Exit();
                }
            }
        }

        private void InjectDLLButton_Click(object sender, EventArgs e)
        {
            // Get the chosen process

            var processName = selectedProcessTextBox.Text;

            if (dllFileTextBox.Text.Length > 0 && selectedProcessTextBox.Text.Length > 0)
            {
                // Only inject if a process and a DLL file is chosen
                
                _injector.Inject(processName, _dllPath);
                
                // Close the injector if _closeAfterInject is true
            
                if (_closeAfterInject)
                {
                    Application.Exit();
                }
            }

            else
            {
                // Notify user that they need to select a process and a DLL file
                
                MessageBox.Show(@"Ensure a process and DLL file is chosen"); 
            }
        }

        private void CloseAfterInjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _closeAfterInject = closeAfterInjectCheckBox.Checked;
        }

        private void AutoInjectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _autoInject = autoInjectCheckBox.Checked;
        }
    }
}
