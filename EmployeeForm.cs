using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CRUDTreeview
{
    public partial class EmployeeForm : Form
    {
        //  Что делаем: добавляем или изменяем? 0 - добавляем
        int flag = 0;
        TreeNodeWithID treeNode;
        MainForm mf;
        public EmployeeForm(int flag = 0, TreeNodeWithID treeNode = null, MainForm mf = null)
        {
            InitializeComponent();
            this.flag = flag;
            this.treeNode = treeNode;
            this.Text = flag == 0 ? $"Добавление сотрудника в команду {treeNode.Text}" : $"Изменение сотрудника в команде {treeNode.Text}";
            okBtn.Text = flag == 0 ? "Добавить" : "Изменить";
            name.Text = flag != 0 ? treeNode.Text : "";
            surname.Text = flag != 0 ? treeNode.Text : "";
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
                if (name.Text == "" || surname.Text == "")
                {
                    throw new Exception("Имя и фамилия обязательны для заполнения");
                }

                using (MySqlConnection connection = new MySqlConnection(DBconnection.connectionString))
                {
                    connection.Open();
                    using (MySqlCommand employeecommand = connection.CreateCommand())
                    {
                        if (flag == 0)
                        {
                            employeecommand.CommandText = $"SELECT * FROM employee WHERE name = \"{name.Text}\" AND surname = \"{surname.Text}\" AND team_id = {treeNode.Id}";
                            using (var qry_res = employeecommand.ExecuteReader())
                            {
                                if (qry_res.HasRows)
                                {
                                    throw new Exception("Сотрудник с таким именем и фамилией уже существует в этой команде");
                                }
                            }

                            employeecommand.CommandText = $"INSERT INTO employee (name, surname, team_id) VALUES (\"{name.Text}\", \"{surname.Text}\", {treeNode.Id})";
                            employeecommand.ExecuteNonQuery();

                            employeecommand.CommandText = $"SELECT id FROM employee where name = \"{name.Text}\" AND surname = \"{surname.Text}\" AND team_id = {treeNode.Id}";
                            using (MySqlDataReader reader = employeecommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    TreeNodeWithID node = new TreeNodeWithID(name.Text + " " + surname.Text, (int)reader["id"]);
                                    node.ContextMenuStrip = mf.getEmployeeMenu;
                                    treeNode.Nodes.Add(node);
                                }
                            }
                        }
                        else
                        {
                            employeecommand.CommandText = $"UPDATE employee SET name = \"{name.Text}\", surname = \"{surname.Text}\" WHERE id = {treeNode.Id}";
                            employeecommand.ExecuteNonQuery();
                            treeNode.Text = name.Text + " " + surname.Text;
                        }
                    }
                }
                var employee = name.Text + " " + surname.Text;
                this.Close();
                //MessageBox.Show($"Данные о сотруднике {employee} успешно внесены в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch
            {
                MessageBox.Show($"{okBtn.Text} данные о сотруднике невозможно! Проверьте вводимые данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
