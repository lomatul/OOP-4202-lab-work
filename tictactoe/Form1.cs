using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int a, b, c, d, f, g, h, i, j;
        public int q = 0, r = 0;
        public int auto;
        public int m = 0, n = 0;
        bool p = false;

        private void button_reset_Click(object sender, EventArgs e)
        {
            m = 0;
            r = 0;
            n = 0;
            q = 0;

            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button18.Text = string.Empty;
            button3.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button9.Text = string.Empty;
            button16.Text = string.Empty;
            button17.Text = string.Empty;
            label_player1.Text = string.Empty;
            label_player2.Text = string.Empty;
            label_draw.Text = string.Empty;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Text = string.Empty;
            button2.Text = string.Empty;
            button18.Text = string.Empty;
            button3.Text = string.Empty;
            button5.Text = string.Empty;
            button6.Text = string.Empty;
            button9.Text = string.Empty;
            button16.Text = string.Empty;
            button17.Text = string.Empty;

           
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           

            if (p==false)
            {
                button1.Text = "X";
                
                p = true;
                
                a = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                }
            }
            else
            {
                button1.Text = "0";
                p = false;
               
                a = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                }
            }

           

            if (a==1 && b==1 && c==1)
            {
              
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;

                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 1 && d == 1 && h == 1)
            {
               
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 1 && f == 1 && j == 1)
            {
                
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;

                label_player1.Text = Convert.ToString(q);

                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && b == 2 && c == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && d == 2 && h == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && f == 2 && j == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }

        }

      

        private void button16_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                button16.Text = "X";
                p = true;
                d = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                  
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                }
            }
            else
            {
                button16.Text = "0";
                p = false;
                d = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                }
            }

           
            if (d == 1 && f == 1 && g== 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;

                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }

            if (a == 1 && d == 1 && h == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && d == 2 && h == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (d == 2 && f == 2 && g == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (p == false)
            {
                button2.Text = "X";
                p = true;
                h = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                }

            }
            else
            {
                button2.Text = "0";
                p = false;
                h = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                }

            }

            //h = 1;
            //MessageBox.Show("Now player 2's Turn");
            if (h == 1 && i == 1 && j == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (h == 2 && i == 2 && j == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }

            if (a == 1 && d == 1 && h == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 1 && f == 1 && h == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 2 && f == 2 && h == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && d == 2 && h == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
        }

      

        private void button6_Click(object sender, EventArgs e)
        {
            

            if (p == false)
            {
                button6.Text = "X";
                p = true;
                b = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                }
            }
            else  
            {
                button6.Text = "0";
                p = false;
                b = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                }
            }
           // b = 1;
           // MessageBox.Show("Now player 2's Turn");

            if (a == 1 && b == 1 && c == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (b == 1 && f == 1 && i == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && b == 2 && c == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (b == 2 && f == 2 && i == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }

        }

     
        private void button5_Click(object sender, EventArgs e)
        {
          
            if (p == false)
            {
                button5.Text = "X";
                p = true;
                f = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                }
            }
            else
            {
                button5.Text = "0";
                p = false;
                f = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                }
            }

          
            if (d == 1 && f == 1 && g == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (d == 2 && f == 2 && g == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (b == 1 && f == 1 && i == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (b == 2 && f == 2 && i == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 1 && f == 1 && j == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 1 && f == 1 && h == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 2 && f == 2 && h == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(q);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && f == 2 && j == 2)
            {

                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(q);

                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }

        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (p == false)
            {
                button3.Text = "X";
                p = true;
                i = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                   
                }
            }
            else
            {
                button3.Text = "0";
                p = false;
                i = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                   
                }
            }

          //  i = 1;
           // MessageBox.Show("Now player 2's Turn");
            if (h == 1 && i == 1 && j == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (b == 1 && f == 1 && i == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (h == 2 && i == 2 && j == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (b == 2 && f == 2 && i == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
        }

        

        private void button18_Click(object sender, EventArgs e)
        {
            //label5.Text = "X";
            

            if (p == false)
            {
                button18.Text = "X";
                p = true;
                c = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                }
            }
            else
            {
                button18.Text = "0";
                p = false;
                c = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                }
            }

            //c = 1;
           // MessageBox.Show("Now player 2's Turn");
            if (a == 1 && b == 1 && c == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 1 && g == 1 && j == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                 a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 1 && f == 1 && h == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && b == 2 && c == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 2 && g == 2 && j == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
        }

       

        private void button17_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                button17.Text = "X";
                p = true;
                g = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                }
            }
            else
            {
                button17.Text = "0";
                p = false;
                g = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                }
            }

           // g = 1;

            //MessageBox.Show("Now player 2's Turn");

            if (d == 1 && f == 1 && g == 1)
            {
                q = q + 1;
                m = 0;
                 a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 1 && g == 1 && j == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (d == 2 && f == 2 && g == 2)
            {
                r = r + 1;
                m = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 2 && g == 2 && j == 2)
            {
                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            if (p == false)
            {
                button9.Text = "X";
                p = true;
                j = 1;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 2's Turn");
                }
            }
            else
            {
                button9.Text = "0";
                p = false;
                j = 2;
                m = m + 1;
                if (m == 9)
                {
                    MessageBox.Show("DRAW");
                    n = n + 1;
                    a = 0;
                    b = 0;
                    c = 0;
                    d = 0;
                    f = 0;
                    g = 0;
                    h = 0;
                    i = 0;
                    j = 0;
                    label_draw.Text = Convert.ToString(n);
                    button1.Text = string.Empty;
                    button2.Text = string.Empty;
                    button18.Text = string.Empty;
                    button3.Text = string.Empty;
                    button5.Text = string.Empty;
                    button6.Text = string.Empty;
                    button9.Text = string.Empty;
                    button16.Text = string.Empty;
                    button17.Text = string.Empty;
                }

                else
                {
                    MessageBox.Show("Now player 1's Turn");
                }
            }

            //j = 1;
           // MessageBox.Show("Now player 2's Turn");

            if (h == 1 && i == 1 && j == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 1 && g == 1 && j == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
                if (a == 1 && f == 1 && j == 1)
            {
                q = q + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player1.Text = Convert.ToString(q);
                MessageBox.Show("Player 1 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (a == 2 && f == 2 && j == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (h == 2 && i == 2 && j == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
            if (c == 2 && g == 2 && j == 2)
            {

                r = r + 1;
                m = 0;
                n = 0;
                a = 0;
                b = 0;
                c = 0;
                d = 0;
                f = 0;
                g = 0;
                h = 0;
                i = 0;
                j = 0;
                label_player2.Text = Convert.ToString(r);
                MessageBox.Show("Player 2 wins");
                button1.Text = string.Empty;
                button2.Text = string.Empty;
                button18.Text = string.Empty;
                button3.Text = string.Empty;
                button5.Text = string.Empty;
                button6.Text = string.Empty;
                button9.Text = string.Empty;
                button16.Text = string.Empty;
                button17.Text = string.Empty;
            }
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
