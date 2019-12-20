using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Robocode;
using Robocode.RobotInterfaces;
using Robocode.Util;

namespace TCE_KalashCriminou
{
    class TCE_KalashCriminou : RateControlRobot, IPaintRobot
    {
        string trackName;
        int count;
        double gunTurn;

        Random num = new Random();
        int entier = 0;

        int vitesse = 200;
        /*public override void OnPaint(IGraphics g)
        {
            while (true)
            {
                var transparentPink = new SolidBrush(Color.FromArgb(253, 108, 158));
                Graphics.FillEllipse(transparentPink, (int)(X - 60), (int)(Y - 60), 120, 120);
                Graphics.DrawEllipse(Pens.Red, (int)(X - 50), (int)(Y - 50), 100, 100);
            }

        }*/
        public override void Run()
        {
            BodyColor = (Color.Pink);
            GunColor = (Color.White);
            RadarColor = (Color.Red);
            BulletColor = (Color.White);

            /* while (true)
             {
                 double x = X;
                 double y = Y;
                 if(x>xmap/2 && y>ymap/2)
                 {
                         SetAhead(vitesse);
                         TurnRight(entier);
                     if (Heading >= 0 && Heading < 90)
                     {
                         SetAhead(vitesse);
                         TurnRight(entier);
                     }
                 }
                 if (x <= xmap / 2 && y <= ymap / 2)
                 {
                     SetAhead(vitesse);
                     TurnLeft(entier);
                     if (Heading >= 90 && Heading < 180)
                     {
                         SetAhead(vitesse);
                         TurnRight(entier);
                     }
                 }
                 if (x > xmap / 2 && y <= ymap / 2)
                 {
                     SetAhead(vitesse);
                     TurnRight(entier);
                     if (Heading >= 180 && Heading < 270)
                     {
                         SetAhead(vitesse);
                         TurnRight(entier);
                     }
                 }
                 if (x <= xmap / 2 && y > ymap / 2)
                 {
                     SetAhead(vitesse);
                     TurnLeft(entier);
                     if (Heading >= 270 && Heading < 360)
                     {
                         SetAhead(vitesse);
                         TurnRight(entier);
                     }
                 }
                 entier = num.Next(0,100);

                 /*if (entier <=50)
                 {


                 }
                 else
                 {
                     SetAhead(1000);
                     TurnLeft(entier);

                 }*/
            trackName = null;
            IsAdjustGunForRobotTurn = true;

            gunTurn = 10;
            while (true)
            {



                count++;

                if (count > 2)
                {
                    gunTurn = -5;
                    TurnGunRight(gunTurn);
                }

                if (count > 5)
                {
                    gunTurn = 5;
                    TurnGunLeft(gunTurn);
                }

                if (count > 11)
                {
                    trackName = null;
                }
            }
        }



        public override void OnHitWall(HitWallEvent evnt)
        {
            TurnRight(Heading + 90);
            SetAhead(500);

        }

        public override void OnScannedRobot(ScannedRobotEvent evnt)
        {
            double xmap = BattleFieldWidth;
            double ymap = BattleFieldHeight;
            if (trackName != null && !evnt.Name.Equals(trackName))
            {
                return;
            }
            if (trackName == null)
            {
                trackName = evnt.Name;
            }
            count = 0;

            if (evnt.Distance > 150)
            {
                gunTurn = Utils.NormalRelativeAngleDegrees(evnt.Bearing + (Heading - RadarHeading));
                vitesse = 500;
                TurnGunRight(gunTurn);
                TurnRight(evnt.Bearing);
                double x = X;
                double y = Y;
                if (x > xmap / 2 && y > ymap / 2)
                {
                    SetAhead(vitesse);
                    TurnRight(entier);
                    if (Heading >= 0 && Heading < 90)
                    {
                        SetAhead(vitesse);
                        TurnRight(entier);

                    }
                }
                if (x <= xmap / 2 && y <= ymap / 2)
                {
                    SetAhead(vitesse);
                    TurnLeft(entier);
                    if (Heading >= 90 && Heading < 180)
                    {
                        SetAhead(vitesse);
                        TurnRight(entier);

                    }
                }
                if (x > xmap / 2 && y <= ymap / 2)
                {
                    SetAhead(vitesse);
                    TurnRight(entier);
                    if (Heading >= 180 && Heading < 270)
                    {
                        SetAhead(vitesse);
                        TurnRight(entier);

                    }
                }

                if (x <= xmap / 2 && y > ymap / 2)
                {
                    SetAhead(vitesse);
                    TurnLeft(entier);
                    if (Heading >= 270 && Heading < 360)
                    {
                        SetAhead(vitesse);
                        TurnRight(entier);

                    }
                }
                entier = num.Next(0, 100);


                //Ahead(evnt.Distance - 100);

            }


            gunTurn = Utils.NormalRelativeAngleDegrees(evnt.Bearing + (Heading - RadarHeading));
            TurnGunRight(gunTurn);
            Fire(3);


            if (evnt.Distance < 100)
            {
                if (evnt.Bearing > -90 && evnt.Bearing <= 90)
                {

                    Back(40);
                    Fire(3);
                }
                else
                {
                    Ahead(40);
                    Fire(3);
                }
            }
            Scan();
        }
        public override void OnWin(WinEvent evnt)
        {
            for (int i = 0; i < 50; i++)
            {
                TurnLeft(30);
                TurnRight(30);
            }
        }




    }


}
