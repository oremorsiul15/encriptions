using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace encriptions
{
    //arreglar 5 valores similares
    public partial class encriptions : Form
    {
        
        // set to code or decode mode
        bool code = false;
        // password key
        int key = 0;
        // input in a char array
        char[] input;
        //functions var
        int valueof = 0;
        char valueof1 = ' ';


        public encriptions()
        {
            InitializeComponent();
        }

      

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //mode coding
            code = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //mode decode
            code = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            progressBar1.Maximum = inputTb.Text.Length;
            outputTb.Text = "";
            //getting key textbox value
            try
            {
                key = Convert.ToInt32(keyTb.Text);
                input = (inputTb.Text).ToCharArray();
                string keytest = (key * 37).ToString();
                //checking that key don't exeed 8 digits
                if ( keytest.Length >= 8 || key == 0)
                {
                    MessageBox.Show("Invalid Key");
                    keyTb.Text = "";
                    return;
                }
            }
            catch
            {
                //error handler
                MessageBox.Show("unable to get input or key");
                return;
            }
            if (code == true)
            {
                string first = "";
                string second = "";
                for (int i = 0; i < inputTb.Text.Length; i++)
                {
                  
                    first = (InputValue(input[i])*key).ToString("00000000");
                    second = second + first;
                    progressBar1.Value++;
                }
                outputTb.Text = second;
            }
            else if (code == false)
            {
                Decode();
            }
            else
            {
                
            }
        }

        private int InputValue(char charval)
        {

            switch (charval)
            {
                case 'a':
                    {
                        valueof = 1;
                        break;
                    }
                case 'b':
                    {
                        valueof = 2;
                        break;
                    }
                case 'c':
                    {
                        valueof = 3;
                        break;
                    }
                case 'd':
                    {
                        valueof = 4;
                        break;
                    }
                case 'e':
                    {
                        valueof = 5;
                        break;
                    }
                case 'f':
                    {
                        valueof = 6;
                        break;
                    }
                case 'g':
                    {
                        valueof = 7;
                        break;
                    }
                case 'h':
                    {
                        valueof = 8;
                        break;
                    }
                case 'i':
                    {
                        valueof = 9;
                        break;
                    }
                case 'j':
                    {
                        valueof = 10;
                        break;
                    }
                case 'k':
                    {
                        valueof = 11;
                        break;
                    }
                case 'l':
                    {
                        valueof = 12;
                        break;
                    }
                case 'm':
                    {
                        valueof = 13;
                        break;
                    }
                case 'n':
                    {
                        valueof = 14;
                        break;
                    }
                case 'o':
                    {
                        valueof = 15;
                        break;
                    }
                case 'p':
                    {
                        valueof = 16;
                        break;
                    }
                case 'q':
                    {
                        valueof = 17;
                        break;
                    }
                case 'r':
                    {
                        valueof = 18;
                        break;
                    }
                case 's':
                    {
                        valueof = 19;
                        break;
                    }
                case 't':
                    {
                        valueof = 20;
                        break;
                    }
                case 'u':
                    {
                        valueof = 21;
                        break;
                    }
                case 'v':
                    {
                        valueof = 22;
                        break;
                    }
                case 'w':
                    {
                        valueof = 23;
                        break;
                    }
                case 'x':
                    {
                        valueof = 24;
                        break;
                    }
                case 'y':
                    {
                        valueof = 25;
                        break;
                    }
                case 'z':
                    {
                        valueof = 26;
                        break;
                    }
                case '.':
                    {
                        valueof = 27;
                        break;
                    }
                case ',':
                    {
                        valueof = 28;
                        break;
                    }
                case '0':
                    {
                        valueof = 29;
                        break;
                    }
                case '1':
                    {
                        valueof = 30;
                        break;
                    }
                case '2':
                    {
                        valueof = 31;
                        break;
                    }
                case '3':
                    {
                        valueof = 32;
                        break;
                    }
                case '4':
                    {
                        valueof = 33;
                        break;
                    }
                case '5':
                    {
                        valueof = 27;
                        break;
                    }
                case '6':
                    {
                        valueof = 34;
                        break;
                    }
                case '7':
                    {
                        valueof = 35;
                        break;
                    }
                case '8':
                    {
                        valueof = 36;
                        break;
                    }
                case '9':
                    {
                        valueof = 37;
                        break;
                    }
                default:
                    {
                        valueof = 0;
                        break;
                    }



            }
            return valueof;
        }

        private char outputValue(int charval)
        {

            switch (charval)
            {
                case 1:
                    {
                        valueof1 = 'a';
                        break;
                    }
                case 2:
                    {
                        valueof1 = 'b';
                        break;
                    }
                case 3:
                    {
                        valueof1 = 'c' ;
                        break;
                    }
                case 4:
                    {
                        valueof1 = 'd';
                        break;
                    }
                case 5:
                    {
                        valueof1 = 'e';
                        break;
                    }
                case 6:
                    {
                        valueof1 = 'f' ;
                        break;
                    }
                case 7:
                    {
                        valueof1 = 'g';
                        break;
                    }
                case 8:
                    {
                        valueof1 = 'h';
                        break;
                    }
                case 9:
                    {
                        valueof1 = 'i';
                        break;
                    }
                case 10:
                    {
                        valueof1 = 'j';
                        break;
                    }
                case 11:
                    {
                        valueof1 = 'k';
                        break;
                    }
                case 12:
                    {
                        valueof1 = 'l';
                        break;
                    }
                case 13:
                    {
                        valueof1 = 'm';
                        break;
                    }
                case 14:
                    {
                        valueof1 = 'n';
                        break;
                    }
                case 15:
                    {
                        valueof1 = 'o';
                        break;
                    }
                case 16:
                    {
                        valueof1 = 'p';
                        break;
                    }
                case 17:
                    {
                        valueof1 = 'q';
                        break;
                    }
                case 18:
                    {
                        valueof1 = 'r';
                        break;
                    }
                case 19:
                    {
                        valueof1 = 's';
                        break;
                    }
                case 20:
                    {
                        valueof1 = 't';
                        break;
                    }
                case 21:
                    {
                        valueof1 = 'u';
                        break;
                    }
                case 22:
                    {
                        valueof1 = 'v';
                        break;
                    }
                case 23:
                    {
                        valueof1 = 'w';
                        break;
                    }
                case 24:
                    {
                        valueof1 = 'x';
                        break;
                    }
                case 25:
                    {
                        valueof1 = 'y';
                        break;
                    }
                case 26:
                    {
                        valueof1 = 'z';
                        break;
                    }
                case 27:
                    {
                        valueof1 = '.';
                        break;
                    }
                case 28:
                    {
                        valueof1 = ',';
                        break;
                    }
                case 29:
                    {
                        valueof1 = '0';
                        break;
                    }
                case 30:
                    {
                        valueof1 = '1';
                        break;
                    }
                case 31:
                    {
                        valueof1 = '2';
                        break;
                    }
                case 32:
                    {
                        valueof1 = '3';
                        break;
                    }
                case 33:
                    {
                        valueof1 = '4';
                        break;
                    }
                case 34:
                    {
                        valueof1 = '5';
                        break;
                    }
                case 35:
                    {
                        valueof1 = '6';
                        break;
                    }
                case 36:
                    {
                        valueof1 = '7';
                        break;
                    }
                case 37:
                    {
                        valueof1 = '8';
                        break;
                    }
                case 38:
                    {
                        valueof1 = '9';
                        break;
                    }
                default:
                    {
                        valueof1 = ' ';
                        break;
                    }



            }
            return valueof1;
        }
        private void Decode()
        {
            string first = "";
            int third = 0;
            string f4 = "";
            int hold = 0;
            for (int j = 0; j < inputTb.Text.Length/8;j++)
            {
                first = input[j*hold + 0].ToString() + input[j * hold + 1].ToString() + input[j * hold + 2].ToString() + input[j * hold + 3].ToString() + input[j * hold + 4].ToString() + input[j * hold + 5].ToString() + input[j * hold + 6].ToString() + input[j * hold + 7].ToString();
                hold = 8;
                try
                {
                    third = Convert.ToInt32(first);
                 }
                  catch
                  {
                      MessageBox.Show("not a decodeable input");
                      return;
                  }
                progressBar1.Value+= 8;
                f4 = f4 + outputValue(third/key).ToString();
            }
            outputTb.Text = f4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            inputTb.Clear();
            outputTb.Clear();
            keyTb.Clear();
            
        }
    }
}
