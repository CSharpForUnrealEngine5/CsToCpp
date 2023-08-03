#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Avoidance/MassAvoidanceTrait.h")]
public partial class UMassObstacleAvoidanceTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>MovingParameters</summary>
	public FMassMovingAvoidanceParameters MovingParameters;
	///<summary>StandingParameters</summary>
	public FMassStandingAvoidanceParameters StandingParameters;
}
