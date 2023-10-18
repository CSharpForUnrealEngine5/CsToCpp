namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Vehicle states datas that will be used in the states history to rewind the simulation at some point inn time</summary>
[CppInclude("ChaosVehicleManagerAsyncCallback.h")]
public partial struct FNetworkVehicleStates {
	public FVector StateLastVelocity;
	public TArray<float> WheelsOmega;
	public TArray<float> WheelsAngularPosition;
	public TArray<float> SuspensionLastDisplacement;
	public TArray<float> SuspensionLastSpringLength;
	public TArray<float> SuspensionAveragedLength;
	public TArray<int> SuspensionAveragedCount;
	public TArray<int> SuspensionAveragedNum;
	public float EngineOmega;
}
