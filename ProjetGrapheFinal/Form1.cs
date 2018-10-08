using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGrapheFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<String> ls = new List<string>();
        public String path = "le chemin le plus cours est de passer par ";

        private void Form1_Load(object sender, EventArgs e)
        {
            raoued.Visible = false;
            marsa.Visible = false;
            goulette.Visible = false;
            tunis.Visible = false;
            ariana.Visible = false;
            menzah.Visible = false;
            lac.Visible = false;
            carthage.Visible = false;
            sokra.Visible = false;
            ain_zaghouane.Visible = false;
            borj_louzir.Visible = false;
            gammarth.Visible = false;
        }

        private void CheminBtn_Click(object sender, EventArgs e)
        {
            Boolean state = false;
            int[] preD = new int[12];
            int min = 999, nextNode = 0; // min holds the minimum value, nextNode holds the value for the next node.
            //scan = new Scanner(System.in);
            int[] distance = new int[12]; // the distance matrix
            int[,] matrix = new int[12, 12]; // the actual matrix
            int[] visited = new int[12]; // the visited array
            Console.WriteLine("Enter the cost matrix");
            for (int i = 0; i < distance.Length; i++)
            {
                visited[i] = 0; //initialize visited array to zeros
                preD[i] = 0;
                for (int a = 0; a < distance.Length; a++)
                {
                    matrix[i, a] = 0; //fill the matrix
                    if (matrix[i, a] == 0)
                    {
                        matrix[i, a] = 999; // make the zeros as 999
                    }
                }
            }
            if (comboBox3.Text.Trim().Equals("MATIN"))
            {
                MessageBox.Show(comboBox3.Text);
                matrix[0, 1] = 1;
                matrix[1, 0] = 1;
                matrix[0, 4] = 1;
                matrix[4, 0] = 1;
                matrix[0, 5] = 1;
                matrix[5, 0] = 1;
                matrix[1, 2] = 3;
                matrix[2, 1] = 3;
                matrix[2, 3] = 6;
                matrix[3, 2] = 6;
                matrix[3, 8] = 9;
                matrix[8, 3] = 9;
                matrix[4, 7] = 1;
                matrix[7, 4] = 1;
                matrix[5, 6] = 1;
                matrix[6, 5] = 1;
                matrix[6, 9] = 1;
                matrix[9, 6] = 1;
                matrix[7, 11] = 1;
                matrix[11, 7] = 1;
                matrix[8, 10] = 4;
                matrix[10, 8] = 4;
                matrix[8, 11] = 6;
                matrix[11, 8] = 6;
                matrix[9, 11] = 1;
                matrix[11, 9] = 1;
                matrix[10, 11] = 3;
                matrix[11, 10] = 3;
                MessageBox.Show(comboBox1.Text);
            }
            else if (comboBox3.Text.Trim().Equals("MIDI"))
            {
                MessageBox.Show(comboBox3.Text);
                matrix[0, 1] = 4;
                matrix[1, 0] = 4;
                matrix[0, 4] = 2;
                matrix[4, 0] = 2;
                matrix[0, 5] = 8;
                matrix[5, 0] = 8;
                matrix[1, 2] = 7;
                matrix[2, 1] = 7;
                matrix[2, 3] = 9;
                matrix[3, 2] = 9;
                matrix[3, 8] = 9;
                matrix[8, 3] = 9;
                matrix[4, 7] = 7;
                matrix[7, 4] = 7;
                matrix[5, 6] = 4;
                matrix[6, 5] = 4;
                matrix[6, 9] = 3;
                matrix[9, 6] = 3;
                matrix[7, 11] = 1;
                matrix[11, 7] = 1;
                matrix[8, 10] = 3;
                matrix[10, 8] = 3;
                matrix[8, 11] = 8;
                matrix[11, 8] = 8;
                matrix[9, 11] = 6;
                matrix[11, 9] = 6;
                matrix[10, 11] =5;
                matrix[11, 10] = 5;
                MessageBox.Show(comboBox1.Text);
            }
            else if (comboBox3.Text.Trim().Equals("NUIT"))
            {
                MessageBox.Show(comboBox3.Text);
                matrix[0, 1] = 1;
                matrix[1, 0] = 1;
                matrix[0, 4] = 100;
                matrix[4, 0] = 100;
                matrix[0, 5] = 100;
                matrix[5, 0] = 100;
                matrix[1, 2] = 4;
                matrix[2, 1] = 4;
                matrix[2, 3] = 5;
                matrix[3, 2] = 5;
                matrix[3, 8] = 6;
                matrix[8, 3] = 6;
                matrix[4, 7] = 1;
                matrix[7, 4] = 1;
                matrix[5, 6] = 2;
                matrix[6, 5] = 2;
                matrix[6, 9] = 3;
                matrix[9, 6] = 3;
                matrix[7, 11] = 4;
                matrix[11, 7] = 4;
                matrix[8, 10] = 5;
                matrix[10, 8] = 5;
                matrix[8, 11] = 6;
                matrix[11, 8] = 6;
                matrix[9, 11] = 8;
                matrix[11, 9] = 8;
                matrix[10, 11] = 4;
                matrix[11, 10] = 4;
                MessageBox.Show(comboBox1.Text);
            }
            String depart = comboBox1.Text.Trim();
            String arriver = comboBox2.Text.Trim();
            /**********************************************************/
            if (comboBox1.Text.Trim().Equals("ARIANA"))
            {
                if (arriver.Equals("MENZAH"))
                {
                    MessageBox.Show("dsg");
                    distance[0] = 999;
                    distance[1] = matrix[0, 1];
                    distance[2] = 999;
                    distance[3] = 999;
                    distance[4] = matrix[0, 4];
                    distance[5] = matrix[0, 5];
                    distance[6] = 999;
                    distance[7] = 999;
                    distance[8] = 999;
                    distance[9] = 999;
                    distance[10] = 999;
                    distance[11] = 999;
                    visited[0] = 1; //set the source node as visited
                    distance[0] = 0; //set the distance from source to source to zero which is the starting point
                    for (int counter = 0; counter < 2; counter++)
                    {
                        min = 999;
                        for (int i = 0; i < 2; i++)
                        {
                            if (min > distance[i] && visited[i] != 1)
                            {
                                min = distance[i];
                                nextNode = i;
                            }
                        }
                        //Console.WriteLine(nextNode);
                        visited[nextNode] = 1;
                        for (int i = 0; i < 2; i++)
                        {
                            if (visited[i] != 1)
                            {
                                if (min + matrix[nextNode, i] < distance[i])
                                {
                                    distance[i] = min + matrix[nextNode, i];
                                    preD[i] = nextNode;
                                }
                            }
                        }
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine("|" + distance[i]);
                    }
                    Console.WriteLine("|");
                    int b;
                    for (int i = 1; i < 2; i++)
                    {
                        if (i != 0)
                        {
                            ariana.Visible = true;
                            menzah.Visible = true;
                            Console.WriteLine("Path = " + i);
                            b = i;
                            do
                            {
                                b = preD[b];
                                Console.WriteLine(" <- " + b);
                                if (b == 2)
                                {
                                    tunis.Visible = true;
                                }
                                if (b == 3)
                                {
                                    lac.Visible = true;
                                }
                                if (b == 4)
                                {
                                    borj_louzir.Visible = true;
                                }
                                if (b == 5)
                                {
                                    raoued.Visible = true;
                                }
                                if (b == 6)
                                {
                                    gammarth.Visible = true;
                                }
                                if (b == 7)
                                {
                                    sokra.Visible = true;

                                }
                                if (b == 8)
                                {
                                    ain_zaghouane.Visible = true;
                                }
                                if (b == 9)
                                {
                                    marsa.Visible = true;
                                }
                                if (b == 10)
                                {
                                    goulette.Visible = true;
                                }
                                if (b == 11)
                                {
                                    carthage.Visible = true;
                                }

                            } while (b != 0);
                        }
                    }
                }
                distance[0] = 999;
                distance[1] = matrix[0, 1];
                distance[2] = 999;
                distance[3] = 999;
                distance[4] = matrix[0, 4];
                distance[5] = matrix[0, 5];
                distance[6] = 999;
                distance[7] = 999;
                distance[8] = 999;
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = 999;
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    //Console.WriteLine(nextNode);
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                int x = 0;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        ariana.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1 )
                            {
                                menzah.Visible = true;
                               
                            }
                            if (j == 2 )
                            {
                                tunis.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4 )
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                                
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                               goulette.Visible = true;
                            }

                        } while (j != 0 && x!= 1);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("MENZAH"))
            {
                distance[0] = matrix[1, 0];
                distance[1] = 999;
                distance[2] = matrix[1, 2];
                distance[3] = 999;
                distance[4] = 999;
                distance[5] = 999;
                distance[6] = 999;
                distance[7] = 999;
                distance[8] = 999;
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = 999;
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        menzah.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("TUNIS"))
            {
                distance[0] = 999;
                distance[1] = matrix[2, 1];
                distance[2] = 999;
                distance[3] = matrix[2, 3];
                distance[4] = 999;
                distance[5] = 999;
                distance[6] = 999;
                distance[7] = 999;
                distance[8] = 999;
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = 999;
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        tunis.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 2)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("LAC"))
            {
                distance[0] = 999;
                distance[1] = 999;
                distance[2] = matrix[3, 2];
                distance[3] = 999;
                distance[4] = 999;
                distance[5] = 999;
                distance[6] = 999;
                distance[7] = 999;
                distance[8] = matrix[3, 8];
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = 999;
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        lac.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 3)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("BORJ LOUZIR"))
            {
                distance[0] = matrix[4, 0];
                distance[1] = 999;
                distance[2] = 999;
                distance[3] = 999;
                distance[4] = 999;
                distance[5] = 999;
                distance[6] = 999;
                distance[7] = matrix[4, 7];
                distance[8] = 999;
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = 999;
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        borj_louzir.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 4)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("RAOUED"))
            {
                distance[0] = matrix[5, 0];
                distance[1] = 999;
                distance[2] = 999;
                distance[3] = 999;
                distance[4] = 999;
                distance[5] = 999;
                distance[6] = matrix[5, 6];
                distance[7] = 999;
                distance[8] = 999;
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = 999;
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        raoued.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 5)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("GAMMARTH"))
            {
                distance[0] = 999;
                distance[1] = 999;
                distance[2] = 999;
                distance[3] = 999;
                distance[4] = 999;
                distance[5] = matrix[6, 5];
                distance[6] = 999;
                distance[7] = 999;
                distance[8] = 999;
                distance[9] = matrix[6, 9];
                distance[10] = 999;
                distance[11] = 999;
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        gammarth.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 6)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("SOKRA"))
            {
                distance[0] = 999;
                distance[1] = 999;
                distance[2] = 999;
                distance[3] = 999;
                distance[4] = matrix[7, 4];
                distance[5] = 999;
                distance[6] = 999;
                distance[7] = 999;
                distance[8] = 999;
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = matrix[7, 11];
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        sokra.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 7)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("AIN ZAGHOUANE"))
            {
                distance[0] = 999;
                distance[1] = 999;
                distance[2] = 999;
                distance[3] = matrix[8, 3];
                distance[4] = 999;
                distance[5] = 999;
                distance[6] = 999;
                distance[7] = 999;
                distance[8] = 999;
                distance[9] = 999;
                distance[10] = matrix[8, 10];
                distance[11] = matrix[8, 11];
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        ain_zaghouane.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 8)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("MARSA"))
            {
                distance[0] = 999;
                distance[1] = 999;
                distance[2] = 999;
                distance[3] = 999;
                distance[4] = 999;
                distance[5] = 999;
                distance[6] = matrix[9, 6];
                distance[7] = 999;
                distance[8] = 999;
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = matrix[9, 11];
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        marsa.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 9)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }
                            if (j == 10)
                            {
                                goulette.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
            if (comboBox1.Text.Trim().Equals("GOULETTE"))
            {
                distance[0] = 999;
                distance[1] = 999;
                distance[2] = 999;
                distance[3] = 999;
                distance[4] = 999;
                distance[5] = 999;
                distance[6] = 999;
                distance[7] = 999;
                distance[8] = matrix[10, 8];
                distance[9] = 999;
                distance[10] = 999;
                distance[11] = matrix[10, 11];
                visited[0] = 1; //set the source node as visited
                distance[0] = 0; //set the distance from source to source to zero which is the starting point
                for (int counter = 0; counter < 12; counter++)
                {
                    min = 999;
                    for (int i = 0; i < 12; i++)
                    {
                        if (min > distance[i] && visited[i] != 1)
                        {
                            min = distance[i];
                            nextNode = i;
                        }
                    }
                    visited[nextNode] = 1;
                    for (int i = 0; i < 12; i++)
                    {
                        if (visited[i] != 1)
                        {
                            if (min + matrix[nextNode, i] < distance[i])
                            {
                                distance[i] = min + matrix[nextNode, i];
                                preD[i] = nextNode;
                            }
                        }
                    }
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine("|" + distance[i]);
                }
                Console.WriteLine("|");
                int j;
                for (int i = 11; i < 12; i++)
                {
                    if (i != 0)
                    {
                        goulette.Visible = true;
                        carthage.Visible = true;
                        Console.WriteLine("Path = " + i);
                        j = i;
                        do
                        {
                            j = preD[j];
                            Console.WriteLine(" <- " + j);
                            if (j == 1)
                            {
                                menzah.Visible = true;
                            }
                            if (j == 10)
                            {
                                ariana.Visible = true;
                            }
                            if (j == 3)
                            {
                                lac.Visible = true;
                            }
                            if (j == 4)
                            {
                                borj_louzir.Visible = true;
                            }
                            if (j == 5)
                            {
                                raoued.Visible = true;
                            }
                            if (j == 6)
                            {
                                gammarth.Visible = true;
                            }
                            if (j == 7)
                            {
                                sokra.Visible = true;
                            }
                            if (j == 8)
                            {
                                ain_zaghouane.Visible = true;
                            }
                            if (j == 9)
                            {
                                marsa.Visible = true;
                            }
                            if (j == 2)
                            {
                                tunis.Visible = true;
                            }

                        } while (j != 0);
                    }
                }
                //ls.Add(" et enfin on arrive à H");
                //Console.WriteLine(path);
                //List<String> lpath = new List<string>();
                //lpath.Add(ls[0]);
                //Console.WriteLine(ls[0] + "****");
                //for (int i = ls.Count - 2; i >= 1; i--)
                //{
                //    lpath.Add(ls[i]);
                //}
                //lpath.Add(ls[ls.Count - 1]);
                //path += lpath[0];
                //for (int i = 1; i < ls.Count - 1; i++)
                //{
                //    Console.WriteLine(lpath[i]);
                //    path += string.Format(" ensuite {0}", lpath[i]);
                //}
                //path += ls[ls.Count - 1];
                //Console.WriteLine(path);
                ///*SpeechSynthesizer synth = new SpeechSynthesizer();
                //synth.Rate = -3;
                //synth.SpeakAsync(path);*/
                //lpath.Clear();
                //ls.Clear();
            }
        }

        private void ActualiserBtn_Click(object sender, EventArgs e)
        {
            raoued.Visible = false;
            marsa.Visible = false;
            goulette.Visible = false;
            tunis.Visible = false;
            ariana.Visible = false;
            menzah.Visible = false;
            lac.Visible = false;
            carthage.Visible = false;
            sokra.Visible = false;
            ain_zaghouane.Visible = false;
            borj_louzir.Visible = false;
            gammarth.Visible = false;
        }
    }
}
