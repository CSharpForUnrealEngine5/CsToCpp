#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes the input and output of an anim blueprint &#39;function&#39;</summary>
[CppInclude("Animation/AnimClassInterface.h")]
public partial struct FAnimBlueprintFunction {
	public string Name;
	public string Group;
	public int OutputPoseNodeIndex;
	public TArray<string> InputPoseNames;
	public TArray<int> InputPoseNodeIndices;
	public bool bImplemented;
}
