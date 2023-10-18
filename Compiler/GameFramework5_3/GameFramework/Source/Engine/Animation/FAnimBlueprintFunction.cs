namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the input and output of an anim blueprint &#39;function&#39;</summary>
[CppInclude("Animation/AnimClassInterface.h")]
public partial struct FAnimBlueprintFunction {
	public FName Name;
	public FName Group;
	public int OutputPoseNodeIndex;
	public TArray<FName> InputPoseNames;
	public TArray<int> InputPoseNodeIndices;
	public bool bImplemented;
}
