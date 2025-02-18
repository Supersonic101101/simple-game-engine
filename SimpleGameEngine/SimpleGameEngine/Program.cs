﻿using System;
using static System.Console;

class Program
{
    const int WIDTH = 20;
    const int HEIGHT = 20;

    //the speed increase to the game after picking up a pickup.
    const double SPEED_INCREASE = 0.1;

    //the speed the game will start at.
    const double START_SPEED = 3.5;

    private static Canvas canvas;
    private static Snake snake;
    private static Pickup pickup;
    private static int score;

    static void Main()
    {
        //Initializing our variables
        canvas = new Canvas(WIDTH, HEIGHT);
        snake = new Snake(WIDTH / 2, HEIGHT / 2, START_SPEED);
        pickup = new Pickup(WIDTH, HEIGHT);
        score = 0;

        //Drawing our snake on the canvas
        canvas.Draw(snake.X, snake.Y, 'O');

        //Writing the score at the top of the canvas
        canvas.WriteMessageTop("Score: 0");

        //Hiding the cursor in the console.
        Console.CursorVisible = false;

        //Starting the GameLoop
        GameLoop();
    }

    static void GameLoop()
    {
        //Create game loop
        while (true)
        {
            Time.Update();
            Input.Update();

            //check if esc was pressed so we can exit the game
            if (Input.KeyPressed == InputType.ESC)
            {
                canvas.WriteMessageBottom("Exiting Game...");
                WriteLine();
                break;
            }
            int prevSnakeX = snake.x;
            int prevSnakeY = snake.y;
            snake.Update();


            /*  ------------------------------------------
                4.2
                ------------------------------------------   
                Change the if statement below so that it will only be true
                if either the x or y position of the snake has changed since
                the last update.

                This will allow us to only make updates to the game
                if the snake moved.
            */
            if (true)
            {
                score + 100;
                canvas.WriteMessageTop("Score: " + score);
                snake.speed = START_SPEED + SPEED_INCREASE;
            }
            else if(IsSnakeInBounds = false || IsHeadTouchingBody = true)
            {
                canvas.WriteMessageBottom("Game Over :(");
                WriteLine();
                Beep();
                break;
            }

                

                //This method call will update the positions of all the snake segments.
                snake.UpdateSegments();
            canvas.Draw(snake.X, snake.Y, 'O', ConsoleColor.Green, ConsoleColor.Magenta);
            prevSnakeX = Clear();
            prevSnakeY = Clear();
                

                //draw pickup
                canvas.Draw(pickup.X, pickup.Y, '', ConsoleColor.Red);
            }
        }
    }

    static bool IsSnakeInBounds()
    {
         if(snake.X + snake.Y <= canvas.DrawBorder)
         {
             return true;
         }
    else
    {
        return false;
    }
    
        return IsSnakeInBounds;
    }
