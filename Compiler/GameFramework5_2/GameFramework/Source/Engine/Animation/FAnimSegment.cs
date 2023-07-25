#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimCompositeBase.h")]
///<summary>this is anim segment that defines what animation and how *</summary>
public partial struct FAnimSegment {
// AnimSegment
	public UAnimSequenceBase AnimReference;
	public float CachedPlayLength;
	public float StartPos;
	public float AnimStartTime;
	public float AnimEndTime;
	public float AnimPlayRate;
	public int LoopingCount;
}
