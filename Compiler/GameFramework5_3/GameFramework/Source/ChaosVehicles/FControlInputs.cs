namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control inputs holding the vehicle ones + persisten ones</summary>
[CppInclude("ChaosVehicleManagerAsyncCallback.h")]
public partial struct FControlInputs {
	public bool ParkingEnabled;
	public byte TransmissionType;
	public bool GearUpInput;
	public bool GearDownInput;
}
