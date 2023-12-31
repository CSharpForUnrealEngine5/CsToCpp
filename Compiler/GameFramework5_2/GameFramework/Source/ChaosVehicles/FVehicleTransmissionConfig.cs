namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
public partial struct FVehicleTransmissionConfig {
	public bool bUseAutomaticGears;
	public bool bUseAutoReverse;
	public float FinalRatio;
	public TArray<float> ForwardGearRatios;
	public TArray<float> ReverseGearRatios;
	public float ChangeUpRPM;
	public float ChangeDownRPM;
	public float GearChangeTime;
	public float TransmissionEfficiency;
}
