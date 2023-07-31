#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Animation node that allows a AnimNextInterfaceGraph output to be used in an animation graph</summary>
[CppInclude("AnimGraph/AnimNode_AnimNextInterfaceGraph.h")]
public partial struct FAnimNode_AnimNextInterfaceGraph {
	public FPoseLink Source;
	public UAnimNextInterfaceGraph AnimNextInterfaceGraph;
	public int LODThreshold;
}
