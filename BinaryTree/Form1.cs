namespace BinaryTree
{
    public partial class Form1 : Form
    {
        private BinaryTree tree = new BinaryTree();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtInput.Text, out value))
            {
                tree.Insert(value);
                MessageBox.Show("Value inserted.");
                txtInput.Clear();
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtInput.Text, out value))
            {
                tree.Delete(value);
                MessageBox.Show("Value deleted.");
                txtInput.Clear();
                this.Invalidate();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(txtInput.Text, out value))
            {
                bool found = tree.Search(value);
                string result = found ? "Value found." : "Value not found.";
                MessageBox.Show(result);
                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (tree.Root != null)
            {
                DrawTree(e.Graphics, tree.Root, this.Width / 2, 50, 100); 
            }
        }

        private void DrawTree(Graphics g, Node node, int x, int y, int offset)
        {
            if (node == null)
                return;

            g.FillEllipse(Brushes.LightBlue, x - 20, y - 20, 40, 40); 
            g.DrawString(node.Data.ToString(), new Font("Arial", 10), Brushes.Black, x - 10, y - 10); 

            
            if (node.Left != null)
            {
                g.DrawLine(Pens.Black, x, y, x - offset, y + 60); 
                DrawTree(g, node.Left, x - offset, y + 60, offset / 2); 
            }
            if (node.Right != null)
            {
                g.DrawLine(Pens.Black, x, y, x + offset, y + 60); 
                DrawTree(g, node.Right, x + offset, y + 60, offset / 2); 
            }
        }
    }
}
