using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace KontoApp
{
    public partial class Form1 : Form
    {
        // SQL Initialisieren
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private BindingSource bindingSource = new BindingSource();
        private DataTable table = new DataTable();
        private SaveFileDialog saveFileDialog = new SaveFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_CreateAccount_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            dataAdapter.Update((DataTable)bindingSource.DataSource);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Daten Laden
            dataGridView.DataSource = bindingSource;
            GetData("select * from AccountData");
        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Verbindungsdaten spezifieren
                string connectionString = "Data Source=WIN10-DW2\\SQLEXPRESS;Initial Catalog=Accounts;Integrated Security=True";

                // SQL Adapter
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Befehlsersteller für SQL commands (update insert delete)
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Datentabelle populieren und an die BindingSource binden
                table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };

                dataAdapter.Fill(table);

                DataColumnCollection spalten = table.Columns;

                foreach(DataColumn spalte in spalten)
                {
                    MessageBox.Show(spalte.ColumnName);
                }

                bindingSource.DataSource = table;

                // Testen
                // dataGridView.AutoResizeColumn((int)DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            } catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Verbindung fehlgeschlaften");
            }
        }

        private void Btn_CsvExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Comma Seperated Values | *.csv";
            saveFileDialog.ShowDialog();
            string filename = saveFileDialog.FileName;
            table.ToCSV(filename);
            // table.FromCSV(@"c:\users\dw2\desktop\");
        }
    }
}
