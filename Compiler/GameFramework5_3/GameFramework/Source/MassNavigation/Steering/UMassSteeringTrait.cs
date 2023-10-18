namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Steering/MassSteeringTrait.h")]
public partial class UMassSteeringTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>MovingSteering</summary>
	public FMassMovingSteeringParameters MovingSteering;
	///<summary>StandingSteering</summary>
	public FMassStandingSteeringParameters StandingSteering;
}
