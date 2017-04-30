using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLibrary;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private TicTacToeEngine engine = new TicTacToeEngine();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            String message;
            Button button = (Button)sender;
            button.Text = engine.setPos();
            message = engine.determineWinner(button1.Text, button2.Text, button3.Text, button4.Text, button5.Text, button6.Text, button7.Text, button8.Text, button9.Text);
            if (message != null)
            {
                MessageBox.Show(message);
                resetAll();
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void resetAll()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            engine.reset();
        }
    }
}
