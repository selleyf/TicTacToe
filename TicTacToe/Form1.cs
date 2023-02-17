using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private Int32 full; //A tábla beteltségét mérő változó
        private List<List<Button>> _Buttons; //Játéktábla = Gombmátrix



        public Form1()
        {
            InitializeComponent();
        }

        private void NewGame(decimal Size) //Új játék
        {
            
            if (_Buttons != null) //Ha már vannak gombok, azokat letörli
            {
                for (int i = 0; i < _Buttons.Count; i++)
                    for (int j = 0; j < _Buttons[i].Count; j++)
                        Controls.Remove(_Buttons[i][j]);

            }

            _Buttons = new List<List<Button>>();

            full = Convert.ToInt32(Size) * Convert.ToInt32(Size);


            for (int i = 0; i < Size; i++)
            {
                _Buttons.Add(new List<Button>());

                for (int j = 0; j < Size; j++)
                {
                    _Buttons[i].Add(new System.Windows.Forms.Button());


                    _Buttons[i][j].Location = new System.Drawing.Point(12 + j * 20, 150 + i * 20);

                    _Buttons[i][j].Name = "button" + i.ToString() + j.ToString();

                    _Buttons[i][j].Size = new System.Drawing.Size(20, 20);

                    _Buttons[i][j].Text = "";
                    _Buttons[i][j].BackColor = Color.White;

                    Controls.Add(_Buttons[i][j]);

                    if (i == Size - 1)
                    {
                        _Buttons[i][j].Click += new System.EventHandler(Button_Click); //Legalsó sor eseménykezelője
                    }
                    else
                    {
                        _Buttons[i][j].Click += new System.EventHandler(Button_Click2); //Többi sor eseménykezelője
                    }


                }
            }

            switch (Convert.ToInt32(Size)) //Ablak átméretezése
            {

                case 10:
                    this.Width = Convert.ToInt32(100 + 40 * Size);
                    this.Height = Convert.ToInt32(100 + 30 * Size);
                    break;

                case 20:
                    this.Width = Convert.ToInt32(100 + 20 * Size);
                    this.Height = Convert.ToInt32(100 + 25 * Size);
                    break;

                case 30:
                    this.Width = Convert.ToInt32(100 + 18 * Size);
                    this.Height = Convert.ToInt32(110 + 23 * Size);
                    break;

            }
        }

        private void Check() //Ellenőrzi, hogy nyert-e valamelyik játékos
        {
            for (int i = 0; i < _Size.Value; i++) //Vízszintes 4 ellenőrzése
            {
                for (int j = 3; j < _Size.Value; j++)
                {

                    if (_Buttons[i][j].Text == "X" && _Buttons[i][j - 1].Text == "X" && _Buttons[i][j - 2].Text == "X"
                        && _Buttons[i][j - 3].Text == "X")
                    {
                        _Buttons[i][j].BackColor = Color.Red;
                        _Buttons[i][j - 1].BackColor = Color.Red;
                        _Buttons[i][j - 2].BackColor = Color.Red;
                        _Buttons[i][j - 3].BackColor = Color.Red;
                        MessageBox.Show("1. játékos nyert.", "Játék vége!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                        return;
                    }

                    if (_Buttons[i][j].Text == "O" && _Buttons[i][j - 1].Text == "O" && _Buttons[i][j - 2].Text == "O"
                        && _Buttons[i][j - 3].Text == "O")
                    {
                        _Buttons[i][j].BackColor = Color.Green;
                        _Buttons[i][j - 1].BackColor = Color.Green;
                        _Buttons[i][j - 2].BackColor = Color.Green;
                        _Buttons[i][j - 3].BackColor = Color.Green;
                        MessageBox.Show("2. játékos nyert.", "Játék vége!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                        return;
                    }



                }

                for (int k = 3; k < _Size.Value; k++) //Jobbra dőlő átlós 4 ellenőrzése
                {
                    for (int l = 0; l < _Size.Value - 4; l++) 
                    {

                        if (_Buttons[k][l].Text == "X" && _Buttons[k - 1][l + 1].Text == "X" && _Buttons[k - 2][l + 2].Text == "X"
                            && _Buttons[k - 3][l + 3].Text == "X")
                        {
                            _Buttons[k][l].BackColor = Color.Red;
                            _Buttons[k - 1][l + 1].BackColor = Color.Red;
                            _Buttons[k - 2][l + 2].BackColor = Color.Red;
                            _Buttons[k - 3][l + 3].BackColor = Color.Red;
                            MessageBox.Show("1. játékos nyert.", "Játék vége!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                            return;
                        }

                        if (_Buttons[k][l].Text == "O" && _Buttons[k - 1][l + 1].Text == "O" && _Buttons[k - 2][l + 2].Text == "O"
                            && _Buttons[k - 3][l + 3].Text == "O")
                        {
                            _Buttons[k][l].BackColor = Color.Green;
                            _Buttons[k - 1][l + 1].BackColor = Color.Green;
                            _Buttons[k - 2][l + 2].BackColor = Color.Green;
                            _Buttons[k - 3][l + 3].BackColor = Color.Green;
                            MessageBox.Show("2. játékos nyert.", "Játék vége!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                            return;
                        }



                    }
                }

                for (int r = 3; r < _Size.Value; r++) //Balra dőlő átlós 4 ellenőrzése
                {
                    for (int s = 3; s < _Size.Value; s++)
                    {

                        if (_Buttons[r][s].Text == "X" && _Buttons[r - 1][s - 1].Text == "X" && _Buttons[r - 2][s - 2].Text == "X"
                            && _Buttons[r - 3][s - 3].Text == "X")
                        {
                            _Buttons[r][s].BackColor = Color.Red;
                            _Buttons[r - 1][s - 1].BackColor = Color.Red;
                            _Buttons[r - 2][s - 2].BackColor = Color.Red;
                            _Buttons[r - 3][s - 3].BackColor = Color.Red;
                            MessageBox.Show("1. játékos nyert.", "Játék vége!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                            return;
                        }

                        if (_Buttons[r][s].Text == "O" && _Buttons[r - 1][s - 1].Text == "O" && _Buttons[r - 2][s - 2].Text == "O"
                            && _Buttons[r - 3][r - 3].Text == "O")
                        {
                            _Buttons[r][s].BackColor = Color.Green;
                            _Buttons[r - 1][s - 1].BackColor = Color.Green;
                            _Buttons[r - 2][s - 2].BackColor = Color.Green;
                            _Buttons[r - 3][s - 3].BackColor = Color.Green;
                            MessageBox.Show("2. játékos nyert.", "Játék vége!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                            return;
                        }

                    }
                }
            }
        }

        private void SaveGame(String fileName) //Játék elmentése
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(_Size.Value);
            for (Int32 i = 0; i < _Size.Value; i++)
            {
                for (Int32 j = 0; j < _Size.Value; j++)
                    writer.Write(_Buttons[i][j].Text + " ");
                writer.WriteLine();
            }
            writer.Close();
        }

        private void LoadGame(String fileName) // játék betöltése
        {
            StreamReader reader = new StreamReader(fileName);

            String[] tablesize = reader.ReadLine().Split(' ');
            decimal _TableSize = Convert.ToDecimal(tablesize[0]);

            NewGame(_TableSize);

            for (Int32 i = 1; i < _TableSize; i++)
            {
                String[] data = reader.ReadLine().Split(' '); 
                for (Int32 j = 0; j < _TableSize; j++)
                {
                    _Buttons[i][j].Text = data[j];
                    
                }
            }
            reader.Close();

        }


        //Gombok eseménykezelői

        private void _ButtonSize_Click(object sender, EventArgs e) //Méretváltás gomb
        {
            NewGame(_Size.Value);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void Button_Click(Object sender, EventArgs e) //Legalsó sor eseménykezelője
        {
            switch (radioButton1.Checked)
            {
                case true:
                    if ((sender as Button).Text == "")
                    {
                        (sender as Button).Text = "X";
                        full--;
                        if (full == 0)
                        {
                            MessageBox.Show("Döntetlen.", "Játék vége!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;
                    }
                    break;

                case false:
                    if ((sender as Button).Text == "")
                    {
                        (sender as Button).Text = "O";
                        full--;
                        if (full == 0)
                        {
                            MessageBox.Show("Döntetlen.", "Játék vége!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                        radioButton2.Checked = false;
                        radioButton1.Checked = true;
                    }
                    break;
            }

            Check(); 

        }

        

        private void Button_Click2(Object sender, EventArgs e) //Többi gomb eseménykezelője
        {

            for (int j = 0; j < _Size.Value; j++)
            {
                for (int i = 0; i < _Size.Value; i++)
                {
                    if (_Buttons[i][j] == sender)
                    {
                        if (_Buttons[i + 1][j].Text != "")
                        {
                            Button_Click(sender, e);
                            return;
                        }
                    }
                }
            }

        }

       //Menü eseménykezelői

        private void _NewGame2_Click(object sender, EventArgs e) //Új játék
        {
            if (_Buttons != null) //Ha már vannak gombok, azokat letörli
            {
                for (int i = 0; i < _Buttons.Count; i++)
                    for (int j = 0; j < _Buttons[i].Count; j++)
                        Controls.Remove(_Buttons[i][j]);

            }

            this.Width = Convert.ToInt32(500); //És nagyjából a kezdőállapotira méretezi az ablakot
            this.Height = Convert.ToInt32(200);

        }

        private void _MenuSaveGame_Click(object sender, EventArgs e) //Játék mentése
        {
            if (_SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveGame(_SaveFileDialog.FileName);
                }
                catch (IOException)
                {
                    MessageBox.Show("Játék mentése sikertelen!" + Environment.NewLine + "Hibás az elérési út, vagy a könyvtár nem írható.", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _MenuLoadGame_Click(object sender, EventArgs e) //Játék betöltése
        {
            if (_OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadGame(_OpenFileDialog.FileName);
                }
                catch (IOException)
                {
                    MessageBox.Show("Játék betöltése sikertelen!" + Environment.NewLine + "Hibás az elérési út, vagy a fájlformátum.", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _CloseGame_Click(object sender, EventArgs e) //Játék bezárása
        {
            Application.Exit();
        }

   
    }
}
