#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimLinkableElement.h")]
///<summary>Used to describe an element that can be linked to a segment in a montage or sequence.</summary>
public partial struct FAnimLinkableElement {
// AnimLinkableElement
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
