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
    public partial class Job : Form
    {
        public Job()
        {
            InitializeComponent();
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
/*
            if (e.Node.Name == "nDo")
            {
                MessageBox.Show("Allign yourself to what the employer needs.");
                MessageBox.Show("Critically important to make it all about the employer and not about you!");
                MessageBox.Show("Recognize feelings of impostor syndrome.\r\nIt is natural to feel a little bit on edge or stressed, however this is part of the journey of an interview.");
                MessageBox.Show("Read the job description really carefully.\r\nMaximize your understanding of what the company is all about.");
                MessageBox.Show("Read your own resume!Tell the truth\r\nYou do not want to lie, however you want to make sure that what is proeminent that the relevant information about you is that you want/can solve this problems for the employer");
                MessageBox.Show("Recognize that interviewers want you to succeed.\r\nThey don't want to trik you, but rather assess your skills:communication, enthusiasm and passion for programming.");
                MessageBox.Show("Avoid being arrogant or too opinionated.\r\nBe humble and eager to learn.\r\nEven if you are brilliant, people still need to work with you.");
                MessageBox.Show("Ask questions about the company, position, framework, other programming languages they are using, the team.");
                MessageBox.Show("It is OK to say you don't know something.\r\nRealize that more than likely the person interviewing you hs the same technology that you do.");
                MessageBox.Show("Don't rush your answers.\r\nFocus on your vocabilary while talking.\r\nTry to use the righ computer terms.");
            }
            else if (e.Node.Name == "nDonts")
            {
                MessageBox.Show("Don't make the interview all about you. \r\nDo not focus on all previous experience that is not related to the job or the company mission.");
                MessageBox.Show("Don't go unprepared.\r\nstudy as much as you can about the company and the job.");
                MessageBox.Show("Don't lie in your resume because chances are, your employer will question you about what you've put in.\r\nDon't be left floundering with an answer.");
                MessageBox.Show("Don't be arrogant.\r\nPeople need to work with you, and you most likely won't get hired if they feel you won't be a good fit for the team.");
                MessageBox.Show("Don't fidget, and try to come up with an answer, if you don't know the answer to a question.");
                MessageBox.Show("Don't start quickly to talk if someone asked you a question, just to fill in the silence in the room.\r\nCollect your thoughts and take some time to consider the answer.");

            }
            else if (e.Node.Name == "nCV")
            {
                MessageBox.Show("This is what you need to know:\r\nIt is not about you, but about the employer.") ;
                MessageBox.Show("1-Write and think from their perspective.\r\n\r\nDO NOT COPY OTHER TEMPLATES!\r\nTry not to grab a template from the internet and only slightly modify it.\r\nIt will look similar to all the others and chances are it will not stand out.");
                MessageBox.Show("2-Scanning: Future employer will take a quick scan, looking for key words.\r\n\r\nYour CV will either disregarded or taken out of the pile.");
                MessageBox.Show("3-Focus on what you want the future employer to see. \r\n\r\nThey want to know that you are good for their organization, thus emphasise on that rather than on previous jobs not related to this.\r\nFocus on the reasons why you think you are a good match for this organization");
                MessageBox.Show("4-Tailor the resume for the position you apply for. \r\n\r\nCustomise your resume to fit the position.");
                MessageBox.Show("5-Certified? Contributed to some projects? \r\n\r\nSell yourself by talking about the technologies you’ve had experience with.");
                MessageBox.Show("6-Purpose: \r\n\r\nThe purpose of the resume is to get the interview, not the job. \r\nYou need to catch their attention.");
            }
            else if (e.Node.Name == "nIS")
            {
                MessageBox.Show("Impostor syndrome is a psychological pattern in which an individual doubts their skills, talents, or accomplishments and has a persistent internalized fear of being exposed as a fraud.");
                MessageBox.Show("It is a feeling that you are not worthy enough and all the other programmers are better. \r\nYou are thinking that everything achieved so far was due to luck, and you are not giving yourself enough credit for your accomplishments.");
                MessageBox.Show("As a young programmer, you might feel intimidated or overwhelmed on your first job. \r\nThere might be guru programmers you look up to, and comparing yourself with them constantly, it will cause you more harm than good.");
                MessageBox.Show("What to do?\r\n Focus on what you have already achieved.\r\nRecognize that there will always be someone that has more knowledge than you do, someone who has less knowledge than you do, and someone at your own level.");
                MessageBox.Show("You might perceive that a lot of people are at a higher level, and this might not be true.\r\nThey might just know the company better than you do.");
                MessageBox.Show("You are focusing only on what is coming up, and not on what you have achieved.\r\nTake a step back and recognize your success");
                MessageBox.Show("Remember that all programmers were at a certain point in their life when they didn't know how to code.\r\nNobody is born a programmer.");
            }
*/
        }

        private void Btn_quiz_Click(object sender, EventArgs e)
        {
            QuizTips quizTips = new();
            this.Hide();
            quizTips.ShowDialog();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTips_Click(object sender, EventArgs e)
        {         

        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == "nTIPS")
            {
                richTextBox1.Text = "Welcome to this section of our program!\r\n\r\n" +
                    "Great job for making it this far!\r\n\r\n" +
                    "Wondering what's next? It is preparing for actually getting the job!\r\n\r\n" +
                    "Everybody needs a little bit of help, especially if you are at the beginning.\r\n\r\n" +
                    "Please check the tips we have for you, ad then you can check whether you have understood or not the info by taking a quick Quiz!";
            }
            else
            {
                if (e.Node.Name == "nCV")
                {
                    richTextBox1.Text = "This is what you need to know:\r\nIt is not about you, but about the employer.\r\n\r\n" +
                        "1-Write and think from their perspective.\r\nDO NOT COPY OTHER TEMPLATES!\r\nTry not to grab a template from the internet and only slightly modify it.\r\nIt will look similar to all the others and chances are it will not stand out." +
                        "\r\n\r\n2-Scanning: Future employer will take a quick scan, looking for key words.\r\nYour CV will either disregarded or taken out of the pile." +
                        "\r\n\r\n3-Focus on what you want the future employer to see. \r\nThey want to know that you are good for their organization, thus emphasise on that rather than on previous jobs not related to this.\r\nFocus on the reasons why you think you are a good match for this organization." +
                        "\r\n\r\n4-Tailor the resume for the position you apply for. \r\nCustomise your resume to fit the position." +
                        "\r\n\r\n5-Certified? Contributed to some projects? \r\nSell yourself by talking about the technologies you’ve had experience with." +
                        "\r\n\r\n6-Purpose:\r\nThe purpose of the resume is to get the interview, not the job. \r\nYou need to catch their attention.";
                }
                else
                {
                    if (e.Node.Name == "nInterview")
                    {
                        richTextBox1.Text = "Please see what you should do or should not do during an Interview:";
                    }
                    else
                    {
                        if (e.Node.Name == "nDo")
                        {
                            richTextBox1.Text = "Allign yourself to what the employer needs.\r\nCritically important to make it all about the employer and not about you!" +
                                "\r\n\r\nRecognize feelings of impostor syndrome.\r\nIt is natural to feel a little bit on edge or stressed, however this is part of the journey of an interview." +
                                "\r\n\r\nRead the job description really carefully.\r\nMaximize your understanding of what the company is all about." +
                                "\r\n\r\nRead your own resume!Tell the truth\r\nYou do not want to lie, however you want to make sure that what is proeminent that the relevant information about you is that you want/can solve this problems for the employer." +
                                "\r\n\r\nRecognize that interviewers want you to succeed.\r\nThey don't want to trik you, but rather assess your skills:communication, enthusiasm and passion for programming." +
                                "\r\n\r\nAvoid being arrogant or too opinionated.\r\nBe humble and eager to learn.\r\nEven if you are brilliant, people still need to work with you." +
                                "\r\n\r\nAsk questions about the company, position, framework, other programming languages they are using, the team." +
                                "\r\n\r\nIt is OK to say you don't know something.\r\nRealize that more than likely the person interviewing you hs the same technology that you do." +
                                "\r\n\r\nDon't rush your answers.\r\nFocus on your vocabilary while talking.\r\nTry to use the righ computer terms.";
                        }
                        else
                        {
                            if (e.Node.Name == "nDonts")
                            {
                                richTextBox1.Text = "Don't make the interview all about you. \r\nDo not focus on all previous experience that is not related to the job or the company mission." +
                                    "\r\n\r\nDon't go unprepared.\r\nstudy as much as you can about the company and the job." +
                                    "\r\n\r\nDon't lie in your resume because chances are, your employer will question you about what you've put in.\r\nDon't be left floundering with an answer." +
                                    "\r\n\r\nDon't be arrogant.\r\nPeople need to work with you, and you most likely won't get hired if they feel you won't be a good fit for the team." +
                                    "\r\n\r\nDon't fidget, and try to come up with an answer, if you don't know the answer to a question." +
                                    "\r\n\r\nDon't start quickly to talk if someone asked you a question, just to fill in the silence in the room.\r\nCollect your thoughts and take some time to consider the answer.";
                            }
                            else
                            {
                                if (e.Node.Name == "nIS")
                                {
                                    richTextBox1.Text = "Impostor syndrome is a psychological pattern in which an individual doubts their skills, talents, or accomplishments and has a persistent internalized fear of being exposed as a fraud." +
                                        "\r\n\r\nIt is a feeling that you are not worthy enough and all the other programmers are better. \r\nYou are thinking that everything achieved so far was due to luck, and you are not giving yourself enough credit for your accomplishments." +
                                        "\r\n\r\nAs a young programmer, you might feel intimidated or overwhelmed on your first job. \r\nThere might be guru programmers you look up to, and comparing yourself with them constantly, it will cause you more harm than good." +
                                        "\r\n\r\nWhat to do?\r\n Focus on what you have already achieved.\r\nRecognize that there will always be someone that has more knowledge than you do, someone who has less knowledge than you do, and someone at your own level." +
                                        "\r\n\r\nYou might perceive that a lot of people are at a higher level, and this might not be true.\r\nThey might just know the company better than you do." +
                                        "\r\n\r\nYou are focusing only on what is coming up, and not on what you have achieved.\r\nTake a step back and recognize your success." +
                                        "\r\n\r\nRemember that all programmers were at a certain point in their life when they didn't know how to code.\r\nNobody is born a programmer.";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
