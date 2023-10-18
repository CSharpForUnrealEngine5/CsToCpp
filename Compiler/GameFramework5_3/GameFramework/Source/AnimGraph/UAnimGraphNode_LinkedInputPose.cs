namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimGraphNode_LinkedInputPose.h")]
public partial class UAnimGraphNode_LinkedInputPose : UAnimGraphNode_Base {
	public static UClass StaticClass() {return default;}
	///<summary>Node</summary>
	public FAnimNode_LinkedInputPose Node;
	///<summary>Inputs</summary>
	public TArray<FAnimBlueprintFunctionPinInfo> Inputs;
	///<summary>Reference to the stub function we use to build our parameters</summary>
	public FMemberReference FunctionReference;
	///<summary>The index of the input pose, used alongside FunctionReference to build parameters</summary>
	public int InputPoseIndex;
}
