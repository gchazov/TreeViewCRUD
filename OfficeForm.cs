using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CRUDTreeview
{
    public partial class OfficeForm : Form
    {
        //  Что делаем: добавляем или изменяем? 0 - добавляем
        int flag = 0;
        TreeNodeWithID treeNode;
        MainForm mf;
        public OfficeForm(int flag = 0, TreeNodeWithID treeNode = null, MainForm mf = null)
        {
            InitializeComponent();
            this.flag = flag;
            this.treeNode = treeNode;
            this.Text = flag == 0 ? "Добавление офиса" : "Изменение офиса";
            okBtn.Text = flag == 0 ? "Добавить" : "Изменить";
            cityName.Text = flag != 0 ? treeNode.Text : "";
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
                if (cityName.Text == "") throw new Exception();
                using (MySqlConnection connection = new MySqlConnection(DBconnection.connectionString))
                {
                    connection.Open();
                    using (MySqlCommand officecommand = connection.CreateCommand())
                    {
                        if (flag == 0)
                        {
                            officecommand.CommandText = $"INSERT INTO office (city_name) VALUES (\"{cityName.Text}\")";
                            officecommand.ExecuteNonQuery();
                            officecommand.CommandText = $"SELECT id FROM office where city_name = \"{cityName.Text}\"";
                            using (MySqlDataReader reader = officecommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    TreeNodeWithID node = new TreeNodeWithID(cityName.Text, (int)reader["id"], 1);
                                    node.ContextMenuStrip = mf.getOfficeMenu;
                                    node.ImageIndex = 0;
                                    node.SelectedImageIndex = 0;
                                    mf.getTree.Nodes.Add(node);
                                }
                            }
                        }
                        else
                        {
                            officecommand.CommandText = $"UPDATE office SET city_name = \"{cityName.Text}\" WHERE id = {treeNode.Id}";
                            officecommand.ExecuteNonQuery();
                            treeNode.Text = cityName.Text;
                        }
                    }
                }
                var city = cityName.Text;
                this.Close();
                //MessageBox.Show($"Данные об офисе в городе {city} успешно внесены в базу!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"{okBtn.Text} город офиса невозможно! Проверьте вводимые данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
