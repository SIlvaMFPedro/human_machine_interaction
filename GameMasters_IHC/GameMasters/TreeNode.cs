using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBubbles
{
    class TreeNode
    {
        public string Name { get; set; }
        public List<TreeNode> childNodes { get; set; }
        public List<TreeNode> items { get; set; }

        // this is the magic method!
        public TreeNode Search(Func<TreeNode, bool> predicate)
        {
            // if node is a leaf
            if (this.childNodes == null || this.childNodes.Count == 0)
            {
                if (predicate(this))
                    return this;
                else
                    return null;
            }
            else // Otherwise if node is not a leaf
            {
                var results = childNodes
                                  .Select(i => i.Search(predicate))
                                  .Where(i => i != null).ToList();

                if (results.Any())
                {
                    var result = (TreeNode)MemberwiseClone();
                    result.items = results; 
                    return result;
                }
                return null;
            }
        }
    }
}
