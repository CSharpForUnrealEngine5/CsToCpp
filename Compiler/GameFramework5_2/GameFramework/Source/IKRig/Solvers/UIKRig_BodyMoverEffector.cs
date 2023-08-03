#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Solvers/IKRig_BodyMover.h")]
public partial class UIKRig_BodyMoverEffector : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GoalName</summary>
	public string GoalName;
	///<summary>BoneName</summary>
	public string BoneName;
	///<summary>Scale the influence this effector has on the body. Range is 0-10. Default is 1.0.</summary>
	public float InfluenceMultiplier;
}
