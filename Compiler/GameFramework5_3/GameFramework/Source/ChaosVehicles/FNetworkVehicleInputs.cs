namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Vehicle Inputs datas that will be used in the inputs history to be applied while simulating</summary>
[CppInclude("ChaosVehicleManagerAsyncCallback.h")]
public partial struct FNetworkVehicleInputs {
	public FControlInputs VehicleInputs;
	public float TransmissionChangeTime;
	public int TransmissionCurrentGear;
	public int TransmissionTargetGear;
}
