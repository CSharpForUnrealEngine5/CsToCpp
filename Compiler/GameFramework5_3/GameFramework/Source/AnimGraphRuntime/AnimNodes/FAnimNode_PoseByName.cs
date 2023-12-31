namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Evaluates a point in an anim sequence, using a specific time input rather than advancing time internally.</summary>
[CppInclude("AnimNodes/AnimNode_PoseByName.h")]
public partial struct FAnimNode_PoseByName {
	public FName PoseName;
	public float PoseWeight;
}
