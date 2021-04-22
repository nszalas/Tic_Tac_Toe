using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.ViewModel
{
    using BaseClass;
    using System.Diagnostics;
    using System.Windows.Input;

    class MainViewModel : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        //tablica z polami 
        private string[] fields = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public string[] Fields
        {
            get { return fields; }
        }


        //pole nr 1
        private string field1 = " ";
        
        public string Field1
        {
            
            get {
                return field1; }
            set
            {
                field1 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field1)));
                
            }
        }

        
        private Model.TicTac tictac = new Model.TicTac();


        //komenda dla buttona pola 1
        private ICommand tic1;
        
        public ICommand Tic1
        {
            get
            {

                return tic1 ?? ( tic1 = new RelayCommand(
                    p => { Field1=tictac.turn(Field1); Debug.Write("Tic1 działa \n"); Debug.Write(Field1); 
                        Fields[0] = Field1; Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field1 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }
                            if (Field1 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }



                        };
                    },
                    
                    p=> Field1 == " "? true:false)
                    
                );
            }
            set {  }
        }


        //pole nr 2
        private string field2 = " ";

        public string Field2
        {

            get
            {
                return field2;
            }
            set
            {
                field2 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field2)));

            }
        }


        //komenda dla buttona pola 2
        private ICommand tic2;

        public ICommand Tic2
        {
            get
            {

                return tic2 ?? (tic2 = new RelayCommand(
                    p => { Field2 = tictac.turn(Field2); Debug.Write("Tic1 działa \n"); Debug.Write(Field2); 
                        Fields[1] = Field2; Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field2 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }
                            if (Field2 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }



                        };
                    },

                    p => Field2 == " " ? true : false)

                );
            }
            set { }
        }




        //pole nr 3
        private string field3 = " ";

        public string Field3
        {

            get
            {
                return field3;
            }
            set
            {
                field3 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field3)));

            }
        }


        //komenda dla buttona pola 3
        private ICommand tic3;

        public ICommand Tic3
        {
            get
            {

                return tic3 ?? (tic3 = new RelayCommand(
                    p => { Field3 = tictac.turn(Field3); Debug.Write("Tic1 działa \n"); Debug.Write(Field3); 
                        Fields[2] = Field3; Debug.Write(Fields[3]); Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field3 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }
                            if (Field3 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }



                        };
                    },

                    p => Field3 == " " ? true : false)

                );
            }
            set { }
        }



        //pole nr 4
        private string field4 = " ";

        public string Field4
        {

            get
            {
                return field4;
            }
            set
            {
                field4 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field4)));

            }
        }


        //komenda dla buttona pola 4
        private ICommand tic4;

        public ICommand Tic4
        {
            get
            {

                return tic4 ?? (tic4 = new RelayCommand(
                    p => { Field4 = tictac.turn(Field4); Debug.Write("Tic1 działa \n"); Debug.Write(Field4); 
                        Fields[3] = Field4; Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field4 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }
                            if (Field4 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }



                        };
                    },

                    p => Field4 == " " ? true : false)

                );
            }
            set { }
        }






        //pole nr 5
        private string field5 = " ";

        public string Field5
        {

            get
            {
                return field5;
            }
            set
            {
                field5 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field5)));

            }
        }


        //komenda dla buttona pola 5
        private ICommand tic5;

        public ICommand Tic5
        {
            get
            {

                return tic5 ?? (tic5 = new RelayCommand(
                    p => { Field5 = tictac.turn(Field5); Debug.Write("Tic1 działa \n"); Debug.Write(Field5); 
                        Fields[4] = Field5; Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field5 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }
                            if (Field5 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }



                        }
                        ;
                    },

                    p => Field5 == " " ? true : false)

                );
            }
            set { }
        }





        //pole nr 6
        private string field6 = " ";

        public string Field6
        {

            get
            {
                return field6;
            }
            set
            {
                field6 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field6)));

            }
        }


        //komenda dla buttona pola 6
        private ICommand tic6;

        public ICommand Tic6
        {
            get
            {

                return tic6 ?? (tic6 = new RelayCommand(
                    p => { Field6 = tictac.turn(Field6); Debug.Write("Tic1 działa \n"); Debug.Write(Field6); 
                        Fields[5] = Field6; Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field6 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }
                            if (Field6 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }



                        };
                    },

                    p => Field6 == " " ? true : false)

                );
            }
            set { }
        }




        //pole nr 7
        private string field7 = " ";

        public string Field7
        {

            get
            {
                return field7;
            }
            set
            {
                field7 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field7)));

            }
        }


        //komenda dla buttona pola 7
        private ICommand tic7;

        public ICommand Tic7
        {
            get
            {

                return tic7 ?? (tic7 = new RelayCommand(
                    p => { Field7 = tictac.turn(Field7); Debug.Write("Tic1 działa \n"); Debug.Write(Field7); 
                        Fields[6] = Field7; Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field7 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }
                            if (Field7 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }



                        };
                    },

                    p => Field7 == " " ? true : false)

                );
            }
            set { }
        }



        //pole nr 8
        private string field8 = " ";

        public string Field8
        {

            get
            {
                return field8;
            }
            set
            {
                field8 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field8)));

            }
        }


        //komenda dla buttona pola 8
        private ICommand tic8;

        public ICommand Tic8
        {
            get
            {

                return tic8 ?? (tic8 = new RelayCommand(
                    p => { Field8 = tictac.turn(Field8); Debug.Write("Tic1 działa \n"); Debug.Write(Field8); 
                        Fields[7] = Field8; Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field8 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }
                            if (Field8 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;

                            }



                        };
                    },

                    p => Field8 == " " ? true : false)

                );
            }
            set { }
        }



        //pole nr 9
        private string field9 = " ";

        public string Field9
        {

            get
            {
                return field9;
            }
            set
            {
                field9 = value;
                Debug.Write(value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Field9)));

            }
        }


        //komenda dla buttona pola 1
        private ICommand tic9;

        public ICommand Tic9
        {
            get
            {

                return tic9 ?? (tic9 = new RelayCommand(
                    p => { Field9 = tictac.turn(Field9); Debug.Write("Tic1 działa \n"); Debug.Write(Field9); 
                        Fields[8] = Field9; Debug.Write(tictac.endGame(Fields));
                        if (tictac.endGame(Fields) == true)
                        {
                            Debug.Write("koniec gry");
                            if (Field9 == "X")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Xturn = $"Player2 {Name2} won!";
                                Oturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;
                                
                            }
                            if(Field9 == "O")
                            {
                                for (int i = 0; i < 9; i++)
                                {
                                    Fields[i] = " ";
                                };
                                Oturn = $"Player1 {Name1} won!";
                                Xturn = " ";
                                erase();
                                tictac.isPlayer1turn = true;
                                
                            }
                           


                        }
                        /* NIEZBYT PRZYDATNE ALE ZOSTAŁO NA WSZELKI WYPADEK
                         
                         else
                        {
                            Oturn = "Remis!";
                            Xturn = "Remis!";
                            for (int i = 0; i < 9; i++)
                            {
                                Fields[i] = " ";
                            };

                            erase();
                            tictac.isPlayer1turn = true;
                        }*/;
                        

                    },
                    p => Field9 == " " ? true : false)

                );
            }
            set { }
        }

       
        //funkcja oczyszczania danych
        public void erase()
        {
            field1 = " ";
            field2 = " ";
            field3 = " ";
            field4 = " ";
            field5 = " ";
            field6 = " ";
            field7 = " ";
            field8 = " ";
            field9 = " ";

            Field1 = " ";
            Field2 = " ";
            Field3 = " ";
            Field4 = " ";
            Field5 = " ";
            Field6 = " ";
            Field7 = " ";
            Field8 = " ";
            Field9 = " ";

            
        }

        //połączenie z informacją o wygranej Playera2
        private string xturn=" ";
        public string Xturn
        {
            get { return xturn; }
            set
            {
                xturn = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Xturn)));
            }
        }

        //połączenie z informacją o wygranej Playera1
        private string oturn = " ";
        public string Oturn
        {
            get { return oturn; }
            set
            {
                oturn = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Oturn)));
            }
        }


        //połączenie z imieniem Playera1
        //imiona można wpisywać, ale nie trzeba
        private string name1;

        public string Name1
        {
            get { return name1; }
            set
            {
                name1 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name1)));
            }
        }


        //połączenie z imieniem Playera2
        //imiona można wpisywać, ale nie trzeba
        private string name2;

        public string Name2
        {
            get { return name2; }
            set
            {
                
                name2 = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name2)));
            }
        }


        //funkcjonalność buttona start
        //gdy nie ma już pola do ruchu należy nacisnąć start - po prostu
        private ICommand start;

        public ICommand Start
        {
            get
            {
                return start ?? (start = new RelayCommand(
                    p =>
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            Fields[i] = " ";
                        };
                        erase();
                        Xturn = " ";
                        Oturn = $"Begin {Name1}!";
                        tictac.isPlayer1turn = true;
                    },
                    p => true));

            }
            set { }
        }
    }
}
