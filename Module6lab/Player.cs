using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Module6lab {
   internal class Player{
//Attribute (characteristics that describe a player)
private string name;
private int score;
private int livesLeft;
public Player()
        {
        }    

//contructors - methods that creat a new instance of oject 
public Player(string name){
    this.name = name; //Sets the name of player on the name attribute
}//end constructor method

//creat a player that has both the name and liveleft set imediantely
public Player(string name,int startingLives){
    this.name = name ;//sets the name of the player 
    livesLeft = startingLives;

}//end contruction method
//method for the player class - action that the player can perform 
//return the player's current score
public int Getscore(){
    return score;
}//end getscore method
//add point tho the player's score
public void AddPoint(int totalPoints)
{
    score += totalPoints;
}   
   
   
    //kill method - it allows you to kill off player
public void Kill()
        {
            // We make sure they can't get negative lives.
            if (livesLeft > 0)
            {
                livesLeft--;

            }
        }
        public int GetLivesLeft()
        {
            return livesLeft;
        }

       
    } //end class
} //end namespace



