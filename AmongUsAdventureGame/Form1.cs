using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AmongUsAdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        const int waitTime = 1000;


        Random randGen = new Random();
        int randNum;
        int randPercent;
        int killCounter = 0;
        string playerRole;
        bool wireStatus = false, asteroidStatus = false, swipeStatus = false;
        string imposterColour, fakeImposterColour, guessColour, currentRoom;

        public Form1()
        {
            InitializeComponent();
            option1Button.Visible = true;
            option1Button.Text = "START GAME";
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% chance of imposter
                {
                    playerRole = "imposter";
                    page = 2;
                }
                else //75% chance of crewmate
                {
                    playerRole = "crewmate";
                    imposterChoice();
                    page = 3;
                }
            }
            else if (page == 2)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% someone is in the room
                {
                    page = 4;
                }
                else //75% chance nobody is in the room
                {
                    page = 5;
                }
            }
            else if (page == 3)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% someone is in the room
                {
                    page = 4;
                }
                else //75% chance nobody is in the room
                {
                    page = 5;
                }
            }
            else if (page == 4)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 5)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 6)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 7)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 8)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 9)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 10)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 11)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 12)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                if (playerRole == "imposter")
                {
                    page = 2;
                }
                else
                {
                    page = 3;
                }
            }
            else if (page == 16)
            {
                guessColour = "red";
                page = 17;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }

            switchStatement();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% someone is in the room
                {
                    page = 6;
                }
                else //75% chance nobody is in the room
                {
                    page = 7;
                }
            }
            else if (page == 3)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% someone is in the room
                {
                    page = 6;
                }
                else //75% chance nobody is in the room
                {
                    page = 7;
                }
            }
            else if (page == 4)
            {
                if (playerRole == "imposter") 
                {
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 80) //80% kill successfully
                    {
                        page = 18;
                    }
                    else //20% fail
                    {
                        page = 19;
                    }
                }
                else
                {
                    if (wireStatus == false)
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 50) //get killed
                        {
                            page = 13;
                        }
                        else //survive
                        {
                            wireStatus = true;

                            if (wireStatus == true && asteroidStatus == true && swipeStatus == true)
                            {
                                page = 14;
                            }
                            else
                            {
                                page = 12;
                            }
                        }
                    }
                    else
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 50) //50% chance of dying
                        {
                            page = 13;
                        }
                        else 
                        {
                            page = 4;
                        }
                    }
                }
            }
            else if (page == 5)
            {
                if (playerRole == "imposter")
                {
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 25) //25% of someone entering room
                    {
                        page = 4;
                    }
                    else 
                    {
                        page = 5;
                    }
                } 
                else
                {
                    if (wireStatus == false)
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 25) //get killed
                        {
                            page = 13;
                        }
                        else //survive
                        {
                            wireStatus = true;

                            if (wireStatus == true && asteroidStatus == true && swipeStatus == true)
                            {
                                page = 14;
                            }
                            else
                            {
                                page = 12;
                            }
                        }
                    }
                    else
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 25) //25% chance of dying
                        {
                            page = 4;
                        }
                        else
                        {
                            page = 5;
                        }
                    }
                }
            }
            else if (page == 6)
            {
                if (playerRole == "imposter")
                {
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 80) //80% kill successfully
                    {
                        page = 18;
                    }
                    else //20% fail
                    {
                        page = 19;
                    }
                }
                else
                {
                    if (swipeStatus == false)
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 50) //get killed
                        {
                            page = 13;
                        }
                        else //survive
                        {
                            swipeStatus = true;

                            if (wireStatus == true && asteroidStatus == true && swipeStatus == true)
                            {
                                page = 14;
                            }
                            else
                            {
                                page = 12;
                            }
                        }
                    }
                    else
                    {
                        option2Button.Visible = false;
                    }
                }
            }
            else if (page == 7)
            {
                if (playerRole == "imposter")
                {
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 25) //25% of someone entering room
                    {
                        page = 6;
                    }
                    else
                    {
                        page = 7;
                    }
                }
                else
                {
                    if (swipeStatus == false)
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 25) //get killed
                        {
                            page = 13;
                        }
                        else //survive
                        {
                            swipeStatus = true;

                            if (wireStatus == true && asteroidStatus == true && swipeStatus == true)
                            {
                                page = 14;
                            }
                            else
                            {
                                page = 12;
                            }
                        }
                    }
                    else
                    {
                        option2Button.Visible = false;
                    }
                }
            }
            else if (page == 8)
            {
                if (playerRole == "imposter")
                {
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 80) //80% kill successfully
                    {
                        page = 18;
                    }
                    else //20% fail
                    {
                        page = 19;
                    }
                }
                else
                {
                    if (randNum <= 50) //50% die
                    {
                        page = 13;
                    }
                    else 
                    {
                        page = 15;
                    }
                }
            }
            else if (page == 9)
            {
                if (playerRole == "imposter")
                {
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 25) //25% of someone entering room
                    {
                        page = 8;
                    }
                    else
                    {
                        page = 9;
                    }
                }
                else
                { 
                        if (randNum <= 25) //25% die
                        {
                            page = 13;
                        }
                        else
                        {
                            page = 15;
                        }
                    
                }
            }
                    
            else if (page == 10)
            {
                if (playerRole == "imposter")
                {
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 80) //80% kill successfully
                    {
                        page = 18;
                    }
                    else //20% fail
                    {
                        page = 19;
                    }
                }
                else
                {
                    if (asteroidStatus == false)
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 50) //get killed
                        {
                            page = 13;
                        }
                        else //survive
                        {
                            asteroidStatus = true;

                            if (wireStatus == true && asteroidStatus == true && swipeStatus == true)
                            {
                                page = 14;
                            }
                            else
                            {
                                page = 12;
                            }
                        }
                    }
                    else
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 50) //50% chance of dying
                        {
                            page = 13;
                        }
                        else
                        {
                            page = 10;
                        }
                    }
                }
            }
            else if (page == 11)
            {
                if (playerRole == "imposter")
                {
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 25) //25% of someone entering room
                    {
                        page = 4;
                    }
                    else
                    {
                        page = 5;
                    }
                }
                else
                {
                    if (asteroidStatus == false)
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 25) //get killed
                        {
                            page = 13;
                        }
                        else //survive
                        {
                            asteroidStatus = true;

                            if (wireStatus == true && asteroidStatus == true && swipeStatus == true)
                            {
                                page = 14;
                            }
                            else
                            {
                                page = 12;
                            }
                        }
                    }
                    else
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 25) //25% chance of dying
                        {
                            page = 10;
                        }
                        else
                        {
                            page = 11;
                        }
                    }
                }
            }
            else if (page == 12)
            {
                if (currentRoom == "electrical")
                {
                    page = 4;
                }
                else if (currentRoom == "admin")
                {
                    page = 6;
                }
                else if (currentRoom == "security")
                {
                    page = 8;
                }
                else
                {
                    page = 10;
                }
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 16)
            {
                guessColour = "orange";
                page = 17;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }

            switchStatement();
        }


        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% someone is in the room
                {
                    page = 8;
                }
                else //75% chance nobody is in the room
                {
                    page = 9;
                }
            }
            else if (page == 3)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% someone is in the room
                {
                    page = 8;
                }
                else //75% chance nobody is in the room
                {
                    page = 9;
                }
            }
            else if (page == 6)
            {
                if (randNum <= 50) //50% die
                {
                    page = 13;
                }
                else
                {
                    page = 15;
                }
            }
            else if (page == 7)
            {
                if (randNum <= 25) //25% die
                {
                    page = 13;
                }
                else
                {
                    page = 15;
                }
            }
            else if (page == 16)
            {
                guessColour = "yellow";
                page = 17;
            }

            switchStatement();
        }


        private void option4Button_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% someone is in the room
                {
                    page = 10;
                }
                else //75% chance nobody is in the room
                {
                    page = 11;
                }
            }
            else if (page == 3)
            {
                randNum = randGen.Next(1, 101);
                if (randNum <= 25) //25% someone is in the room
                {
                    page = 10;
                }
                else //75% chance nobody is in the room
                {
                    page = 11;
                }
            }
            else if (page == 16)
            {
                guessColour = "blue";
                page = 17;
            }

            switchStatement();
        }

        private void option5Button_Click(object sender, EventArgs e)
        {
            guessColour = "cyan";
            page = 17;
            switchStatement();

        }

        private void option6Button_Click(object sender, EventArgs e)
        {
            guessColour = "brown";
            page = 17;
            switchStatement();

        }

        private void option7Button_Click(object sender, EventArgs e)
        {
            guessColour = "green";
            page = 17;
            switchStatement();

        }


        private void option8Button_Click(object sender, EventArgs e)
        {
            guessColour = "lime";
            page = 17;
            switchStatement();

        }

        private void option9Button_Click(object sender, EventArgs e)
        {
            guessColour = "black";
            page = 17;
            switchStatement();

        }

        private void option10Button_Click(object sender, EventArgs e)
        {
            guessColour = "purple";
            page = 17;
            switchStatement();

        }



        void switchStatement()
        {
            switch (page)
            {
                case 1:
                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    option4Button.Visible = false;
                    option1Button.Text = "START GAME";
                    outputLabel.Text = "";

                    wireStatus = false; asteroidStatus = false; swipeStatus = false;
                    killCounter = 0;
                    break;
                case 2:
                    outputLabel.Text = "You are the imposter. Your objective is to kill all the crewmates. Where would you like to go?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = true;
                    option4Button.Visible = true;

                    option1Button.Text = "Electrical";
                    option2Button.Text = "Admin";
                    option3Button.Text = "Security";
                    option4Button.Text = "Navigation";
                    break;
                case 3:
                    outputLabel.Text = "You are a crewmate. Your objective is to vote out the imposter or complete all your tasks. Where would you like to go?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = true;
                    option4Button.Visible = true;

                    option1Button.Text = "Electrical";
                    option2Button.Text = "Admin";
                    option3Button.Text = "Security";
                    option4Button.Text = "Navigation";
                    break;
                case 4:
                    currentRoom = "electrical";
                    
                    outputLabel.Text = "There is somebody else in the electrical room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    if (playerRole == "imposter") //check if imposter
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Kill";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else //if not imposter therefore crewmate
                    {
                        if (wireStatus == false)
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Fix wires";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                        else
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Stay";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                    }

                    break;
                case 5:
                    currentRoom = "electrical";

                    outputLabel.Text = "You are alone in the electrical room. What do you do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    if (playerRole == "imposter") //check the role of the player
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Stay";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else
                    {
                        if (wireStatus == false)
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Fix wires";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                        else
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Stay";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                    }
                    break;
                case 6:
                    currentRoom = "admin";

                    outputLabel.Text = "There is somebody else in the admin room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    if (playerRole == "imposter") //check if imposter
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Kill";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else //if not imposter therefore crewmate
                    {
                        if (swipeStatus == false)
                        {
                            option3Button.Visible = true;

                            option1Button.Text = "Leave";
                            option2Button.Text = "Swipe card";
                            option3Button.Text = "Check map";
                            option4Button.Text = "";
                        }
                        else
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Check map";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                    }
                    break;
                case 7:
                    currentRoom = "admin";

                    outputLabel.Text = "You are alone in the admin room. What do you do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    if (playerRole == "imposter") //check if imposter
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Stay";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else //if not imposter therefore crewmate
                    {
                        if (swipeStatus == false)
                        {
                            option3Button.Visible = true;

                            option1Button.Text = "Leave";
                            option2Button.Text = "Swipe card";
                            option3Button.Text = "Check map";
                            option4Button.Text = "";
                        }
                        else
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Check map";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                    }
                    break;
                case 8:
                    currentRoom = "security";

                    outputLabel.Text = "There is somebody else in the security room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    if (playerRole == "imposter")
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Kill";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Check cams";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    break;
                case 9:
                    currentRoom = "security";

                    outputLabel.Text = "You are alone in the security room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    if (playerRole == "imposter")
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Stay";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Check cams";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    break;
                case 10:
                    currentRoom = "navigation";

                    outputLabel.Text = "There is somebody else in the Navigation room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    if (playerRole == "imposter")
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Kill";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else
                    {
                        if (asteroidStatus == false)
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Shoot asteroids";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                        else
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Stay";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                    }
                    break;
                case 11:
                    currentRoom = "navigation";

                    outputLabel.Text = "You are alone in the navigation room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    if (playerRole == "imposter")
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Stay";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else
                    {
                        if (asteroidStatus == false)
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Shoot asteroids";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                        else
                        {
                            option1Button.Text = "Leave";
                            option2Button.Text = "Stay";
                            option3Button.Text = "";
                            option4Button.Text = "";
                        }
                    }
                    break;
                case 12:
                    outputLabel.Text = "You have successfully done your task. What do you want to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    option1Button.Text = "Leave";
                    option2Button.Text = "Stay";
                    option3Button.Text = "";
                    option4Button.Text = "";
                    break;
                case 13:
                    outputLabel.Text = "The imposter has killed you. Get good.";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    this.Refresh();
                    Thread.Sleep(waitTime);

                    outputLabel.Text += " Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "You have completed all your tasks. Congratulations!";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    this.Refresh();
                    Thread.Sleep(waitTime);

                    outputLabel.Text += " Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 15:
                    string colour;
                    
                    randNum = randGen.Next(1, 101);
                    if (randNum <= 50) //50%
                    {
                        colour = imposterColour;
                    }
                    else //75% chance nobody is in the room
                    {
                        colour = fakeImposterColour;
                    }
                    
                    outputLabel.Text = $"You see {colour} vented. Do you want to call an emergency meeting";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    option1Button.Text = "Leave";
                    option2Button.Text = "Call an emergency meeting";
                    option3Button.Text = "";
                    option4Button.Text = "";
                    break;
                case 16:
                    outputLabel.Text = "EMERGENCY MEETING!!! Who do you want to vote out?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = true;
                    option4Button.Visible = true; 
                    option5Button.Visible = true;
                    option6Button.Visible = true;
                    option7Button.Visible = true;
                    option8Button.Visible = true;
                    option9Button.Visible = true;
                    option10Button.Visible = true;

                    option1Button.Text = "Red";
                    option2Button.Text = "Orange";
                    option3Button.Text = "Yellow";
                    option4Button.Text = "Blue";
                    option5Button.Text = "Cyan";
                    option6Button.Text = "Brown";
                    option7Button.Text = "Green";
                    option8Button.Text = "Lime";
                    option9Button.Text = "Black";
                    option10Button.Text = "Purple";
                    break;
                case 17:
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    option4Button.Visible = false;
                    option5Button.Visible = false;
                    option6Button.Visible = false;
                    option7Button.Visible = false;
                    option8Button.Visible = false;
                    option9Button.Visible = false;
                    option10Button.Visible = false;

                    if (guessColour == imposterColour)
                    {
                        outputLabel.Text = $"The {guessColour} was the imposter! You win!!!";
                    }
                    else
                    {
                        outputLabel.Text = $"The {guessColour} was not the imposter.";
                    }

                    this.Refresh();
                    Thread.Sleep(waitTime);

                    if (guessColour == imposterColour)
                    {
                        outputLabel.Text += " Play again?";
                        option1Button.Visible = true;
                        option2Button.Visible = true;

                        option1Button.Text = "Yes";
                        option2Button.Text = "No";
                    }
                    else
                    {
                        if (playerRole == "imposter")
                        {
                            page = 2;
                        }
                        else
                        {
                            page = 3;
                        }
                        switchStatement();
                    }
                    break;
                case 18:
                    killCounter++;
                    
                    outputLabel.Text = "You have successfully killed the crewmate!";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    this.Refresh();
                    Thread.Sleep(waitTime);

                    if (killCounter >= 10)
                    {
                        outputLabel.Text = "All ten crewmates are dead. You win! Play again?";
                        option1Button.Text = "Yes";
                        option2Button.Text = "No";
                    }
                    else
                    {
                        if (playerRole == "imposter")
                        {
                            page = 2;
                        }
                        else
                        {
                            page = 3;
                        }
                        switchStatement();

                    }


                    break;
                case 19:
                    outputLabel.Text = "You have failed to kill the crewmate! They have discovered that you are the imposter and you lose.";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    this.Refresh();
                    Thread.Sleep(waitTime);

                    outputLabel.Text += " Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing...";
                    this.Refresh();
                    Thread.Sleep(5000);
                    
                    break;
                default:
                    break;
            }
        }

        void imposterChoice()
        {
            int imposterNum = randGen.Next(1, 11);
            switch (imposterNum)
            {
                case 1:
                    imposterColour = "red";
                    break;
                case 2:
                    imposterColour = "orange";
                    break;
                case 3:
                    imposterColour = "yellow";
                    break;
                case 4:
                    imposterColour = "brown";
                    break;
                case 5:
                    imposterColour = "lime";
                    break;
                case 6:
                    imposterColour = "green";
                    break;
                case 7:
                    imposterColour = "blue";
                    break;
                case 8:
                    imposterColour = "cyan";
                    break;
                case 9:
                    imposterColour = "black";
                    break;
                case 10:
                    imposterColour = "purple";
                    break;
            }
            imposterNum = randGen.Next(1, 11);
            switch (imposterNum)
            {
                case 1:
                    fakeImposterColour = "red";
                    break;
                case 2:
                    fakeImposterColour = "orange";
                    break;
                case 3:
                    fakeImposterColour = "yellow";
                    break;
                case 4:
                    fakeImposterColour = "brown";
                    break;
                case 5:
                    fakeImposterColour = "lime";
                    break;
                case 6:
                    fakeImposterColour = "green";
                    break;
                case 7:
                    fakeImposterColour = "blue";
                    break;
                case 8:
                    fakeImposterColour = "cyan";
                    break;
                case 9:
                    fakeImposterColour = "black";
                    break;
                case 10:
                    fakeImposterColour = "purple";
                    break;
            }
        }
    }
}
