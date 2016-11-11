/// created by Sahil and Cameron: 
/// Date: 11/11/2016
/// description: A basic text adventure game engine, where you try to escape from Adam Johnson.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 1;

        // random number generator
       Random randgen = new Random(); 

        public Form1()
        {
            InitializeComponent();

            //display initial message and options
            Graphics fg = this.CreateGraphics();
            outputLabel.Text = "You Begin at 'The Hazelton Hotel' and you need to get to 'Antique record Player' store";
            
            
            
        }

        //Adds sounds in program
        SoundPlayer footsteps = new SoundPlayer(Properties.Resources.footsteps);
        SoundPlayer wilhelm = new SoundPlayer(Properties.Resources.Wilhelm);
        SoundPlayer gears = new SoundPlayer(Properties.Resources.Shift_Gears_);
        SoundPlayer door = new SoundPlayer(Properties.Resources.Creaking_Door_Spooky);
        SoundPlayer crowd = new SoundPlayer(Properties.Resources.Audience_Applause_);
        SoundPlayer car = new SoundPlayer(Properties.Resources.byebye);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.M)       //red button press
            {
                if (scene == 1)
                {
                    scene = 2;
                }
                else if (scene == 2)
                {
                    scene = 1;
                }
                else if (scene == 3)
                {
                    scene = 1;
                }
                else if (scene == 5)
                {
                    int chance = randgen.Next(1, 101);
                    if (chance > 75)
                    {
                        scene = 21;
                    }
                    else
                    {
                        scene = 6;
                    }
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 10; 
                }
                else if (scene == 10)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    scene = 13; 
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 20)
                {
                    scene = 15;
                }
                else if (scene == 16 )
                {
                    scene = 18;
                }
                else if (scene == 4 || scene == 6 || scene == 9 || scene == 11 || scene == 13 || scene == 15 || scene == 17 || scene == 18 || scene == 19)
                {
                    scene = 1;
                }
                else if (scene == 21)
                {
                    scene = 8;
                }
            }
            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 1)
                {
                    scene = 3;
                }
                else if (scene == 2)
                {
                    scene = 4;
                }
                else if (scene == 3)
                {
                    scene = 5;
                }
                else if (scene == 5)
                {
                    scene = 7;
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 11;
                }
                else if (scene == 12)
                {
                    scene = 14;
                }
               else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 14)
                {
                    scene = 16;
                }
                else if (scene == 20)
                {
                    scene = 16;
                }
                else if (scene == 4 || scene == 6 || scene == 9|| scene == 11|| scene == 13|| scene == 15|| scene== 17 || scene == 18 ||scene== 19)
                {
                    scene = 1;
                }
                else if (scene == 21)
                {
                    scene = 8;
                }
            }
            else if (e.KeyCode == Keys.Space)//green button press
            { 
                if (scene == 12)
                {
                    int chance = randgen.Next(1, 101);

                    if (chance <= 50)
                    {
                        scene = 20;
                    }
                    else
                    {
                        scene = 19;
                    }
               
                }
            }

            /// Display text and game options to screen based on the current scene and images
            switch (scene)
            {
                case 0:  //start scene  
                    break;
                case 1:
                    outputLabel.Text = " Do you ask the receptionist or use the telephone directory which is placed in a room?";
                    redLabel.Text = "Ask the receptionist";
                    blueLabel.Text = "Enter the room";
                    greenImage.Visible = false;
                    greenLabel.Visible = false;
                    imageOutput.Image = Properties.Resources.clearimage;
                    break;
                case 2:
                    outputLabel.Text = "He turned out to be Adam Johnson. He tell's you to follow him into a room, Do you Follow him? ";
                    redLabel.Text = "LEAVE?";
                    blueLabel.Text = "Follow him?";
                    imageOutput.Image = Properties.Resources.ADAM_JOHNSON_PNG;
                    break;
                case 3:
                    outputLabel.Text = "You enter the mysterious room. There is a a dusty phone book on a pedestal in the room.";
                    redLabel.Text = "go back to lobby";
                    blueLabel.Text = "open the book";
                    imageOutput.Image = Properties.Resources.BOOK;
                    door.Play();
                    break;
                case 4:
                    outputLabel.Text = "He closes the door and suddenly covers your face with a chloroform towel. Next thing you know, you are in his apartment and he kills you! ";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    footsteps.Play();
                    wilhelm.Play();
                    break;
                case 5:
                    outputLabel.Text = "You open the phone book, the first thing you see in the book is the words written in red sharpie ' LOOK BEHIND___'";
                    redLabel.Text = "Look behind yourself?";
                    blueLabel.Text = "Ignore and keep reading the book";
                    imageOutput.Image = Properties.Resources.BOOK;
                    break;
                case 6:
                    outputLabel.Text = "ADAM JOHNSON IS BEHIND YOU AND BRUTALLY SLAUGHTERS YOU";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    imageOutput.Image = Properties.Resources.ADAM_JOHNSON_PNG;
                    wilhelm.Play();
                    break;
                case 7:
                    outputLabel.Text = "you ignore the writing, and you find the address, which is on Richmond st west ";
                    redLabel.Text = "you leave";
                    blueLabel.Text = "you leave";
                    imageOutput.Image = Properties.Resources.clearimage;
                    break;
                case 8:
                    outputLabel.Text = "You walk out of the lobby and head towards Richmond, while walking to Richmond you pass an alley that leads to the street you want to go to.";
                    redLabel.Text = "Walk down the alley";
                    blueLabel.Text = "Continue walking down the street";
                    footsteps.Play();
                    break;
                case 9:
                    outputLabel.Text = "You continue walking down the street, you cross the street to turn, and you get hit by a car and die on impact!";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    imageOutput.Image = Properties.Resources.ADAM_JOHNSON_PNG;
                    car.Play();
                    Thread.Sleep(6000);
                    wilhelm.Play();
                    break;
                case 10:
                    outputLabel.Text = "You walk down the alley and you see a suspicious figure, it appears to be Gianluigi Buffon! ";
                    redLabel.Text = "Ask Gian";
                    blueLabel.Text = "You dont ask for directions";
                    imageOutput.Image = Properties.Resources.Buffon_PNG_1;
                    break;
                case 11:
                    outputLabel.Text = "You walk down the alley and get lost, you look behind you and its ADAM JOHNSON ";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    imageOutput.Image = Properties.Resources.ADAM_JOHNSON_PNG;
                    wilhelm.Play();
                    break;
                case 12:
                    outputLabel.Text = "Buffon tells you the directions and you head on you way! You make it through the alley without any more incidents! You are out of the alley and find yourself onto the busy main street. You see a man running towards you";
                    redLabel.Text = "RUN";
                    blueLabel.Text = "SCREAM FOR HELP";
                    greenImage.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Put your fists up, and fight the man";
                    imageOutput.Image = Properties.Resources.clearimage;
                    break;
                case 13:
                    outputLabel.Text = "You run for your life but the man running towards you is Adams friend Aubameyang! He catches up to you and kills you!";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    imageOutput.Image = Properties.Resources.Aubameyang_PNG_1;
                    wilhelm.Play();
                    break;
                case 14:
                    outputLabel.Text = "You scream for help and Cristiano Ronaldo comes to the rescue and fights Aubameyang off for you to get away. You realize that Richmond st west is only a block away, but you have injured yourself for all this running, while walking a man named Neymar offers his assistance ";
                    redLabel.Text = "Tell him he is overrated and will never get a b'allon d'or";
                    blueLabel.Text = "Accept his help begrudgingly";
                    greenImage.Visible = false;
                    greenLabel.Visible = false;
                    imageOutput.Image = Properties.Resources.RONALDO_PNG;
                    break;
                case 15:
                    outputLabel.Text = "You power walk through and walk across the street, ADAM JOHNSON runs you over in his white toyota. You're dead";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    imageOutput.Image = Properties.Resources.White_Toyota_png;
                    car.Play();
                    Thread.Sleep(6000);
                    wilhelm.Play();
                    break;
                case 16:
                    outputLabel.Text = "He helps you to get to the antique record player store. You thank him";
                    redLabel.Text = "Enter the store";
                    blueLabel.Text = "Walk away";
                    imageOutput.Image = Properties.Resources.NEYMAR_PNG;
                    break;
                case 17:
                    outputLabel.Text = "For some reason after all this difficulty you deciede to walk away, Adam Johnson is waiting at the end of the block he kidnaps you, you were so close!";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    imageOutput.Image = Properties.Resources.ADAM_JOHNSON_PNG;
                    wilhelm.Play();
                    break;
                case 18:
                    outputLabel.Text = "Good job you got to the antique record player store. But now you have to make it back alive. TO BE CONTINUED....";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    imageOutput.Image = Properties.Resources.clearimage;
                    crowd.Play();
                    break;
                case 19:
                    outputLabel.Text = "Aubameyang beats you to death, maybe you shouldn't have tried to fight him";
                    redLabel.Text = "Restart";
                    blueLabel.Text = "Restart";
                    imageOutput.Image = Properties.Resources.Aubameyang_PNG_1;
                    greenImage.Visible = false;
                    greenLabel.Visible = false;
                    wilhelm.Play();
                    break;
                case 20:
                    outputLabel.Text = "You beat Aubameyang to death, You realize that Richmond st west is only a block away, but you have injured yourself for all this running and fighting, while walking a man named Neymar offers his assistance ";
                    redLabel.Text = "Tell him he is overrated and will never get a b'allon d'or";
                    blueLabel.Text = "Accept his help begrudgingly";
                    imageOutput.Image = Properties.Resources.NEYMAR_PNG;
                    greenImage.Visible = false;
                    greenLabel.Visible = false;
                    break;
                case 21:
                    outputLabel.Text = "You look behind you and nobody is there, you look back at the book and you find the address, which is on Richmond st west  ";
                    redLabel.Text = "you leave";
                    blueLabel.Text = "you leave";
                    break;
                default:
                    break;
            }
        }   
    }
}
