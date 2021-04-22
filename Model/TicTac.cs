using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Model
{
    class TicTac
    {

        public bool isPlayer1turn { get; set; } = true;
        

        public TicTac()
        {
            
        }

        public bool start(string name1, string name2)
        {
            if(name1 == String.Empty)
            {
                name1 = "Player1";
            }
            if(name2 == String.Empty)
            {
                name2 = "Player2";
            }

            return true;
        }

        public string turn(string field)
        {
            
            Debug.Write(field);
            if (isPlayer1turn == true)
            { 
                    field = "O";
                    isPlayer1turn = false;
                   
            }
            else
            {
                field = "X";
                isPlayer1turn = true;
                //jesli zajete to blad
            }
            Debug.Write(field);
            return field;
            
        }

        public bool endGame(string[] tab)
        {
            //rows win
            if(tab[0]==tab[1] & tab[1]==tab[2] & tab[1] != " ")
            {
                return true;
            }
            if (tab[3] == tab[4] & tab[4] == tab[5] & tab[4] != " ")
            {
                return true;
            }
            if (tab[6] == tab[7] & tab[7] == tab[8]& tab[7] != " " )
            {
                return true;
            }

            //columns win
            if (tab[0] == tab[3] & tab[3] == tab[6] & tab[3] != " ")
            {
                return true;
            }
            if (tab[1] == tab[4] & tab[4] == tab[7] & tab[4] != " ")
            {
                return true;
            }
            if (tab[2] == tab[5] & tab[5] == tab[8]& tab[5] != " " )   
            {

                return true;

            }

            //cross wins
            if (tab[0] == tab[4] & tab[4] == tab[8] & tab[4] != " " )
            {
                return true;
            }
            if (tab[2] == tab[4] & tab[4] == tab[6] & tab[4] != " " )
            {
                return true;
            }

            //continue game
            return false;       

        }


        
    }
}
