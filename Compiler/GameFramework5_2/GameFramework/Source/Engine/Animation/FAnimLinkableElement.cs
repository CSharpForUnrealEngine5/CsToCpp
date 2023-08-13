namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to describe an element that can be linked to a segment in a montage or sequence.</summary>
[CppInclude("Animation/AnimLinkableElement.h")]
public partial struct FAnimLinkableElement {
	public UAnimMontage LinkedMontage;
	public int SlotIndex;
	public int SegmentIndex;
	public EAnimLinkMethod LinkMethod;
	public EAnimLinkMethod CachedLinkMethod;
	public float SegmentBeginTime;
	public float SegmentLength;
	public float LinkValue;
	public UAnimSequenceBase LinkedSequence;
}
