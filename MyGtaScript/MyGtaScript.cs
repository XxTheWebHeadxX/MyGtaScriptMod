using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using GTA;

namespace MyGtaScript
{
    public class MyGtaScript : Script
    {
        public MyGtaScript()
        {
            Game.DisplayText("MyGtaScript Loaded");
            this.KeyDown += new GTA.KeyEventHandler(this.MyGtaScript_KeyDownHandler);
            //this.KeyUp += new GTA.KeyEventHandler(this.MyGtaScript_KeyUpHandler);
        }

        public void MyGtaScript_KeyDownHandler(object sender, GTA.KeyEventArgs e) 
        {
            if (e.Key == Keys.N)
            {
                //Game.DisplayText("ET Phone HOME!!!");
                //Player.Character.Velocity = new Vector3(0, 0, 50);
                //Player.Character.isRagdoll = true;
                Vector3 vehVect = new Vector3(Player.Character.Position.X,
                    Player.Character.Position.Y,
                    Player.Character.Position.Z+50);

                Vehicle liftVeh = World.CreateVehicle(new Model("NRG-900"),vehVect);
                //liftVeh.Visible = false;
                //liftVeh.Metadata.ID = 1;

                Vector3 liftoffset = new Vector3(liftVeh.Position.X,
                    liftVeh.Position.Y,
                    liftVeh.Position.Z - 5);


                //Player.Character.AttachTo(liftVeh,liftoffset);
                //liftVeh.Velocity = new Vector3(0, 0, 50);
            }
        }

        //public void MyGtaScript_KeyUpHandler(object sender, GTA.KeyEventArgs e)
        //{
        //    if (e.Key == Keys.N)
        //    {
        //        Player.Character.Detach();
        //        GTA.Vehicle[] vehs = World.GetAllVehicles();
        //        foreach (Vehicle v in vehs)
        //        {
        //            if (v.Metadata.ID == 1)
        //            {
        //                v.Delete();
        //            }
        //        }
        //    }
        //}
    }
}
