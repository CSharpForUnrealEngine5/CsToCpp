namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Unit for getting a pose from an animation sequence</summary>
[CppInclude("Graph/RigUnit_AnimNextAnimSequence.h")]
public partial struct FRigUnit_AnimNext_AnimSequencePlayer {
	public FAnimSequenceParameters Parameters;
	public FAnimNextGraph_AnimSequence Sequence;
	public FAnimNextGraphLODPose LODPose;
}
