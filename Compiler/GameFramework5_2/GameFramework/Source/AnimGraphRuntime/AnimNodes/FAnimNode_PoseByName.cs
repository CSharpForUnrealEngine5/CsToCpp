#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluates a point in an anim sequence, using a specific time input rather than advancing time internally.</summary>
[CppInclude("AnimNodes/AnimNode_PoseByName.h")]
public partial struct FAnimNode_PoseByName {
	public string PoseName;
	public float PoseWeight;
}
