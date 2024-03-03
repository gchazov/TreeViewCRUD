using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CRUDTreeview
{
    public partial class TeamForm : Form
    {
        //  Что делаем: добавляем или изменяем? 0 - добавляем
        int flag = 0;
        TreeNodeWithID treeNode;
        MainForm mf;
        public TeamForm(int flag = 0, TreeNodeWithID treeNode = null, MainForm mf = null)
        {
            InitializeComponent();
            this.flag = flag;
            this.treeNode = treeNode;
            this.Text = flag == 0 ? $"Добавление команды в офис {treeNode.Text}" : $"Изменение название команды в офисе {treeNode.Text}";
            okBtn.Text = flag == 0 ? "Добавить" : "Изменить";
            teamName.Text = flag != 0 ? treeNode.Text : "";
            this.mf = mf;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (teamName.Text == "") throw new Exception();
                using (MySqlConnection connection = new MySqlConnection(DBconnection.connectionString))
                {
                    connection.Open();
                    using (MySqlCommand teamcommand = connection.CreateCommand())
                    {
                        if (flag == 0)
                        {
                            teamcommand.CommandText = $"INSERT INTO team (name, office_id) VALUES (\"{teamName.Text}\", {treeNode.Id})";
                            teamcommand.ExecuteNonQuery();
                            teamcommand.CommandText = $"SELECT id FROM team where name = \"{teamName.Text}\"";
                            using (MySqlDataReader reader = teamcommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    TreeNodeWithID node = new TreeNodeWithID(teamName.Text, (int)reader["id"]);
                                    node.ContextMenuStrip = mf.getTeamMenu;
                                    treeNode.Nodes.Add(node);
                                }
                            }
                        }
                        else
                        {
                            teamcommand.CommandText = $"UPDATE team SET name = \"{teamName.Text}\" WHERE id = {treeNode.Id}";
                            teamcommand.ExecuteNonQuery();
                            treeNode.Text = teamName.Text;
                        }
                    }
                }
                var team = teamName.Text;
                this.Close();
                //MessageBox.Show($"Данные о команде {team} успешно внесены в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch
            {
                MessageBox.Show($"{okBtn.Text} команду невозможно! Проверьте вводимые данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
