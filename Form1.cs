using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    public partial class Form1 : Form
    {
        //Trust Server; Integrated Security=True ODER
        //User und Passwort angeben
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=NB2405\SQLEXPRESS;Initial Catalog=PM;Integrated Security=True;TrustServerCertificate=True");
            
        public Form1()
        {
            InitializeComponent();
            getGeschlecht();
        }

        private void getGeschlecht()
        {
            geschlechtDropdown.Items.Clear();
//------Methode aulagern-----------------------------------------------------------------------------
            databaseConnection.Open();
            string query = "SELECT Geschlecht_lang FROM Geschlecht";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            databaseConnection.Close();
//---------------------------------------------------------------------------------------------------
            foreach(DataRow row in dataSet.Tables[0].Rows)
            {
                geschlechtDropdown.Items.Add(row["Geschlecht_lang"].ToString());
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showMitarbeiter();            
        }

        private DataSet getMitarbeiterTable()
        {
            databaseConnection.Open();
            string query = "SELECT M.ID_Mitarbeiter, M.Vorname, M.Nachname, G.Geschlecht_lang FROM Mitarbeiter M inner join Geschlecht G ON G.ID_Geschlecht = M.ID_Geschlecht";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);


            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);          

            databaseConnection.Close();
            return dataSet;
        }

        private void showMitarbeiter()
        {
            //Zugriff auf DataGridView; die Tabelle, die auf der nullten Stelle steht (es können auch mehrere Tabellen sein)
            MitarbeiterDB.DataSource = getMitarbeiterTable().Tables[0];
            MitarbeiterDB.Columns[0].Visible = false;
        }

//------Mitarbeiter einpflegen:
        private void btnSaveMitarbeiter_Click(object sender, EventArgs e)
        {
            string vorname = vornameInput.Text;
            string nachname =  nachnameInput.Text;
            int geschlecht = 0;
            if (geschlechtDropdown.SelectedIndex == 0) 
            {
                geschlecht = 0;
            }
            else if(geschlechtDropdown.SelectedIndex == 1)
            {
                geschlecht = 1;
            }
            else 
            {
                geschlecht = 2;
            }

            if(vornameInput.Text != "" && nachnameInput.Text != "" && geschlechtDropdown.SelectedIndex >= 0)
            {
                databaseConnection.Open();
                //string.Format->damit die Werte übergeben werden können
                string query = string.Format("insert into Mitarbeiter(Vorname, Nachname, ID_Geschlecht) values ('{0}', '{1}', '{2}')", vorname, nachname, geschlecht) ;
                SqlCommand cmd = new SqlCommand(query, databaseConnection);
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }

            showMitarbeiter();
            clearInput();
            
        }

//------Inputfelder leeren
        private void clearInput()
        {
            vornameInput.Text = "";
            nachnameInput.Text = "";
            geschlechtDropdown.SelectedIndex = -1;
        }

        private void btnClearMitarbeiter_Click(object sender, EventArgs e)
        {
            clearInput();
        }

//------Mitarbeiter auswählen
        private void MitarbeiterDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vornameInput.Text = MitarbeiterDB.SelectedRows[0].Cells[1].Value.ToString();
            nachnameInput.Text = MitarbeiterDB.SelectedRows[0].Cells[2].Value.ToString();
            geschlechtDropdown.Text = MitarbeiterDB.SelectedRows[0].Cells[3].Value.ToString();
        }

//------Mitarbeiter bearbeiten
        private void btnChangeMitarbeiter_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(MitarbeiterDB.SelectedRows[0].Cells[0].Value);
            string vorname = vornameInput.Text;
            string nachname = nachnameInput.Text;
            int geschlecht = 0;
            if (geschlechtDropdown.SelectedIndex == 0)
            {
                geschlecht = 0;
            }
            else if (geschlechtDropdown.SelectedIndex == 1)
            {
                geschlecht = 1;
            }
            else
            {
                geschlecht = 2;
            }

            if (vornameInput.Text != "" && nachnameInput.Text != "" && geschlechtDropdown.SelectedIndex >= 0)
            {
                databaseConnection.Open();
                string query = string.Format("UPDATE Mitarbeiter SET Vorname = '{0}', Nachname = '{1}', ID_Geschlecht = '{2}' WHERE ID_Mitarbeiter = '{3}'", vorname, nachname, geschlecht, id);

                //string.Format->damit die Werte übergeben werden können
                string query2 = string.Format("insert into Mitarbeiter(Vorname, Nachname, ID_Geschlecht) values ('{0}', '{1}', '{2}')", vorname, nachname, geschlecht);
                SqlCommand cmd = new SqlCommand(query, databaseConnection);
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }

            showMitarbeiter();
        }

        //------Mitarbeiter löschen
        private void btnDeleteMitarbeiter_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(MitarbeiterDB.SelectedRows[0].Cells[0].Value);
            if (id>0)
            {
                
            }

            showMitarbeiter();
            clearInput();
        }
    }
}
