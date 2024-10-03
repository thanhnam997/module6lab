using Module6lab;


//Create a new player with one life and add points to the player's score
Player player = new Player("Frankenstein", 1);
player.AddPoint(100);

//Display the player's score
Console.WriteLine("Welcome to the game! Your score is: " + player.Getscore() + 
    " You have " + player.GetLivesLeft() + " lives left!");

//Kill off the player's character
player.Kill();

//Let the player know their character was killed
Console.WriteLine("An orc attacks you. Sorry, you were killed. You have " 
    + player.GetLivesLeft() + " lives left!");