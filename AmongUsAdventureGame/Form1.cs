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
using System.IO;
using AmongUsAdventureGame.Properties;

namespace AmongUsAdventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        const int waitTime = 1000;

        //variables for random generation
        Random randGen = new Random();
        int randNum;

        //counting kills variable for imposter
        int killCounter = 0;

        //keeps track of the role of the player (crewmate or imposter)
        string playerRole;

        //status of all tasks and imposters found
        bool wireStatus = false, asteroidStatus = false, swipeStatus = false, imposterStatus = false, imposter2Status = false;
        
        //variables for colours of imposters, user's guess colour, and the current room the player is in
        string imposterColour, imposter2Colour, guessColour, currentRoom;

        //background sound
        System.Windows.Media.MediaPlayer backMedia = new System.Windows.Media.MediaPlayer();

        public Form1()
        {
            //upon start, show start button and begin background music
            InitializeComponent();
            option1Button.Visible = true;
            option1Button.Text = "START GAME";

            backMedia.Open(new Uri(Application.StartupPath + "/Resources/Among Us Theme.mp3"));
            backMedia.MediaEnded += new EventHandler(backMedia_MediaEnded);

            backMedia.Play();
        }


        private void option1Button_Click(object sender, EventArgs e)
        {
            //button sound for whenever a player clicks button
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            //the page the player is on leads to another page when clicking this button
            if (page == 1)
            {
                //sound for when the game starts
                var roundstartSound = new System.Windows.Media.MediaPlayer();
                roundstartSound.Open(new Uri(Application.StartupPath + "/Resources/Roundstart.mp3"));
                roundstartSound.Play();

                //choose the role of the player
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
                //random if somebody else is in room
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
                //random if somebody else is in room
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
                //player leaves room, goes to imposter page or crewmate page
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
                //player leaves room
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
                //player leaves room
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
                //player leaves room
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
                //player leaves room
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
                //player leaves room
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
                //player leaves room
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
                //player leaves room
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
                //player leaves room
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
                //play again
                page = 1;
            }
            else if (page == 14)
            {
                //play again
                page = 1;
            }
            else if (page == 15)
            {
                //player leaves room
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
                //emergency meeting page, record players guess
                guessColour = "red";
                page = 17;
            }
            else if (page == 17)
            {
                //play again
                page = 1;
            }
            else if (page == 18)
            {
                //play again
                page = 1;
            }
            else if (page == 19)
            {
                //play again
                page = 1;
            }

            //switch statement in method to save space
            DisplayPage();
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            //button sound when button is clicked
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            if (page == 2)
            {
                //random if somebody is in room
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
                //random if somebody is in room
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
                //imposter kill attempt
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
                //crewmate task attempt and check if all tasks get completed
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
                //chance of somebody entering room
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
                    //crewmate task attempt and check if all tasks are complete
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
                //imposter kill attempt
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
                    //crewmate task attempt and check if all tasks are complete
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
                        //if the crewmate has already swiped, turn off the third button
                        option3Button.Visible = false;
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
            }
            else if (page == 7)
            {
                //chance of somebody entering room
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
                    //crewmate task attempt and check if all tasks are complete
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
                        //if crewmate has already swiped, turn off third button
                        option3Button.Visible = false;
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
            }
            else if (page == 8)
            {
                //imposter kill attempt
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
                //crewmate chance of dying
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
                //chance of somebody entering room
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
                //chance of dying
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
                //imposter kill attempt
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
                    //crewmate task attempt and check if all tasks are complete
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
                //chance of someone entering the room
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
                //crewmate task attempt and check if all tasks are complete
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
                //if task is done successfully, and user chooses "stay", bring them to the most recent room page
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
                //exit game
                page = 99;
            }
            else if (page == 14)
            {
                //exit game
                page = 99;
            }
            else if (page == 15)
            {
                //exit game
                page = 16;
            }
            else if (page == 16)
            {
                //emergency meeting, player guess is recorded
                guessColour = "orange";
                page = 17;
            }
            else if (page == 17)
            {
                //exit game
                page = 99;
            }
            else if (page == 18)
            {
                //exit game
                page = 99;
            }
            else if (page == 19)
            {
                //exit game
                page = 99;
            }

            DisplayPage();
        }


        private void option3Button_Click(object sender, EventArgs e)
        {
            //button sound when button is clicked
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();


            if (page == 2)
            {
                //chance of somebody in room
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
                //chance of somebody in room
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
                //chance of death
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
                //chance of death
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
                //emergency meeting, player's guess is recorded
                guessColour = "yellow";
                page = 17;
            }

            DisplayPage();
        }


        private void option4Button_Click(object sender, EventArgs e)
        {
            //button sound when button pressed
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            if (page == 2)
            {
                //chance of somebody else in room
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
                //chance of somebody else in room
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
                //emergency meeting, player's guess is recorded
                guessColour = "blue";
                page = 17;
            }

            DisplayPage();
        }

        private void option5Button_Click(object sender, EventArgs e)
        {
            //button sound when button pressed
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            //emergency meeting, player's guess is recorded
            guessColour = "cyan";
            page = 17;
            DisplayPage();

        }

        private void option6Button_Click(object sender, EventArgs e)
        {
            //button sound when button pressed
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            //emergency meeting, player's guess is recorded
            guessColour = "brown";
            page = 17;
            DisplayPage();

        }

        private void option7Button_Click(object sender, EventArgs e)
        {
            //button sound when button pressed
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            //emergency meeting, player's guess is recorded
            guessColour = "green";
            page = 17;
            DisplayPage();

        }


        private void option8Button_Click(object sender, EventArgs e)
        {
            //button sound when button pressed
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            //emergency meeting, player's guess is recorded
            guessColour = "lime";
            page = 17;
            DisplayPage();

        }

        private void option9Button_Click(object sender, EventArgs e)
        {
            //button sound when button pressed
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            //emergency meeting, player's guess is recorded
            guessColour = "black";
            page = 17;
            DisplayPage();

        }

        private void option10Button_Click(object sender, EventArgs e)
        {
            //button sound when button pressed
            var buttonSound = new System.Windows.Media.MediaPlayer();
            buttonSound.Open(new Uri(Application.StartupPath + "/Resources/voicy-among-us-press-menu-buttons_Ay5ZFAdF.mp3"));
            buttonSound.Play();

            //emergency meeting, player's guess is recorded
            guessColour = "purple";
            page = 17;
            DisplayPage();

        }



        void DisplayPage()
        {
            //depending on the page, image, sound, text, and button visibility changes
            switch (page)
            {
                case 1: 
                    //reset everything to the starting settings

                    this.BackgroundImage = Properties.Resources.amongUsBackground;

                    option1Button.Visible = true;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    option4Button.Visible = false;
                    option1Button.Text = "START GAME";
                    outputLabel.Text = "";

                    wireStatus = false; asteroidStatus = false; swipeStatus = false; imposterStatus = false; imposter2Status = false; ;
                    killCounter = 0;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.mainpageAmongus;

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
                    this.BackgroundImage = Properties.Resources.mainpageAmongus;

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
                    this.BackgroundImage = Properties.Resources.electricalRoom;

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
                        //check if player has already done the task
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
                    this.BackgroundImage = Properties.Resources.electricalRoom;


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
                        //check if player has already done the task
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
                    this.BackgroundImage = Properties.Resources.adminRoom;

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
                        //check if player has already done the task
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
                    this.BackgroundImage = Properties.Resources.adminRoom;


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
                        //check if player has already done the task
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
                    this.BackgroundImage = Properties.Resources.securityRoom;


                    outputLabel.Text = "There is somebody else in the security room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    //check if imposter or crewmate
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
                    this.BackgroundImage = Properties.Resources.securityRoom;

                    outputLabel.Text = "You are alone in the security room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    //check if imposter or crewmate
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
                    this.BackgroundImage = Properties.Resources.navigationRoom;

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
                        //check if player has already done the task
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
                    this.BackgroundImage = Properties.Resources.navigationRoom;


                    outputLabel.Text = "You are alone in the navigation room. What would you like to do?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    //check if crewmate or imposter
                    if (playerRole == "imposter")
                    {
                        option1Button.Text = "Leave";
                        option2Button.Text = "Stay";
                        option3Button.Text = "";
                        option4Button.Text = "";
                    }
                    else
                    {
                        //check if player has already done the task
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
                    this.BackgroundImage = Properties.Resources.imposterKills;

                    outputLabel.Text = "The imposter has killed you. Get good.";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    //wait for 1 second before displaying more text
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

                    //wait for 1 second before displaying more text
                    this.Refresh();
                    Thread.Sleep(waitTime);

                    outputLabel.Text += " Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 15:
                    //variable to choose what colour will be displayed as venting
                    string ventColour;

                    //if neither imposter has been discovered yet, randomly choose
                    if (imposterStatus == false && imposter2Status == false)
                    {
                        randNum = randGen.Next(1, 101);
                        if (randNum <= 50) //50%
                        {
                            ventColour = imposterColour;
                        }
                        else //75% chance nobody is in the room
                        {
                            ventColour = imposter2Colour;
                        }
                    }
                    //if imposter1 has already been discovered choose imposter2 and vice versa
                    else if (imposterStatus == true)
                    {
                        ventColour = imposter2Colour;
                    }
                    else 
                    {
                        ventColour = imposterColour;
                    }
                    
                    outputLabel.Text = $"You see {ventColour} vented. Do you want to call an emergency meeting?";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    option1Button.Text = "Leave";
                    option2Button.Text = "Emergency meeting";
                    option3Button.Text = "";
                    option4Button.Text = "";
                    break;
                case 16:
                    //sound for emergency meetings
                    var emergencySound = new System.Windows.Media.MediaPlayer();
                    emergencySound.Open(new Uri(Application.StartupPath + "/Resources/Report Body Found.mp3"));
                    emergencySound.Play();

                    this.BackgroundImage = Properties.Resources.emergencyMeeting;


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
                        imposterStatus = true;
                        outputLabel.Text = $"The {guessColour} was an imposter!";
                    }
                    else if (guessColour == imposter2Colour)
                    {
                        imposter2Status = true;
                        outputLabel.Text = $"The {guessColour} was an imposter!";
                    }

                    //wait for 1 second before displaying more text
                    this.Refresh();
                    Thread.Sleep(waitTime);

                    //if both imposters have been discovered, player wins
                    if (imposterStatus == true && imposter2Status == true)
                    {
                        outputLabel.Text += "You win, play again?";
                        option1Button.Visible = true;
                        option2Button.Visible = true;

                        option1Button.Text = "Yes";
                        option2Button.Text = "No";
                    }
                    //if only won imposter has been discovered, player must continue
                    else
                    {
                        outputLabel.Text = "You need to find the rest of the imposters.";

                        //wait for 1 second in order for text to be visible
                        this.Refresh();
                        Thread.Sleep(waitTime);

                        //switches pages without an input
                        if (playerRole == "imposter")
                        {
                            page = 2;
                        }
                        else
                        {
                            page = 3;
                        }
                        DisplayPage();
                    }
                    break;
                case 18:
                    //sound for killing
                    var killSound = new System.Windows.Media.MediaPlayer();
                    killSound.Open(new Uri(Application.StartupPath + "/Resources/Imposter Kill.mp3"));
                    killSound.Play();

                    this.BackgroundImage = Properties.Resources.imposterKills;

                    //counts the kills of the imposter
                    killCounter++;
                    
                    outputLabel.Text = "You have successfully killed the crewmate!";
                    option1Button.Visible = false;
                    option2Button.Visible = false;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    this.Refresh();
                    Thread.Sleep(waitTime);

                    //if 10 crewmates have been killed, player wins
                    if (killCounter >= 10)
                    {
                        outputLabel.Text = "All ten crewmates are dead. You win! Play again?";
                        option1Button.Text = "Yes";
                        option2Button.Text = "No";

                        option1Button.Visible = true;
                        option2Button.Visible = true;
                    }
                    //if 10 crewmates have not been killed, game continues
                    else
                    {
                        //switch pages without input
                        if (playerRole == "imposter")
                        {
                            page = 2;
                        }
                        else
                        {
                            page = 3;
                        }
                        DisplayPage();

                    }


                    break;
                case 19:
                    outputLabel.Text = "You have failed to kill the crewmate! They have discovered that you are the imposter and you lose.";
                    option1Button.Visible = true;
                    option2Button.Visible = true;
                    option3Button.Visible = false;
                    option4Button.Visible = false;

                    //wait for 1 second before displaying more text
                    this.Refresh();
                    Thread.Sleep(waitTime);

                    outputLabel.Text += " Play again?";
                    option1Button.Text = "Yes";
                    option2Button.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing...";
                    this.BackgroundImage = null;
                    option1Button.Visible = false;
                    option2Button.Visible = false;

                    this.Refresh();
                    Thread.Sleep(5000);
                    Application.Exit();
                    break;
            }
        }

        void imposterChoice()
        {
            //at the start of every round, new imposters are chosen, unless the player is the imposter
            int imposterNum = randGen.Next(1, 11);
            
            //random colour chosen as imposter1
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

            //random colour chosen as imposter2
            switch (imposterNum)
            {
                case 1:
                    imposter2Colour = "red";
                    break;
                case 2:
                    imposter2Colour = "orange";
                    break;
                case 3:
                    imposter2Colour = "yellow";
                    break;
                case 4:
                    imposter2Colour = "brown";
                    break;
                case 5:
                    imposter2Colour = "lime";
                    break;
                case 6:
                    imposter2Colour = "green";
                    break;
                case 7:
                    imposter2Colour = "blue";
                    break;
                case 8:
                    imposter2Colour = "cyan";
                    break;
                case 9:
                    imposter2Colour = "black";
                    break;
                case 10:
                    imposter2Colour = "purple";
                    break;
            }
        }
        private void backMedia_MediaEnded(object sender, EventArgs e)

        {
            //repeat the background music

            backMedia.Stop();

            backMedia.Play();

        }
    }
}
