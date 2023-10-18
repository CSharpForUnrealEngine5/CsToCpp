namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ChaosWheeledVehicle is the base wheeled vehicle pawn actor.</summary>
[CppInclude("WheeledVehiclePawn.h")]
public partial class AWheeledVehiclePawn : APawn {
	public static UClass StaticClass() {return default;}
	///<summary>The main skeletal mesh associated with this Vehicle</summary>
	public USkeletalMeshComponent Mesh;
	///<summary>vehicle simulation component</summary>
	public UChaosVehicleMovementComponent VehicleMovementComponent;
}
