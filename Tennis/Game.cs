using System;
namespace Tennis
{
    public class Game
    {
        private string player1Point { get; set; } = "0";
        private string player2Point { get; set; } = "0";

        public Game(){}

        public string returnPlayer1Score(){
            return player1Point;
        
        }

        public string returnPlayer2Score(){
            return player2Point;
        
        }

        public void addPointToPlayer1()
        {
            if (player1Point == "0"){
                player1Point = "15";
            }
            else if (player1Point == "15"){
                player1Point = "30";
            }
            else if (player1Point == "30"){
                player1Point = "40";
            }
            else if (player1Point == "40" && player2Point == "0"){
                player1Point = "W";
           }
            else if (player1Point == "40" && player2Point == "15"){
                player1Point = "W";
           }
            else if (player1Point == "40" && player2Point == "30"){
                player1Point = "W";
           }
            else if (player1Point == "40" && player2Point == "40"){
                player1Point = "A";
           }
            else if (player1Point == "40" && player2Point == "A"){
                player1Point = "40";
                player2Point = "40";
           }
            else if (player1Point == "A" || player2Point == "40"){
                player1Point = "W";
           }

        }

        public void  addPointToPlayer2()
        {

            if (player2Point == "0"){
                player2Point = "15";
            }
            else if (player2Point == "15"){
                player2Point = "30";
            }
            else if (player2Point == "30"){
                player2Point = "40";
            }
            else if (player2Point == "40" && player1Point == "0"){
                player2Point = "W";
           }
            else if (player2Point == "40" && player1Point == "15"){
                player2Point = "W";
           }
            else if (player2Point == "40" && player1Point == "30"){
                player2Point = "W";
           }
            else if (player2Point == "40" && player1Point == "40"){
                player2Point = "A";
           }
            else if (player2Point == "40" && player1Point == "A"){
                player1Point = "40";
                player2Point = "40";
           }
            else if (player2Point == "A" || player1Point == "40"){
                player1Point = "W";
           }
        }

        public bool player1Won()
        {
        
            if (returnPlayer1Score() == "W"){
                return true;
        }
            return false;
        
        }

        public bool player2Won()
        {
        
        if (returnPlayer2Score() == "W"){
                return true;
        }
            return false;
        
        }

        public bool completeGame()
        {

        if (player1Won() == true || player2Won() == true){
                return true;
        }
            return false;
    }
    }
}
