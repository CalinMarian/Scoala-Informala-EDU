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
        int score;
        int percentage;
        readonly int totalQuestions = 10;
        

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
                questionNumber++;
                AskQuestion(questionNumber);

            }

            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly! " + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 1;
                AskQuestion(questionNumber);
            }
            else 
            {
                questionNumber++;
                AskQuestion(questionNumber);
            }
            
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
            }
         
        }

       
    }
}
