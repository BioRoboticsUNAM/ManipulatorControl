﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Robotics.API;
using Robotics.Controls;
using Robotics.Mathematics;

namespace ManipulatorControl
{
    public class CmdRaCloseGrip : AsyncCommandExecuter
    {
        TaskPlanner taskPlanner;

        public CmdRaCloseGrip(TaskPlanner taskPlanner)
            : base("ra_closegrip")
        {
            this.taskPlanner = taskPlanner;
        }

        public override bool ParametersRequired
        {
            get
            {
                return false;
            }
        }

        protected override Response AsyncTask(Command command)
        {
            TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Received: " + command.StringToSend);

            bool success = false;
            bool ObjectInHand;
			Response response;
            double force;

            if (command.HasParams)
            {
                if (this.taskPlanner.MovingRightArm)
                {
                    TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Right Arm is busy executing another command");
					response = Response.CreateFromCommand(command, false);
					TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Sent response: " + response.StringToSend);
					return response;
                }

                if (!double.TryParse(command.Parameters, out force))
                {
                    TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Can't parse parameters");
					response = Response.CreateFromCommand(command, false);
					TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Sent response: " + response.StringToSend);
					return response;
                }
                // antes de hand 
                success = this.taskPlanner.RaCloseGripper(force, out ObjectInHand);

                //if (!this.taskPlanner.UseRaHand)
                //    success = this.taskPlanner.RaCloseGripper(force, out ObjectInHand);
                //else
                //{
                //    success = this.taskPlanner.RaHand(0, 0, 0, 0);
                //    ObjectInHand = true; //Hard code 
                //}

                if (!this.taskPlanner.MovingLeftArm) 
                    this.CommandManager.Busy = false;
                
                command.Parameters = ObjectInHand.ToString();
				
                response = Response.CreateFromCommand(command, success);
				TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Sent response: " + response.StringToSend);
				return response;
            }
            else
            {
                if (this.taskPlanner.MovingRightArm)
                {
                    TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Right Arm is busy executing another command");
					response = Response.CreateFromCommand(command, false);
					TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Sent response: " + response.StringToSend);
					return response;
                }

				double defaultforce;
				if (this.taskPlanner.UseRaHand)
					defaultforce = 80;
				else
					defaultforce = 30;

				success = this.taskPlanner.RaCloseGripper(defaultforce, out ObjectInHand);         
                command.Parameters = ObjectInHand.ToString();

                if (!this.taskPlanner.MovingLeftArm)
                    this.CommandManager.Busy = false;
				response = Response.CreateFromCommand(command, success);
				TextBoxStreamWriter.DefaultLog.WriteLine("Cmd RaCloseGrip: Sent response: " + response.StringToSend);
				return response;
            }
        }

        public override void DefaultParameterParser(string[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
