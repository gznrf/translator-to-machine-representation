using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppForKursovaya
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        //Метод для перевода вещественного числа в 2 систему счисления
        static string ReversForNatural(string input, int maxIterations = 40)
        {
            string inputStr = input;
            double inputDbl = Convert.ToDouble(inputStr);
            int fullPartInt = Convert.ToInt32(Math.Abs(Math.Truncate(inputDbl)));
            double fractionPart = Convert.ToDouble(inputDbl - fullPartInt);
            string fullPartStr = Convert.ToString(fullPartInt, 2);
            string secondsryFractiobPartStr = "";
            int iterations = 0;

            if (fractionPart < 1)
            {
                do
                {
                    fractionPart *= 2;
                    secondsryFractiobPartStr += Math.Truncate(fractionPart);
                    fractionPart -= Math.Truncate(fractionPart);
                    iterations++;
                    if (iterations >= maxIterations)
                    {
                        break;
                    }
                }
                while (fractionPart != 0);
            }
            string fullNum = fullPartStr + ',' + secondsryFractiobPartStr;
            return fullNum;
        }
        //метод для получения бита знака
        static string Sign(string a)
        {
            if (a[0] == '-')
            {
                
                return "1";
            }
            return "0";
        }
        //метод для сдвига запятой
        static string MoveDot(string a)
        {
            a = a.Remove(a.IndexOf(','), 1);
            int aLength = a.Length;
            string first = "";
            for (int i = 0; i < aLength; i++)
            {
                if (a[0] == '0')
                {
                    a = a.Remove(0, 1);
                }
                else
                {
                    first = Convert.ToString(a[0]);
                    a = a.Remove(0, 1);
                    break;
                }
            }
            if(a == "") { a = "0"; }
            string result = first + ',' + a;
            return result;
        }
        //метод для получения степени
        static string DegreeGeting(string a, string b)
         {
            //int fstIndex = a.IndexOf('1');
            //int scnIndex = b.IndexOf('1') + 1;
            while (a[0] != ',')
                a = a.Remove(0, 1);
            while (b[0] != ',')
                b = b.Remove(0, 1);

            string order = Convert.ToString(b.Length - a.Length + 127, 2).PadLeft(8, '0');
            return order;
        }
        static void Crafter(string a, out string signOutput, out string degreeOutput, out string mantisOutput)
        {
            a = a.Replace('.', ',');
            string sing = Sign(a);
            if (a[0] == '-')
            {
                a = a.Remove(0, 1);
            }
            string aInSec = MoveDot(ReversForNatural(a));
            string degree = DegreeGeting(ReversForNatural(a), aInSec);
            aInSec = aInSec.Remove(0, 2);
            signOutput = sing;
            degreeOutput = degree;
            mantisOutput = aInSec.PadRight(23, '0');
        }
        //Метод для суммы двоичного числа и единицы
        static void PlusOne(string a, int[] b)
        {
            for (int i = 0; i <= b.Length - 1; i++)
                b[i] = int.Parse(a[i].ToString());
            b[b.Length - 1] = b[b.Length - 1] + 1;
            if (b[b.Length - 1] == 2)
            {
                for (int i = b.Length - 1; i >= 0; i--)
                {
                    switch (b[i])
                    {
                        case 2:
                            b[i] = 0;
                            if (i != 0)
                                b[i - 1] += 1;
                            break;
                    }
                }
            }
            else
                b[b.Length - 1] = 1;
        }
        //Метод для вывода массива
        static string ArrayPrint(string[] a, string b)
        {
            for (int i = 0; i <= a.Length - 1; i++)
                b += a[i];
            return b;
        }
        //Метод для конвертации масива из инт в стр
        static void ArrayConverterToString(int[] baditionalArray, string[] aToConvert)
        {
            for (int i = 0; i <= baditionalArray.Length - 1; i++)
                aToConvert[i] = Convert.ToString(baditionalArray[i]);
        }
        //Метод для обратного кода
        static string CodeReverser(string a)
        {
            a = a.Replace("1", "2");
            a = a.Replace("0", "3");
            a = a.Replace("2", "0");
            a = a.Replace("3", "1");
            return a;
        }
        private void ResultButton_Click(object sender, EventArgs e)
        {
            OutputAdditionalCode.Clear();//Очистка последнего поля для корректной работы
            long userInput = Convert.ToInt32(InputNum.Text);
            switch (ComboBoxOfCell.SelectedIndex)//Выборка кол-ва битов
            {
                case 0: //8 бит
                    if (userInput <= 0 && userInput >= -128)
                    {
                        //Перевод в двоичный код
                        string userInputStr = Convert.ToString(Math.Abs(userInput), 2).PadLeft(7, '0');
                        OutputUnsignedCode.Text = 0 + userInputStr;
                        //Для перевода в прямой код
                        OutputDirecCode.Text = 1 + userInputStr;
                        //Для перевода в обратный код
                        OutputTheReverseCode.Text = 1 + CodeReverser(userInputStr);
                        //Для перевода в дополлнительный код
                        string outputTheReverseCode = OutputTheReverseCode.Text;
                        int[] aditionalArray = new int[8];//Массив для сложения двоичного числа с единицей
                        string[] arrayToConvert = new string[8];//Вспомогательный массив для вывода
                        PlusOne(outputTheReverseCode, aditionalArray);//Метод возвращающий двоичное число + 1
                        ArrayConverterToString(aditionalArray, arrayToConvert); //Метод переделывающий численный массив в строковой массив
                        OutputAdditionalCode.Text =  ArrayPrint(arrayToConvert, OutputAdditionalCode.Text); //Метод выводящий массив
                    }
                    else if (userInput > 0 && userInput <= 255)
                    {
                        string userInputStr = Convert.ToString(userInput, 2).PadLeft(8, '0');
                        OutputUnsignedCode.Text = userInputStr;
                        OutputDirecCode.Text = userInputStr;
                        OutputTheReverseCode.Text = userInputStr;
                        OutputAdditionalCode.Text = userInputStr;
                    }
                    else
                        InputNum.Text = "Введите значения->";

                    break;
                case 1: //16 бит
                    if (userInput < 0 && userInput >= -32768)
                    {
                        //Перевод в двоичный код
                        string userInputStr = Convert.ToString(Math.Abs(userInput), 2).PadLeft(15, '0');
                        OutputUnsignedCode.Text = 0 + userInputStr;
                        //Для перевода в прямой код
                        OutputDirecCode.Text = 1 + userInputStr;
                        //Для перевода в обратный код
                        OutputTheReverseCode.Text = 1 + CodeReverser(userInputStr);
                        //Для перевода в дополлнительный код
                        string outputTheReverseCode = OutputTheReverseCode.Text;
                        int[] aditionalArray = new int[16];//Массив для сложения двоичного числа с единицей
                        string[] arrayToConvert = new string[16];//Вспомогательный массив для вывода
                        PlusOne(outputTheReverseCode, aditionalArray);//Метод возвращающий двоичное число + 1
                        ArrayConverterToString(aditionalArray, arrayToConvert); //Метод переделывающий численный массив в строковой массив
                        OutputAdditionalCode.Text = ArrayPrint(arrayToConvert, OutputAdditionalCode.Text); //Метод выводящий массив
                    }
                    else if (userInput > 0 && userInput <= 65535)
                    {
                        string userInputStr = Convert.ToString(userInput, 2).PadLeft(16, '0');
                        OutputUnsignedCode.Text = userInputStr;
                        OutputDirecCode.Text = userInputStr;
                        OutputTheReverseCode.Text = userInputStr;
                        OutputAdditionalCode.Text = userInputStr;
                    }
                    else
                        InputNum.Text = "Введите значения->";
                    break;
                case 2: //32 бит
                    if (userInput < 0 && userInput >= -2147483648)
                    {
                        //Перевод в двоичный код
                        string userInputStr = Convert.ToString(Math.Abs(userInput), 2).PadLeft(31, '0');
                        OutputUnsignedCode.Text = 0 + userInputStr;
                        //Для перевода в прямой код
                        OutputDirecCode.Text = 1 + userInputStr;
                        //Для перевода в обратный код
                        OutputTheReverseCode.Text = 1 + CodeReverser(userInputStr);
                        //Для перевода в дополлнительный код
                        string outputTheReverseCode = OutputTheReverseCode.Text;
                        int[] aditionalArray = new int[32];//Массив для сложения двоичного числа с единицей
                        string[] arrayToConvert = new string[32];//Вспомогательный массив для вывода
                        PlusOne(outputTheReverseCode, aditionalArray);//Метод возвращающий двоичное число + 1
                        ArrayConverterToString(aditionalArray, arrayToConvert); //Метод переделывающий численный массив в строковой массив
                        OutputAdditionalCode.Text = ArrayPrint(arrayToConvert, OutputAdditionalCode.Text); //Метод выводящий массив
                    }
                    else if (userInput > 0 && userInput <= 4294967295)
                    {
                        string userInputStr = Convert.ToString(userInput, 2).PadLeft(32, '0');
                        OutputUnsignedCode.Text = userInputStr;
                        OutputDirecCode.Text = userInputStr;
                        OutputTheReverseCode.Text = userInputStr;
                        OutputAdditionalCode.Text = userInputStr;
                    }
                    else
                        InputNum.Text = "Введите значения->";
                    break;
            }
        }
        private void resButton2_Click(object sender, EventArgs e)
        {
            Crafter(inputForPhysicalNums.Text, out string sing, out string degree, out string mantise);
            mantise = mantise.Remove(23);
            SignOutput.Text = sing;
            DegreeOutput.Text = degree;
            if (mantise[22] == '0')
            {
                mantise = mantise.Remove(22, 1) + '1';
            }
            MantiseOutput.Text = mantise;
        }
    }
}
