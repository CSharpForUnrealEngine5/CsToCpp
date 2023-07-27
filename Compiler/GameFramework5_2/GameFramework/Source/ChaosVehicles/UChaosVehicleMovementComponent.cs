#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosVehicleMovementComponent.h")]
///<summary>Base component to handle the vehicle simulation for an actor.</summary>
public partial class UChaosVehicleMovementComponent : UPawnMovementComponent {
// ChaosVehicleMovementComponent
	public bool bReverseAsBrake;
	public bool bThrottleAsBrake;
	public float Mass;
	public bool bEnableCenterOfMassOverride;
	public FVector CenterOfMassOverride;
	public float ChassisWidth;
	public float ChassisHeight;
	public float DragCoefficient;
	public float DownforceCoefficient;
	public float DragArea;
	public float DebugDragMagnitude;
	public FVector InertiaTensorScale;
	public float SleepThreshold;
	public float SleepSlopeLimit;
	public TArray<FVehicleAerofoilConfig> Aerofoils;
	public TArray<FVehicleThrustConfig> Thrusters;
	public FVehicleTorqueControlConfig TorqueControl;
	public FVehicleTargetRotationControlConfig TargetRotationControl;
	public FVehicleStabilizeControlConfig StabilizeControl;
	public bool bRawHandbrakeInput;
	public bool bRawGearUpInput;
	public bool bRawGearDownInput;
	public bool bWasAvoidanceUpdated;
	public bool bParkEnabled;
	public  void SetThrottleInput(float Throttle) {}
	public  void IncreaseThrottleInput(float ThrottleDelta) {}
	public  void DecreaseThrottleInput(float ThrottleDelta) {}
	public  void SetBrakeInput(float Brake) {}
	public  void SetSteeringInput(float Steering) {}
	public  void SetPitchInput(float Pitch) {}
	public  void SetRollInput(float Roll) {}
	public  void SetYawInput(float Yaw) {}
	public  void SetHandbrakeInput(bool bNewHandbrake) {}
	public  void SetParked(bool bParked) {}
	public  void SetSleeping(bool bEnableSleep) {}
	public  void SetChangeUpInput(bool bNewGearUp) {}
	public  void SetChangeDownInput(bool bNewGearDown) {}
	public  void SetTargetGear(int GearNum,bool bImmediate) {}
	public  void SetUseAutomaticGears(bool bUseAuto) {}
	public  void SetRequiresControllerForInputs(bool bRequiresController) {}
	public  int GetCurrentGear() { return default; }
	public  int GetTargetGear() { return default; }
	public  bool GetUseAutoGears() { return default; }
	public  float GetForwardSpeed() { return default; }
	public  float GetForwardSpeedMPH() { return default; }
	public  float GetThrottleInput() { return default; }
	public  float GetBrakeInput() { return default; }
	public  bool GetHandbrakeInput() { return default; }
	public  float GetSteeringInput() { return default; }
	public  bool IsParked() { return default; }
	public  void ResetVehicle() {}
	public  void EnableSelfRighting(bool InState) {}
	public FVehicleReplicatedState ReplicatedState;
	public float RawSteeringInput;
	public float RawThrottleInput;
	public float RawBrakeInput;
	public float RawPitchInput;
	public float RawRollInput;
	public float RawYawInput;
	public float SteeringInput;
	public float ThrottleInput;
	public float BrakeInput;
	public float PitchInput;
	public float RollInput;
	public float YawInput;
	public float HandbrakeInput;
	public bool bRequiresControllerForInputs;
	public float IdleBrakeInput;
	public float StopThreshold;
	public float WrongDirectionThreshold;
	public FVehicleInputRateConfig ThrottleInputRate;
	public FVehicleInputRateConfig BrakeInputRate;
	public FVehicleInputRateConfig SteeringInputRate;
	public FVehicleInputRateConfig HandbrakeInputRate;
	public FVehicleInputRateConfig PitchInputRate;
	public FVehicleInputRateConfig RollInputRate;
	public FVehicleInputRateConfig YawInputRate;
	public  void ServerUpdateState(float InSteeringInput,float InThrottleInput,float InBrakeInput,float InHandbrakeInput,int InCurrentGear,float InRollInput,float InPitchInput,float InYawInput) {}
	public AController OverrideController;
}
