using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDTreeview
{
    public class TreeNodeWithID : TreeNode
    {
        int id;
        int level;
        public int Id
        {
            get { return id; }
        } 

        public int NodeLevel
        {
            get { return level; }
        }
        public TreeNodeWithID(string name, int id_code, int level_val) : base(name)
        {
            this.id = id_code;
            this.level = level_val;
        }
    }
}
