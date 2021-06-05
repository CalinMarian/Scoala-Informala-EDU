using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoala_Informala_EDU
{
    public partial class Quiz : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score = 0;
        int percentage;
        readonly int totalQuestions = 20;


        public Quiz()
        {
            InitializeComponent();

            AskQuestion(questionNumber);

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);



            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly! " + Environment.NewLine +
                    "Your total percentage is " + percentage + "% !" + Environment.NewLine +
                    "Click OK to play again."
                    );

                score = 0;
                questionNumber = 1;
                AskQuestion(questionNumber);
            }

            questionNumber++;
            AskQuestion(questionNumber);
        }



        private void AskQuestion(int questionNumber)
        {

            switch (questionNumber)
            {
                case 1:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "When was C# invented?";

                    button1.Text = "1983";
                    button2.Text = "2002";
                    button3.Text = "2000";
                    button4.Text = "2012";

                    correctAnswer = 3;

                
                    break;
                case 2:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "Which of the following is an 8-byte integer";

                    button1.Text = "Char";
                    button2.Text = "Long";
                    button3.Text = "Short";
                    button4.Text = "Integer";

                    correctAnswer = 2;

                    break;
                case 3:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "Which of the following is the correct default value of a Boolean type?";

                    button1.Text = "0";
                    button2.Text = "1";
                    button3.Text = "True";
                    button4.Text = "False";

                    correctAnswer = 4;

                    break;
                case 4:
                    pictureBox.Image = Properties.Resources.Q4;
                    lblQuestion.Text = "Which of the following will be the correct output for the C#.NET code snippet given below?";

                    button1.Text = "NagpuMumbair";
                    button2.Text = "Nagpur Mumbai";
                    button3.Text = "Mumbai";
                    button4.Text = "NagpurMumbai";

                    correctAnswer = 4;

                    break;

                case 5:
                    pictureBox.Image = Properties.Resources.Q5;

                    lblQuestion.Text = "Which of the following will be the correct output for the C#.NET code snippet given below?";

                    button1.Text = "ARE";
                    button2.Text = "CRE";
                    button3.Text = "CR";
                    button4.Text = "CREATED";

                    correctAnswer = 2;

                    break;

                case 6:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "Which of the following statements about the array are NOT true";

                    button1.Text = "A one-dimensional array can store data in the form of table with many rows and columns";
                    button2.Text = "To use an array, previously it is declared and defined";
                    button3.Text = "The position of every element of the array is used to access that element that position";
                    button4.Text = "A one-dimensional array can store different types of data";

                    correctAnswer = 1;

                    break;

                case 7:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "Which of the following statement is correct about a string in C#.NET??";

                    button1.Text = "A number cannot be represented in the form of a string";
                    button2.Text = "The System.Array class is used to represent a string";
                    button3.Text = " A string is mutable because it can be modified once it has been created";
                    button4.Text = "A string has a zero-based index";

                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "The Method use to remove white space from a string?";

                    button1.Text = "Remove()";
                    button2.Text = "Split()";
                    button3.Text = "Copy()";
                    button4.Text = "Trim";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "Which of these operators can be used to concatenate two or more String objects?";

                    button1.Text = "/";
                    button2.Text = "*";
                    button3.Text = "+";
                    button4.Text = "&&";

                    correctAnswer = 4;

                    break;
                case 10:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "Which of the following statements is correct";

                    button1.Text = "A struct never declares a default constructor";
                    button2.Text = "All value types in C# inherently derive from ValueType, which inherits from Object.";
                    button3.Text = "A struct never declares a default destructor.";
                    button4.Text = "In C#, classes and structs are semantically same";

                    correctAnswer = 4;

                    break;
                case 11:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "When an array is partially initialized, the rest of its elements will automatically be set to zero";

                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;
                case 12:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "The new keyword can be used to allocate spaces for an array.";

                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;
                case 13:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "A two-dimensional array represents data in the form of table with rows and columns.";

                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;

                case 14:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "An array has a Length property that can be used to find the number of elements in the array.";

                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;
                case 15:

                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "If you have an array of 20 elements, what is the good way to assign a value to each element?";

                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;
                case 16:

                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "The string built using the String class are immutable (unchangeable), whereas, the ones built- using the StringBuilder class are mutable.";
                    
                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;
                case 17:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "Which of the following statements is true about an enum used in C#.Net?";
                    
                    button1.Text = "An implicit cast is needed to convert from enum type to an integral type";
                    button2.Text = "An enum variable cannot have a public access modifier.";
                    button3.Text = "An enum variable cannot have a private access modifier.";
                    button4.Text = "An enum variable can be defined inside a class or a namespace.";

                    correctAnswer = 4;

                    break;
                case 18:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "An enum variable can be defined inside a class or a namespace.";

                    button1.Text = "True";
                    button2.Text = "False";
                    button3.Text = "";
                    button4.Text = "";

                    correctAnswer = 1;

                    break;
                case 19:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "A derived class can stop virtual inheritance by declaring an override as";

                    button1.Text = "inherits";
                    button2.Text = "extends";
                    button3.Text = "not inheritable";
                    button4.Text = "sealed";

                    correctAnswer = 4;

                    break;
                case 20:
                    pictureBox.Image = Properties.Resources.MainBackround;

                    lblQuestion.Text = "Which of the following keyword is used to change the data and behavior of a base class by replacing a member of a base class with a new derived member?";

                    button1.Text = "new";
                    button2.Text = "base";
                    button3.Text = "overloads";
                    button4.Text = "override";

                    correctAnswer = 1;

                    break;
            }
         
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void Quiz_Load(object sender, EventArgs e)
        {

        }
    }
}
