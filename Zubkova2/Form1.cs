using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zubkova2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static int LengthOfMassive = 30;
        Random rnd = new Random();
        public int[] massive1 = new int[LengthOfMassive];
        public int[] massive2 = new int[LengthOfMassive];
        public int[] massive3 = new int[LengthOfMassive];
        public int[] massive4 = new int[LengthOfMassive];
        public int[] massive = new int[LengthOfMassive * 4];
        // анализ
        public int[] temp = new int[11];


        // Заполнение первоначальных массивов
        void MassiveAdd(int[] ms1, int[] ms2, int[] ms3, int[] ms4, int[] ms)
        {
            for (int i = 0; i < ms1.Length; i++)
                ms1[i] = rnd.Next(0, 5);
            for (int i = 0; i < ms2.Length; i++)
                ms2[i] = rnd.Next(2, 8);
            for (int i = 0; i < ms3.Length; i++)
                ms3[i] = rnd.Next(4, 10);
            for (int i = 0; i < ms4.Length; i++)
                ms4[i] = rnd.Next(6, 12);
            ms1.CopyTo(massive, 0);
            ms2.CopyTo(massive, ms1.Length);
            ms3.CopyTo(massive, ms2.Length + ms1.Length);
            ms4.CopyTo(massive, ms1.Length + ms2.Length + ms3.Length);
            
        }


        // Вычисление среднего значения
        double Mean(int[] massive)
        {
            double avg = 0;
            foreach (var element in massive)
                avg += element;
            return Math.Round(avg / massive.Length, 4);
        }
        //Вычисление дисперсии
        double Dispersion(int[] massive)
        {
            double half = 0, dispersion = 0;
            for (int i = 0; i< massive.Length;i++)
            {
                half += massive[i];
            }
            half /= massive.Length;
            for(int i = 0; i < massive.Length; i++)
            {
                dispersion +=  ((massive[i] - half) * (massive[i] - half));
            }
            return Math.Round(dispersion / (massive.Length - 1), 4);
        }


        //Заполнение формы информацией. Вызов функций на анализ конечного массива и создание гистограммы
        private void button1_Click_1(object sender, EventArgs e)
        {
            MassiveAdd(massive1, massive2, massive3, massive4, massive);
            Array.Sort(massive);
            chart1.Series[0].Points.Clear();

            MassiveOne.Text = "";
            MassiveTwo.Text = "";
            MassiveThree.Text = "";
            MassiveFour.Text = "";
            MeanLabel.Text = "";
            DispersionLabel.Text = "";
            LastMassive.Text = "";

            foreach (var element in massive1)
                MassiveOne.Text += element + "; ";
            foreach (var element in massive2)
                MassiveTwo.Text += element + "; ";
            foreach (var element in massive3)
                MassiveThree.Text += element + "; ";
            foreach (var element in massive4)
                MassiveFour.Text += element + "; ";
            foreach (var element in massive)
                LastMassive.Text += element + "; ";

            
            MeanLabel.Text += Convert.ToString(Mean(massive));
            DispersionLabel.Text += Convert.ToString(Dispersion(massive));
            Analysis(massive, temp);

            FillChart(temp);

            for(int i = 0; i<temp.Length; i++)
            {
                temp[i] = 0;
            }
        }



        //анализ конечного массива
        void Analysis(int[] values, int[] temp)
        {
            foreach (var element in values)
            {
                if (element == 0)
                    temp[0] += 1;
                if (element == 1)
                    temp[1] += 1;
                if (element == 2)
                    temp[2] += 1;
                if (element == 3)
                    temp[3] += 1;
                if (element == 4)
                    temp[4] += 1;
                if (element == 5)
                    temp[5] += 1;
                if (element == 6)
                    temp[6] += 1;
                if (element == 7)
                    temp[7] += 1;
                if (element == 8)
                    temp[8] += 1;
                if (element == 9)
                    temp[9] += 1;
                if (element == 10)
                    temp[10] += 1;

            }
        }



        //Заполнение гистограммы
        private void FillChart(int[] array)
        {
            for (int i = 0; i < array.Length; ++i)
            {         
                chart1.Series["Конечный массив"].Points.AddY(array[i]);
            }
        }

    }
}
