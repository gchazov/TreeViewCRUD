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
        public int Id
        {
            get { return id; }
        } 
        public TreeNodeWithID(string name, int id_code) : base(name)
        {
            this.id = id_code;
        }
    }
}
