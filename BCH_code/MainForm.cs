using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCH_code
{
    public partial class MainForm : Form
    {
        private int nparam, kparam;
        private string pol, inputNumbers;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tb_poll.Enabled = false;
            numericUpDown_n.Enabled = false;
            numericUpDown_k.Enabled = false;

            string[] codes = { "(7,4)", "(7,3)", "Другие" };
            cb_codeParams.Items.AddRange(codes);

            string[] polls = { "1011", "11101", "Другой" };
            cb_poll.Items.AddRange(polls);
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_codeParams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((String)cb_codeParams.SelectedItem == "Другие")
            {
                numericUpDown_n.Enabled = true;
                numericUpDown_k.Enabled = true;
            }
            else
            {
                numericUpDown_n.Enabled = false;
                numericUpDown_k.Enabled = false;
            }
        }

        private void cb_poll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((String)cb_poll.SelectedItem == "Другой")
                tb_poll.Enabled = true;
            else
                numericUpDown_n.Enabled = true;
        }

        private void btn_code_Click(object sender, EventArgs e)
        {
            if (Input())
            {
                Coder coder = new Coder(nparam, kparam, pol, inputNumbers);

                coder.CreateInfoCombinations();

                Dictionary<int, BitArray> dicLoc = coder.Dic;

                for (int i = 0; i < dicLoc.Count; i++)
                {
                    lb_codedCombinations.Items.Add(coder.ToBitString(dicLoc.Values.ElementAt(i)));
                }
            }
        }

        bool Input()
        {
            try
            {
                if ((String)cb_codeParams.SelectedItem != "Другие")
                {
                    string codeParams = (String)cb_codeParams.SelectedItem;
                    nparam = Convert.ToInt32(codeParams[1].ToString());
                    kparam = Convert.ToInt32(codeParams[3].ToString());
                }
                else
                {
                    nparam = Convert.ToInt32(numericUpDown_n.Value);
                    kparam = Convert.ToInt32(numericUpDown_k.Value);
                }

                if ((String)cb_poll.SelectedItem != "Другой")
                    pol = (String)cb_poll.SelectedItem;
                else
                    pol = tb_poll.Text;

                inputNumbers = tb_numOfInfoCombinations.Text;

                if (nparam == 0 || kparam == 0 || pol == "" || pol == "0" || inputNumbers == "")
                {
                    throw new Exception();
                }
                else return true;
            }
            catch
            {
                MessageBox.Show("Некорректный ввод данных", "БЧХ коды", MessageBoxButtons.OK, MessageBoxIcon.None);
                return false;
            }
        }
    }
}
