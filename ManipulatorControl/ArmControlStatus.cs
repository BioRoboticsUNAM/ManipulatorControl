using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManipulatorControl
{
    public class ArmControlStatus
    {
        public ArmControlStatus()
        {
            this.Running = false;
            this.AreFilesLoaded = false;
            this.IsConnectedToBB = false;

			this.LeftArmEnable = true; 
			this.IsLeftArmReady = false;
			this.LeftArmStatus = "Not Ready";

			this.RightArmEnabled = true; 
			this.IsRightArmReady = false;
            this.RightArmStatus = "Not Ready";
			
			this.LAVoltage = 0;
			this.RAVoltage = 0;

            this.IsSharedVarEndEffectorTypeCreated = false; 
        }

		public double RAVoltage { get; set; }
		public double LAVoltage { get; set; }
        public bool Running { get; set; }

        public bool AreFilesLoaded { get; set; }

        public bool IsConnectedToBB { get; set; }
        public int CnnToBBPort { get; set; }
        public string CnnToBBStatus { get { return this.IsConnectedToBB ? this.CnnToBBPort.ToString() : "No Connected"; } }

        public bool AreVarsFromBBLoaded { get; set; }
        public bool IsSharedVarLeftArmPosCreated { get; set; }
        public bool IsSharedVarRightArmPosCreated { get; set; }
        public bool IsLowBatCreated { get; set; }
        public bool IsSharedVarEndEffectorTypeCreated { get; set; }
        public bool AreSharedVarsReady
        {
            get
            {
                return this.IsSharedVarLeftArmPosCreated && this.IsSharedVarRightArmPosCreated && this.IsLowBatCreated;
            }
        }

		public bool LeftArmEnable { get; set; }
		public bool IsLeftArmReady { get; set; }
        public string LeftArmStatus { get; set; }

		public bool RightArmEnabled { get; set; }
        public bool IsRightArmReady { get; set; }
        public string RightArmStatus { get; set; }

        public string LeftComPort { get; set; }
        public string RightComPort { get; set; }

        public bool IsSystemReady
        {
            get
            {
				bool leftArmStatus = !(this.LeftArmEnable ^ this.IsLeftArmReady);
				bool rightArmStatus  = !(this.RightArmEnabled ^ this.IsRightArmReady);

				return this.AreFilesLoaded && this.IsConnectedToBB && leftArmStatus && rightArmStatus;
            }
        }

		public string SystemStatus
		{
			get
			{
				return this.IsSystemReady ? "SYSTEM READY" : "SYSTEM NOT READY";
			}
		}
    }
}
