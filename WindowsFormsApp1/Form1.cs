using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int[] array = new int[10];//массив случаных чисел
        static Thread threadOne = new Thread(bubbleSort);// 1-й поток
        static Thread threadTwo = new Thread(choiceSort);// 2-й поток
        static bool flag, flag1 = true; //флаги для синхронизации
        static object locker1 = new object();// 1-й локер
        static object locker2 = new object();// 2-й локер
        static void bubbleSort()
        //функция, реализующая сортировку пузырьком
        {
            lock (flag ? locker1 : locker2)
            {
                //проверка тернарным оператором критической секции
                int tmp;
                for (int i = 0; i < array.Length; ++i)
                {
                    for (int j = i + 1; j < array.Length; ++j)
                    {
                        if (array[i] < array[j])
                        {
                            tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }
                }
            }
        }
        static void choiceSort()
        //функция, реализующая сортировку выбором
        {
            lock (locker1)
            {
                int tmp;
                for (int i = 0; i < array.Length; ++i)
                {
                    for (int j = i + 1; j < array.Length; ++j)
                    {
                        if (array[i] > array[j])
                        {
                            tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }
                }
            }
        }
        private void buttonGenerateArr_Click(object sender, EventArgs e)
        //Обработка события нажатия на кнопку "Сгенерировать массив"
        {
            richTextBoxBase.Clear();
            Random rand = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rand.Next(-100, 100);
            }
            for (int i = 0; i < array.Length; ++i)
            {
                richTextBoxBase.Text += array[i].ToString() + "; ";
            }
        }
        private void buttonSortArr_Click(object sender, EventArgs e)
        //Обработка события нажатия на кнопку "Отсортировать массив"
        {
            richTextBoxSorted.Clear();
            threadOne.Start();
            threadTwo.Start();
            for (int i = 0; i < array.Length; ++i)
                richTextBoxSorted.Text += array[i].ToString() + "; ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxBase.Clear();
            Random rand = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rand.Next(-100, 100);
            }
            for (int i = 0; i < array.Length; ++i)
            {
                richTextBoxBase.Text += array[i].ToString() + "; ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBoxSorted.Clear();
            /*threadOne.Start();*/
            threadTwo.Start();
            /*threadOne.Join();*/
            threadTwo.Join();
            for (int i = 0; i < array.Length; ++i)
                richTextBoxSorted.Text += array[i].ToString() + "; ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBoxSorted.Clear();
            threadOne.Start();
            threadOne.Join();
            for (int i = 0; i < array.Length; ++i)
                richTextBoxSorted.Text += array[i].ToString() + "; ";
        }
    

        private void checkBoxCritic_CheckedChanged(object sender, EventArgs e)
        //Обработка события включения/отключения критической секции
        {
            if (checkBoxCritic.Checked) flag = true;
            else flag = false;
        }
    }
}

/*int tmp;
for (int i = 0; i < array.Length - 1; i++)
{
    int min = i;
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[min])
        {
            min = j;
        }
    }
    tmp = array[min];
    array[min] = array[i];
    array[i] = tmp;
}*/