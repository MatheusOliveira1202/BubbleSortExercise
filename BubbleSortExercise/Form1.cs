using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace BubbleSortExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TimeSpan TimeExecution;
        int Min = 0;
        int Max = 2000;
        int tamanho = 10;
        int tamanhoList = 10;
        List<int> Lista = new List<int>();
        Stopwatch TimerApplication = new Stopwatch();
        int auxiliar;
        Random random = new Random();

        void RandomizeTenNumbers()
        {
            for (int i = 0; i < tamanhoList; i++)
            {
                Lista.Add(random.Next(Min,Max));
            }
            //MessageBox.Show(Lista.Count.ToString());
        }

        void RandomizeNumbers(int ListaLenght)
        {
            for (int i = 0; i < tamanhoList; i++)
            {
                Lista.Add(random.Next(Min, Max));
            }
            tamanhoList = tamanhoList + ListaLenght;
            //MessageBox.Show(tamanhoList.ToString());
        }

        void BubbleSort()
        {
            Lista.Clear();
            RandomizeNumbers(5);
            TimerApplication.Start();
            for (int i = tamanho - 1; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    // Graphic.PaletteCustomColors = System.Drawing.Color.FromArgb(255,0,0);
                    if (Lista[j] > Lista[j + 1])
                    {
                        auxiliar = Lista[j];
                        Lista[j] = Lista[j + 1];
                        Lista[j + 1] = auxiliar;
                    }
                }
            }
            TimerApplication.Stop();
            TimeExecution = TimerApplication.Elapsed;
            Console.WriteLine(TimeExecution.TotalSeconds.ToString() + "||"+ Lista.Count.ToString());

            Graphic.Series["Series1"].Points.AddXY(Lista.Count, TimeExecution.TotalSeconds);

            foreach (int number in Lista)
            {
                //ListElements.Text += number.ToString() + "||";
            }
            //Console.WriteLine(tamanho + "||" + tamanhoList);
        }

        private void DoBubbleSort(object sender, EventArgs e)
        {
            for (int i = 0; i < NumberChoosed.Value; i++)
            {
                BubbleSort();
            }
        }

        private void ShowAllList(object sender, EventArgs e)
        {
            RandomizeTenNumbers();
            foreach (int number in Lista)
            {
                //ListElements.Text += number.ToString() + "||";
            }
        }
    }
}
