namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>this is anim segment that defines what animation and how *</summary>
[CppInclude("Animation/AnimCompositeBase.h")]
public partial struct FAnimSegment {
	public UAnimSequenceBase AnimReference;
	public float CachedPlayLength;
	public float StartPos;
	public float AnimStartTime;
	public float AnimEndTime;
	public float AnimPlayRate;
	public int LoopingCount;
}
