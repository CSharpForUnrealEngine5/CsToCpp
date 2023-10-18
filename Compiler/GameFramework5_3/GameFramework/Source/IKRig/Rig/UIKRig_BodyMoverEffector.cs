namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rig/Solvers/IKRig_BodyMover.h")]
public partial class UIKRig_BodyMoverEffector : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GoalName</summary>
	public FName GoalName;
	///<summary>BoneName</summary>
	public FName BoneName;
	///<summary>Scale the influence this effector has on the body. Range is 0-10. Default is 1.0.</summary>
	public float InfluenceMultiplier;
}
