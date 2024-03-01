using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDTreeview
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            DBconnection.Connect();
            treeView.Nodes.Clear();
            try
            {
                DBconnection.msCommand.CommandText = "SELECT id, city_name FROM office";
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                using (var reader = DBconnection.msCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TreeNode node = new TreeNode(reader["city_name"].ToString());
                        treeView.Nodes.Add(node);
                        LoadTeam(node, (int)reader["id"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void LoadTeam(TreeNode parent, int officeId)
        {
            using (MySqlConnection connection = new MySqlConnection(DBconnection.connectionString))
            {
                connection.Open();
                using (MySqlCommand teamCommand = connection.CreateCommand())
                {
                    teamCommand.CommandText = $"SELECT id, name, office_id FROM team where office_id = {officeId}";
                    using (MySqlDataReader teamReader = teamCommand.ExecuteReader())
                    {
                        while (teamReader.Read())
                        {
                            TreeNode node = new TreeNode(teamReader["name"].ToString());
                            parent.Nodes.Add(node);
                            LoadEmployee(node, (int)teamReader["id"]);
                        }
                    }
                }
            }
        }

        private static void LoadEmployee(TreeNode parent, int teamId)
        {
            using (MySqlConnection connection = new MySqlConnection(DBconnection.connectionString))
            {
                connection.Open();
                using (MySqlCommand empCommand = connection.CreateCommand())
                {
                    empCommand.CommandText = $"SELECT id, name, surname, team_id FROM employee where team_id = {teamId}";
                    using (MySqlDataReader empReader = empCommand.ExecuteReader())
                    {
                        while (empReader.Read())
                        {
                            TreeNode node = new TreeNode(empReader["name"].ToString() + " " + empReader["surname"].ToString());
                            parent.Nodes.Add(node);
                        }
                    }
                }
            }
        }

        private void dropDown_Click(object sender, EventArgs e)
        {
            treeView.ExpandAll();
        }

        private void rollUp_Click(object sender, EventArgs e)
        {
            treeView.CollapseAll();
        }
    }
}
