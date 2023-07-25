#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationModifier.h")]
public partial class UAnimationModifier : UObject {
// AnimationModifier
	public void OnApply(UObject AnimationSequence) {}
	public void OnRevert(UObject AnimationSequence) {}
	public bool bReapplyPostOwnerChange;
	public FGuid RevisionGuid;
	public FGuid AppliedGuid_DEPRECATED;
	public int StoredNativeRevision;
	public UAnimationModifier PreviouslyAppliedModifier_DEPRECATED;
}
