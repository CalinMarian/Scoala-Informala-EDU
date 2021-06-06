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
    public partial class QuizTips : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        readonly int totalQuestions;
        int seconds = 0;

        public QuizTips()
        {
            InitializeComponent();
            AskQuestion(questionNumber);
            totalQuestions = 15;
        }

        private void QuizTips_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            NextQuestion();

            if (buttonTag == correctAnswer)
            {
                score++;
            }



            if (questionNumber == totalQuestions)
            {
                countdownTimer.Stop();

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                MessageBox.Show(
                    "Quiz Ended!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);
            }


            questionNumber++;
            AskQuestion(questionNumber);
        }

        private void NextQuestion()
        {
            if (seconds == -1)
            {
                questionNumber++;
                AskQuestion(questionNumber);
         }
        }

        private void AskQuestion(int qNum)
        {
            seconds = 100;
            countdownTimer.Start();



            switch (qNum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "Who do you think the interview is about?";

                    button1.Text = "Interviewer";
                    button2.Text = "Interviewee";
                    button3.Text = "The job";
                    button4.Text = "All the participants";

                    correctAnswer = 1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What is the impostor syndrome?";

                    button1.Text = "A made up disease for weak people.";
                    button2.Text = "A psychological pattern in which an individual doubts their skills, talents, or accomplishments.";
                    button3.Text = "It is a feeling that you are worthy enough and all the other programmers are at the same level as you.";
                    button4.Text = "When you feel intimidated and need to compensate for it.";

                    correctAnswer = 2;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "How should you write your CV?";

                    button1.Text = "Download a template and follow the pattern.";
                    button2.Text = "Write and think from the company's perspective.";
                    button3.Text = "It should contain all your previou work, no matter the domain.";
                    button4.Text = "It doesn't matter, as long as you are good enought and you believe you'll get the interview.";

                    correctAnswer = 2;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What to do when you recognize symptoms of Impostor Syndrome?";

                    button1.Text = "Everything achieved so far was due to luck so you need to start worrying and try to learn more.";
                    button2.Text = "You can ignore it as they are not real feeling.";
                    button3.Text = "Try to compensate for knowing less than the other programmers by taking on a big load of work.";
                    button4.Text = "Focus on what you have already achieved. Take a step back and recognize your success";

                    correctAnswer = 4;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What if there's silence in the interview room?";

                    button1.Text = "Try to fill in the silence by giving a quick answer to the question; Since can be akward.";
                    button2.Text = "it's OK to fidget, and try to come up with an answer, if you don't know the answer tothe question";
                    button3.Text = "Collect your thoughts and take some time to consider the answer";
                    button4.Text = "You can lie, they won't realize.";

                    correctAnswer = 3;
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "Do you need to know about the company before applying for the job?";

                    button1.Text = "Yes, maximize your understanding of what the company is all about";
                    button2.Text = "As long as you are very sure of your skills and knowledger, that is not so important.";
                    button3.Text = "It's optional, so what if they ask you a question and you don\t know the answer? You're human after all!";
                    button4.Text = "Sure, make sure to praise their company and talk constantly about it.";

                    correctAnswer = 1;
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What should your attitude be in an interview?";

                    button1.Text = "It's OK to be a genius, after all, this is what everyone is looking for.";
                    button2.Text = "Make sure to make it obsious you have great knowledge by emphasizing on it.";
                    button3.Text = "Don't be arrogant. People need to work with you, and you most likely won't get hired if they feel you won't be a good fit for the team";
                    button4.Text = "Be very humble and speak on a low tone so they they are the bosses.";

                    correctAnswer = 3;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What else your your CV contain?";

                    button1.Text = "Sell yourself by talking about the technologies you’ve had experience with";
                    button2.Text = "Write about all your previous experience, related or not to the job.";
                    button3.Text = "Write very little so you won't occupy much space on the paper";
                    button4.Text = "Make sure to use all the adjectives you know; Let them know what a skilled person you are.";

                    correctAnswer = 1;
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What should you not do in an terview?";

                    button1.Text = "Don't go unprepared, study as much as you can about the company and the job";
                    button2.Text = "Don't ask questions about the company, position, framework, other programming languages they are using. They will let you know id needed.";
                    button3.Text = "Focus only on what is coming up, and not on what you have achieved.";
                    button4.Text = "Don't focus on what you want the future employer to see, focus on everything you have done.";

                    correctAnswer = 1;
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What should you do in an interview?";

                    button1.Text = "Start quickly to talk if someone asked you a question, to fill in the silence in the room.";
                    button2.Text = "Be opinionated. If you are brilliant, people won't care that need to work with you";
                    button3.Text = "You can add more things to your resume even though they mght not all apply to you, they won't realize.";
                    button4.Text = "It is OK to say you don't know something. Realize that more than likely the person interviewing you hs the same technology that you do.";

                    correctAnswer = 4;
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "How do you think the future employer will choose you for the interview?";

                    button1.Text = "They will read carefully all the CVs they receive, no matter the lenght.";
                    button2.Text = "They will look for those who look the same, it means that geniuses think alike.";
                    button3.Text = "Future employer will take a quick scan, looking for key words. Your CV will either disregarded or taken out of the pile";
                    button4.Text = "I don't know, it doen't matter to me.";

                    correctAnswer = 3;
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What if you have a panic attack before the interview?";

                    button1.Text = "It is natural to feel a little bit on edge or stressed, however this is part of the journey of an interview.";
                    button2.Text = "You should postpone the interview, it doesn't look good for you.";
                    button3.Text = "You know that you won't get it, so overcompensate for your stress.";
                    button4.Text = "This won't happen to me; I am the master of my emotions.";

                    correctAnswer = 1;
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What is common or your programmers?";

                    button1.Text = "You might feel intimidated or overwhelmed on your first job. There might be guru programmers you are comparing yourself with them constantly, it will cause you more harm than good.";
                    button2.Text = "You don't know how to feel; you are too yourng for this!";
                    button3.Text = "You come with fresh information, you might be better than the others.";
                    button4.Text = "Experience is not as important as information.";

                    correctAnswer = 1;
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What should you do when it comes to a new job?";

                    button1.Text = "Ask questions about the company, position, framework, other programming languages they are using, about the team.";
                    button2.Text = "No need to read the job description really carefully, they will tell you what they are looking for.";
                    button3.Text = "Ask about the salary, it is an important factor for you.";
                    button4.Text = "Just make sure you get it, no matter what!";

                    correctAnswer = 1;
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.hmm;

                    lblQuestions.Text = "What does the employer want?";

                    button1.Text = "They will try to trick you as much as they can, to see when you fail.";
                    button2.Text = "Interviewers want you to succeed. They don't want to trik you, but rather assess your skills: communication, enthusiasm and passion for programming.";
                    button3.Text = "They need someone with great skills, to solve all od their problems.";
                    button4.Text = "Who knows! I just need the job.";

                    correctAnswer = 3;
                    break;


            }
        }

        private void TxtQuestion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblScreen.Text = seconds--.ToString();
            if (seconds < 0)
            {
                countdownTimer.Stop();
                NextQuestion();
            }




        }
    }
}
