namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base component to handle the vehicle simulation for an actor.</summary>
[CppInclude("ChaosVehicleMovementComponent.h")]
public partial class UChaosVehicleMovementComponent : UPawnMovementComponent {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the brake and reverse controls will behave in a more arcade fashion where holding reverse also functions as brake. For a more realistic approach turn this off</summary>
	public bool bReverseAsBrake;
	///<summary>If true, when reversing the throttle will behave like a brake while the vehicle moving in a backwards direction - requires bReverseAsBrake to be enabled for operation</summary>
	public bool bThrottleAsBrake;
	///<summary>Mass to set the vehicle chassis to. It&#39;s much easier to tweak vehicle settings when</summary>
	public float Mass;
	///<summary>Enable to override the calculated COM position with your own fixed value - this prevents the vehicle handling changing when the asset changes</summary>
	public bool bEnableCenterOfMassOverride;
	///<summary>The center of mass override value, this value overrides the calculated COM and the COM offset value in the mesh is also ignored.</summary>
	public FVector CenterOfMassOverride;
	///<summary>Chassis width used for drag force computation (cm)</summary>
	public float ChassisWidth;
	///<summary>Chassis height used for drag force computation (cm)</summary>
	public float ChassisHeight;
	///<summary>DragCoefficient of the vehicle chassis - force resisting forward motion at speed</summary>
	public float DragCoefficient;
	///<summary>DownforceCoefficient of the vehicle chassis - force pressing vehicle into ground at speed</summary>
	public float DownforceCoefficient;
	///<summary>Drag area in Meters^2</summary>
	public float DragArea;
	///<summary>Debug drag magnitude last applied</summary>
	public float DebugDragMagnitude;
	///<summary>Scales the vehicle&#39;s inertia in each direction (forward, right, up)</summary>
	public FVector InertiaTensorScale;
	///<summary>Option to apply some aggressive sleep logic, larger number is more agressive, 0 disables</summary>
	public float SleepThreshold;
	///<summary>Option to apply some aggressive sleep logic if slopes up Z is less than this value, i.e value = Cos(SlopeAngle) so 0.866 will sleep up to 30 degree slopes</summary>
	public float SleepSlopeLimit;
	///<summary>Optional aerofoil setup - can be used for car spoilers or aircraft wings/elevator/rudder</summary>
	public TArray<FVehicleAerofoilConfig> Aerofoils;
	///<summary>Optional thruster setup, use one or more as your main engine or as supplementary booster</summary>
	public TArray<FVehicleThrustConfig> Thrusters;
	///<summary>Arcade style direct control of vehicle rotation via torque force</summary>
	public FVehicleTorqueControlConfig TorqueControl;
	///<summary>Arcade style direct control of vehicle rotation via torque force</summary>
	public FVehicleTargetRotationControlConfig TargetRotationControl;
	///<summary>Arcade style control of vehicle</summary>
	public FVehicleStabilizeControlConfig StabilizeControl;
	///<summary>True if the player is holding the handbrake</summary>
	public bool bRawHandbrakeInput;
	///<summary>True if the player is holding gear up</summary>
	public bool bRawGearUpInput;
	///<summary>True if the player is holding gear down</summary>
	public bool bRawGearDownInput;
	///<summary>Was avoidance updated in this frame?</summary>
	public bool bWasAvoidanceUpdated;
	///<summary>bParkEnabled</summary>
	public bool bParkEnabled;
	///<summary>Set the user input for the vehicle throttle [range 0 to 1]</summary>
	public void SetThrottleInput(float Throttle) {}
	///<summary>Increase the vehicle throttle position [throttle range normalized 0 to 1]</summary>
	public void IncreaseThrottleInput(float ThrottleDelta) {}
	///<summary>Decrease the vehicle throttle position  [throttle range normalized 0 to 1]</summary>
	public void DecreaseThrottleInput(float ThrottleDelta) {}
	///<summary>Set the user input for the vehicle Brake [range 0 to 1]</summary>
	public void SetBrakeInput(float Brake) {}
	///<summary>Set the user input for the vehicle steering [range -1 to 1]</summary>
	public void SetSteeringInput(float Steering) {}
	///<summary>Set the user input for the vehicle pitch [range -1 to 1]</summary>
	public void SetPitchInput(float Pitch) {}
	///<summary>Set the user input for the vehicle roll [range -1 to 1]</summary>
	public void SetRollInput(float Roll) {}
	///<summary>Set the user input for the vehicle yaw [range -1 to 1]</summary>
	public void SetYawInput(float Yaw) {}
	///<summary>Set the user input for handbrake</summary>
	public void SetHandbrakeInput(bool bNewHandbrake) {}
	///<summary>Set the vehicle in park mode</summary>
	public void SetParked(bool bParked) {}
	///<summary>Set the vehicle sleeping (bEnableSleep=true) or wake it up (bEnableSleep=false)</summary>
	public void SetSleeping(bool bEnableSleep) {}
	///<summary>Set the user input for gear up</summary>
	public void SetChangeUpInput(bool bNewGearUp) {}
	///<summary>Set the user input for gear down</summary>
	public void SetChangeDownInput(bool bNewGearDown) {}
	///<summary>Set the user input for gear (-1 reverse, 0 neutral, 1+ forward)</summary>
	public void SetTargetGear(int GearNum,bool bImmediate) {}
	///<summary>Set the flag that will be used to select auto-gears</summary>
	public void SetUseAutomaticGears(bool bUseAuto) {}
	///<summary>Set the flag that determines whether a controller is required to set control inputs</summary>
	public void SetRequiresControllerForInputs(bool bRequiresController) {}
	///<summary>Get current gear</summary>
	public int GetCurrentGear() { return default; }
	///<summary>Get target gear</summary>
	public int GetTargetGear() { return default; }
	///<summary>Are gears being changed automatically?</summary>
	public bool GetUseAutoGears() { return default; }
	///<summary>How fast the vehicle is moving forward</summary>
	public float GetForwardSpeed() { return default; }
	///<summary>How fast the vehicle is moving forward</summary>
	public float GetForwardSpeedMPH() { return default; }
	///<summary>Get the user input for the vehicle throttle - can use this to feed control to a connected trailer</summary>
	public float GetThrottleInput() { return default; }
	///<summary>Get the user input for the vehicle brake - can use this to feed control to a connected trailer</summary>
	public float GetBrakeInput() { return default; }
	///<summary>Get the user input for the vehicle handbrake - can use this to feed control to a connected trailer</summary>
	public bool GetHandbrakeInput() { return default; }
	///<summary>Get the user input for the vehicle steering - can use this to feed control to a connected trailer</summary>
	public float GetSteeringInput() { return default; }
	///<summary>Is the vehicle in park mode</summary>
	public bool IsParked() { return default; }
	///<summary>Reset some vehicle state - call this if you are say creating pool of vehicles that get reused and you don&#39;t want to carry over the previous state</summary>
	public void ResetVehicle() {}
	///<summary>EnableSelfRighting</summary>
	public void EnableSelfRighting(bool InState) {}
	///<summary>replicated state of vehicle</summary>
	public FVehicleReplicatedState ReplicatedState;
	///<summary>What the player has the steering set to. Range -1...1</summary>
	public float RawSteeringInput;
	///<summary>What the player has the accelerator set to. Range -1...1</summary>
	public float RawThrottleInput;
	///<summary>What the player has the brake set to. Range -1...1</summary>
	public float RawBrakeInput;
	///<summary>What the player has the pitch set to. Range -1...1</summary>
	public float RawPitchInput;
	///<summary>What the player has the roll set to. Range -1...1</summary>
	public float RawRollInput;
	///<summary>What the player has the yaw set to. Range -1...1</summary>
	public float RawYawInput;
	///<summary>Steering output to physics system. Range -1...1</summary>
	public float SteeringInput;
	///<summary>Accelerator output to physics system. Range 0...1</summary>
	public float ThrottleInput;
	///<summary>Brake output to physics system. Range 0...1</summary>
	public float BrakeInput;
	///<summary>Body Pitch output to physics system. Range -1...1</summary>
	public float PitchInput;
	///<summary>Body Roll output to physics system. Range -1...1</summary>
	public float RollInput;
	///<summary>Body Yaw output to physics system. Range -1...1</summary>
	public float YawInput;
	///<summary>Handbrake output to physics system. Range 0...1</summary>
	public float HandbrakeInput;
	///<summary>Bypass the need for a controller in order for the controls to be processed.</summary>
	public bool bRequiresControllerForInputs;
	///<summary>How much to press the brake when the player has release throttle</summary>
	public float IdleBrakeInput;
	///<summary>Auto-brake when absolute vehicle forward speed is less than this (cm/s)</summary>
	public float StopThreshold;
	///<summary>Auto-brake when vehicle forward speed is opposite of player input by at least this much (cm/s)</summary>
	public float WrongDirectionThreshold;
	///<summary>Rate at which input throttle can rise and fall</summary>
	public FVehicleInputRateConfig ThrottleInputRate;
	///<summary>Rate at which input brake can rise and fall</summary>
	public FVehicleInputRateConfig BrakeInputRate;
	///<summary>Rate at which input steering can rise and fall</summary>
	public FVehicleInputRateConfig SteeringInputRate;
	///<summary>Rate at which input handbrake can rise and fall</summary>
	public FVehicleInputRateConfig HandbrakeInputRate;
	///<summary>Rate at which input pitch can rise and fall</summary>
	public FVehicleInputRateConfig PitchInputRate;
	///<summary>Rate at which input roll can rise and fall</summary>
	public FVehicleInputRateConfig RollInputRate;
	///<summary>Rate at which input yaw can rise and fall</summary>
	public FVehicleInputRateConfig YawInputRate;
	///<summary>Pass current state to server</summary>
	public void ServerUpdateState(float InSteeringInput,float InThrottleInput,float InBrakeInput,float InHandbrakeInput,int InCurrentGear,float InRollInput,float InPitchInput,float InYawInput) {}
	///<summary>simulation code running on the physics thread async callback</summary>
	public AController OverrideController;
}
