using System;
using System.Collections.Generic;
using static System.Console;

public class Snake{
    private double x; //the x position of the snake
    private double y; //the y position of the snake

    private int xDir = 0; //the x direction of the snake

    private int yDir = 1; //the y direction of the snake

    private double speed; //the speed that the snake is moving at

    /*  A List holding all the SnakeSegments of the snake.
        List are like arrays, but you don't have to set a size.
        The name between <> specifies the type List stores. */
    private List<SnakeSegment> segments = new List<SnakeSegment>();

    public Snake(int x, int y, double speed){
        this.x = x;
        this.y = y;
        this.speed = speed;

        
        /*  Adds a segment to the segments List
            This segment will serve as the head of the snake. */
        segments.Add(new SnakeSegment(x,y,'O'));
    }

    /*  You will notice that we round the double x and y fields
        to integers before returning them as ints in our properties
        below.

        Our snake's x and y positions will only be increasing by fractions
        with every execution of our GameLoop (see the Update method in this class). 
        Our game canvas only supports whole numbers. 
        
        Returning our positions in this way means we keep the precision
        of our positions, but only expose whole numbers the can place our
        snake correctly on our canvas */
    public int X {
        /*  Math.Floor will round our value 
            down to the nearest whole number. 
            We still have to cast it to an int */
        get {return (int) Math.Floor(x);}
    }

    public int Y {
        get {return (int) Math.Floor(y);}
    }

    public double Speed {
        get { return speed; }
        set { speed = value; }
    }

    public List<SnakeSegment> Segments {
        get { return segments; }
    }

    public void AddSegment(){
        int lastSegment = segments.Add(new SnakeSegment(x, y, 'O'));
        Segments.Count(segments);

        int newSegment = lastSegment;
        Segments.Add(newSegment);
          
    }

    public void UpdateSegments(){
        /*  ------------------------------------------
            2.3
            ------------------------------------------   
            Update segments must update all the segments
            inside our segments List to their new positions.

            The X and Y position of the first segment in the list 
            must be set to the value of the X and Y properties of 
            our snake.

            The subsequent segments must have their X and Y position
            set to the PrevX and PrevY of the segment before it.

            You can use the segments.Count property to loop through
            the List of snake segments.  
        */
    }

    public bool IsHeadTouchingBody(){
        if(newSegment.x + newSegment.y = lastSegment.x + lastSegment.y)
        {
            return true;
        }
        else
        {
            return false;
        }

        return IsHeadTouchingBody;
    }

    public void Update(){
        if(Input.KeyPressed == InputType.UP){
            yDir = -1;
            xDir = 0;
        }
        else if(Input.KeyPressed == InputType.DOWN){
            yDir = 1;
            xDir = 0;
        }
        else if(Input.KeyPressed == InputType.LEFT)
        {
            yDir = 0;
            xDir = -1;
        }
        else if(Input.KeyPressed == InputType.RIGHT)
        {
            yDir = 0;
            xDir = 1;
        }

        /*  ------------------------------------------
            2.6
            ------------------------------------------
            We will now need to update the x and y positions of the snake
            using the equation:
                direction * speed * deltaTime
                
            -   We can say that the speed is in units per second.
            -   deltaTime gives use the time passed since the last update,
                which is usually less than a second an differs from one
                update to the next 
            -   If we multipy the direction with the speed * deltaTime
                we get the distance that our snake should have moved since
                the last update.

            Update the x position of the snake by adding distance travelled
            in the xDir since the last update.

            Do the same for the y position.

            REMEMBER: you can use the static Time class to access the 
            DeltaTime property.
        */
    }
}