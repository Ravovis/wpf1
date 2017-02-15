using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;


namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        enum Area { head, body, legs }
        
        Fight fight = new Fight(new Fighter(), new Fighter());
       

        class Fighter
        {

            int HP;
            public Fighter()
            {
                this.HP = 100;
            }
            public void GetHit(Area? attack)
            {
                switch (attack)
                {
                    case Area.legs:
                        this.HP -= 10;
                        break;
                    case Area.body:
                        this.HP -= 25;
                        break;
                    case Area.head:
                        this.HP -= 50;
                        break;
                }
            }
            public bool IsDead()
            {
                if (this.HP <= 0) return true;
                else return false;
            }
            public void GetInfo(TextBox t)
            {
                t.Text = "HP: " + (this.HP >= 0 ? this.HP : 0);
            }
        }








        class Fight
        {
            Fighter Player, Enemy;

            
            Area? Attack1, Attack2, Defence1, Defence2;

            public void setPlayerAttack(Area a)
            {
                Attack1 = a;
            }
            public void setPlayerDefence(Area a)
            {
                Defence1 = a;
            }

            public Fight(Fighter P, Fighter E)
            {
               
                Player = P;
                Enemy = E;
                Attack1 = null; Attack2 = null; Defence1 = null; Defence2 = null;
            }

            public void Init()
            {
                Random r = new Random();

                int answer;
                answer = r.Next(3) + 1;
                switch (answer)
                {
                    case 1:
                        Defence2 = Area.head;
                        break;
                    case 2:
                        Defence2 = Area.body;
                        break;
                    case 3:
                        Defence2 = Area.legs;
                        break;
                }

                answer = r.Next(3) + 1;
                switch (answer)
                {
                    case 1:
                        Attack2 = Area.head;
                        break;
                    case 2:
                        Attack2 = Area.body;
                        break;
                    case 3:
                        Attack2 = Area.legs;
                        break;
                }
            }

            public void NextTurn()
            {
                if ((Attack1 == null) || (Attack2 == null) || (Defence1 == null) || (Defence2 == null))
                {
                    MessageBox.Show("You didn't choose attack or defence");
                    return;
                }
                
                MainWindow _MainWindow = (MainWindow)Application.Current.MainWindow;
               
                if (Attack1 != Defence2)
                {
                    _MainWindow.InfoLabel.Content = "Succesfull attack";
                    
                    Enemy.GetHit(Attack1);

                    if (Enemy.IsDead())
                    {
                        Enemy.GetInfo(_MainWindow.EnemyBox);
                        MessageBox.Show("You have beated him!");
                        Enemy = null;
                        Environment.Exit(0);
                        return;
                    }

                }
                else
                {
                    _MainWindow.InfoLabel.Content =  "Enemy blocked an attack";
                }
                
                Enemy.GetInfo(_MainWindow.EnemyBox);

               // Thread.Sleep(2000);

                if (Attack2 != Defence1)
                {
                    _MainWindow.InfoLabel.Content =  "Enemy get you";
                    Player.GetHit(Attack2);

                    if (Player.IsDead())
                    {
                        Player.GetInfo(_MainWindow.PlayerBox);
                        MessageBox.Show("You are dead");
                        Player = null;
                        Environment.Exit(0);
                        return;
                    }
                }
                else
                {
                    _MainWindow.InfoLabel.Content = "You blocked an attack";
                }
                Player.GetInfo(_MainWindow.PlayerBox);
            }


            public bool IsEnded()
            {
                if (Player == null)
                {
                    
                    return true;
                }
                if (Enemy == null)
                {
                   
                    return true;
                }
                return false;
            }

        }



        private void Kick(object sender, RoutedEventArgs e)
        {
            fight.Init();
            fight.NextTurn();
        }

        private void RadioAttackButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string s = pressed.Content.ToString();
            if(s=="Head")
            {
                fight.setPlayerAttack(Area.head);
            }
            else if (s == "Body")
            {
                fight.setPlayerAttack(Area.body);
            }
            else if (s == "Legs")
            {
                fight.setPlayerAttack(Area.legs);
            }

        }

        private void RadioDefenceButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            string s = pressed.Content.ToString();

            if (s == "Head")
            {
                fight.setPlayerDefence(Area.head);
            }
            else if (s == "Body")
            {
                fight.setPlayerDefence(Area.body);
            }
            else if (s == "Legs")
            {
                fight.setPlayerDefence(Area.legs);
            }
        }

        public MainWindow()
        {
            
            
            InitializeComponent();

            
        }
       
    }
}
