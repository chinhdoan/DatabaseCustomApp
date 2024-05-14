using System.Runtime.CompilerServices;

namespace DatabaseManagement
{
    public partial class Form1 : Form
    {
        int thuocTinhClickCount;
        int currentThuocTinhClickCount;
        int initialPosX = 40;
        int initialPosY = 220;

        int kieuDlClickCount;
        int currentkieuDlClickCount;
        int initialPosX2 = 270;
        int initialPosY2 = 220;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button newButton = new Button();
            this.Controls.Add(newButton);
            newButton.Text = "Created Button";
            newButton.Location = new Point(90, 136);
            newButton.Size = new Size(121, 23);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            currentThuocTinhClickCount = thuocTinhClickCount;
            thuocTinhClickCount++;
            if (thuocTinhClickCount > currentThuocTinhClickCount)
            {
                newCustomForm(initialPosX, initialPosY);
                initialPosY += 30;
            }

        }
        public void newCustomForm(int sizeX, int sizeY)
        {

            TextBox newTxtBox = new TextBox();
            this.Controls.Add(newTxtBox);
            newTxtBox.Name = "textBox7";
            newTxtBox.Location = new Point(sizeX, sizeY);
            newTxtBox.Size = new Size(100, 23);
            newTxtBox.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentkieuDlClickCount = kieuDlClickCount;
            kieuDlClickCount++;
            if (kieuDlClickCount > currentkieuDlClickCount)
            {
                newCustomForm(initialPosX2, initialPosY2);
                initialPosY2 += 30;
            }
        }
    }
}