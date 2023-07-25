#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sensors/MLAdapterSensor_Movement.h")]
///<summary>Allows an agent to sense its avatar's location and velocity.</summary>
public partial class UMLAdapterSensor_Movement : UMLAdapterSensor {
// MLAdapterSensor_Movement
	public bool bAbsoluteLocation;
	public bool bAbsoluteVelocity;
	public FVector RefLocation;
	public FVector RefVelocity;
	public FVector CurrentLocation;
	public FVector CurrentVelocity;
}
