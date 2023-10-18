namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Animation node that allows a AnimNextGraph output to be used in an animation graph</summary>
[CppInclude("Graph/AnimGraph/AnimNode_AnimNextGraph.h")]
public partial struct FAnimNode_AnimNextGraph {
	public FPoseLink SourceLink;
	public UAnimNextGraph AnimNextGraph;
	public UAnimSequence TestSequence;
	public int LODThreshold;
}
