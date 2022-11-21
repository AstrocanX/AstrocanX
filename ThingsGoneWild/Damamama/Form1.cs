using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Damamama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


           
            Button[,] buttons = new Button[8, 8];
            int up = 0;
            int left = 0;
            
            for (int i = 0; i < 7; i++)
            {

                for (int j = 0; j < 7; i++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Top = up;
                    buttons[i, j].Left = left;
                    left += 50;
                    this.Controls.Add(buttons[i, j]);
                }
                up += 50;
                left = 0;
            
            }
            

            
            
            

        }
    }
}
