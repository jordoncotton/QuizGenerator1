using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuizGenerator
{
    public partial class Form1 : Form
    {
        private const string Value = "Q1\n What year was 2002?";
        private const string Value1 = "Q2\n What does != mean?";
        private const string Value2 = "Q3\n How do you spell programming?";
        private const string Value3 = "Q4\n What is the name of the first Call of Duty?";

        public Form1(IContainer components, Button button1, TextBox textBox1, TextBox textBox2, CheckedListBox checkedListBox1, CheckedListBox checkedListBox2)
        {
            this.components = components;
            this.button1 = button1;
            this.textBox1 = textBox1;
            this.textBox2 = textBox2;
            this.checkedListBox1 = checkedListBox1;
            this.checkedListBox2 = checkedListBox2;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static void QuestionOne()
        {
            Console.Write(value: Value);
            int answer1 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message1 = (answer1 != 4) ? "Incorrect" : "Correct";
            Console.WriteLine(message1);
        }

        public static void QuestionTwo()
        {
            Console.Write(value: Value1);
            int answer2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message2 = (answer2 != 3) ? "Incorrect" : "Correct";
            Console.WriteLine(message2);
        }

        public static void QuestionThree()
        {
            Console.Write(value: Value2);
            int answer3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message3 = (answer3 != 2) ? "Incorrect" : "Correct";
            Console.WriteLine(message3);
        }

        public static void QuestionFour()
        {
            Console.Write(value: Value3);
            int answer4 = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            String message4 = (answer4 != 1) ? "Incorrect" : "Correct";
            Console.WriteLine(message4);
        }
      
        public static void Main(string[] args)
        {
            QuestionOne();
            QuestionTwo();
            QuestionThree();
            QuestionFour();
        }
    }
}
