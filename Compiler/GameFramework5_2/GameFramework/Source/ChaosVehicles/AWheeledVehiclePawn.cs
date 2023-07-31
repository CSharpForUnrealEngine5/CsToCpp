#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ChaosWheeledVehicle is the base wheeled vehicle pawn actor.</summary>
[CppInclude("WheeledVehiclePawn.h")]
public partial class AWheeledVehiclePawn : APawn {
	///<summary>The main skeletal mesh associated with this Vehicle</summary>
	public USkeletalMeshComponent Mesh;
	///<summary>vehicle simulation component</summary>
	public UChaosVehicleMovementComponent VehicleMovementComponent;
}
