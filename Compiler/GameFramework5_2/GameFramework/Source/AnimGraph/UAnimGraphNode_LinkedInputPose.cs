#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_LinkedInputPose.h")]
public partial class UAnimGraphNode_LinkedInputPose : UAnimGraphNode_Base {
// AnimGraphNode_LinkedInputPose
	public FAnimNode_LinkedInputPose Node;
	public TArray<FAnimBlueprintFunctionPinInfo> Inputs;
	public FMemberReference FunctionReference;
	public int InputPoseIndex;
}
