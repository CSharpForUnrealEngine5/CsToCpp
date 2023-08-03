#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Allows an agent to sense its avatar&#39;s location and velocity.</summary>
[CppInclude("Sensors/MLAdapterSensor_Movement.h")]
public partial class UMLAdapterSensor_Movement : UMLAdapterSensor {
	public static UClass StaticClass() {return default;}
	///<summary>bAbsoluteLocation</summary>
	public bool bAbsoluteLocation;
	///<summary>bAbsoluteVelocity</summary>
	public bool bAbsoluteVelocity;
	///<summary>RefLocation</summary>
	public FVector RefLocation;
	///<summary>RefVelocity</summary>
	public FVector RefVelocity;
	///<summary>CurrentLocation</summary>
	public FVector CurrentLocation;
	///<summary>CurrentVelocity</summary>
	public FVector CurrentVelocity;
}
