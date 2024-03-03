using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TreeView = System.Windows.Forms.TreeView;

namespace CRUDTreeview
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            treeView.ContextMenuStrip = commonMenu;
            text.Text = "\tЗдесь появятся данные\rпосле нажатия кнопки загрузки";
            // Включаем возможность перетаскивания элементов в TreeView
            treeView.AllowDrop = true;
            treeView.ItemDrag += TreeView_ItemDrag;
            treeView.DragEnter += TreeView_DragEnter;
            treeView.DragDrop += TreeView_DragDrop;
        }

        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Проверяем, что перетаскиваемый элемент - это наш кастомный тип узла
            if (e.Item is TreeNodeWithID)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void TreeView_DragEnter(object sender, DragEventArgs e)
        {
            // Проверяем, что данные, которые мы перетаскиваем, соответствуют нашему кастомному типу узла
            if (e.Data.GetDataPresent(typeof(TreeNodeWithID)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TreeView_DragDrop(object sender, DragEventArgs e)
        {
            // Получаем перетаскиваемый узел из данных
            TreeNodeWithID draggedNode = (TreeNodeWithID)e.Data.GetData(typeof(TreeNodeWithID));

            // Получаем точку, в которую был брошен узел
            Point targetPoint = treeView.PointToClient(new Point(e.X, e.Y));

            // Получаем узел, над которым был брошен перетаскиваемый узел
            TreeNode targetNode = treeView.GetNodeAt(targetPoint);

            // Проверяем, не пытаемся ли перетащить узел на самого себя или на его потомка
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                // Удаляем узел из его текущего местоположения
                draggedNode.Remove();

                // Если целевой узел равен null, значит, узел был брошен вне TreeView
                if (targetNode == null)
                    treeView.Nodes.Add(draggedNode);
                else
                    targetNode.Nodes.Add(draggedNode);

                // Раскрываем родительский узел целевого узла, чтобы показать добавленный узел
                targetNode.Expand();
            }
        }

        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            // Проверяем, является ли node2 потомком node1
            if (node2 == null || node2.Parent == null)
                return false;
            if (node2.Parent.Equals(node1))
                return true;
            return ContainsNode(node1, node2.Parent);
        }

        public System.Windows.Forms.TreeView getTree
        {
            get { return treeView; }
            set { treeView = value; }
        }

        public ContextMenuStrip getOfficeMenu
        {
            get { return officeMenu; }
        }

        public ContextMenuStrip getTeamMenu
        {
            get { return teamMenu; }
        }

        public ContextMenuStrip getEmployeeMenu
        {
            get { return employeeMenu; }
        }


        private void load_btn_Click(object sender, EventArgs e)
        {
            text.Visible = false;
            treeView.Enabled = true;
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
                        TreeNodeWithID node = new TreeNodeWithID(reader["city_name"].ToString(), (int)reader["id"]);
                        node.ContextMenuStrip = officeMenu;
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

        private void LoadTeam(TreeNode parent, int officeId)
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
                            TreeNodeWithID node = new TreeNodeWithID(teamReader["name"].ToString(), (int)teamReader["id"]);
                            node.ContextMenuStrip = teamMenu;
                            parent.Nodes.Add(node);
                            LoadEmployee(node, (int)teamReader["id"]);
                        }
                    }
                }
            }
        }

        private void LoadEmployee(TreeNode parent, int teamId)
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
                            TreeNodeWithID node = new TreeNodeWithID(empReader["name"].ToString() + " " + empReader["surname"].ToString(), (int)empReader["id"]);
                            node.ContextMenuStrip = employeeMenu;
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

        private void deleteOffice(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы действительно хотите удалить данные об офисе {treeView.SelectedNode.Text}?",
                "Удаление офиса", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(DBconnection.connectionString))
                {
                    connection.Open();
                    using (MySqlCommand officecommand = connection.CreateCommand())
                    {
                        officecommand.CommandText = $"DELETE FROM office where id = {((TreeNodeWithID)treeView.SelectedNode).Id}";
                        officecommand.ExecuteNonQuery();
                    }
                }
                treeView.Nodes.Remove(treeView.SelectedNode);
            }
            else
            {

            }
            
        }

        private void addOffice(object sender, EventArgs e)
        {
            OfficeForm of = new OfficeForm(0, (TreeNodeWithID)treeView.SelectedNode, this);
            of.StartPosition = FormStartPosition.CenterParent;
            of.ShowDialog();
        }

        private void editoffice(object sender, EventArgs e)
        {
            OfficeForm of = new OfficeForm(1, (TreeNodeWithID)treeView.SelectedNode, this);
            of.StartPosition = FormStartPosition.CenterParent;
            of.ShowDialog();
        }

        private void deleteTeam(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы действительно хотите удалить данные о команде {treeView.SelectedNode.Text}?",
                "Удаление команды", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(DBconnection.connectionString))
                {
                    connection.Open();
                    using (MySqlCommand teamcommand = connection.CreateCommand())
                    {
                        teamcommand.CommandText = $"DELETE FROM team where id = {((TreeNodeWithID)treeView.SelectedNode).Id}";
                        teamcommand.ExecuteNonQuery();
                    }
                }
                treeView.Nodes.Remove(treeView.SelectedNode);
            }
            else
            {

            }
        }

        private void addTeam(object sender, EventArgs e)
        {
            TeamForm tf = new TeamForm(0, (TreeNodeWithID)treeView.SelectedNode, this);
            tf.StartPosition = FormStartPosition.CenterParent;
            tf.ShowDialog();
        }

        private void editTeam(object sender, EventArgs e)
        {
            TeamForm tf = new TeamForm(1, (TreeNodeWithID)treeView.SelectedNode, this);
            tf.StartPosition = FormStartPosition.CenterParent;
            tf.ShowDialog();
        }

        private void editEmployee(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm(1, (TreeNodeWithID)treeView.SelectedNode, this);
            ef.StartPosition = FormStartPosition.CenterParent;
            ef.ShowDialog();
        }

        private void addEmployee(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm(0, (TreeNodeWithID)treeView.SelectedNode, this);
            ef.StartPosition = FormStartPosition.CenterParent;
            ef.ShowDialog();
        }

        private void deleteEmployee(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Вы действительно хотите удалить данные о сотруднике {treeView.SelectedNode.Text}?",
                    "Удаление сотрудника", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(DBconnection.connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand employeecommand = connection.CreateCommand())
                        {
                            employeecommand.CommandText = $"DELETE FROM employee where id = {((TreeNodeWithID)treeView.SelectedNode).Id}";
                            employeecommand.ExecuteNonQuery();
                        }
                    }
                    treeView.Nodes.Remove(treeView.SelectedNode);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при удалении! Возможно, не был выбран элемент", "Ошибка");
            }
        }

    }
}
