namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationModifier.h")]
public partial class UAnimationModifier : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Executed when the Animation is initialized (native event for debugging / testing purposes)</summary>
	public void OnApply(UAnimSequence AnimationSequence) {}
	///<summary>OnRevert</summary>
	public void OnRevert(UAnimSequence AnimationSequence) {}
	///<summary>If this is set to true then the animation modifier will call it&#39;s reapply function after any change made to the owning asset.</summary>
	public bool bReapplyPostOwnerChange;
	///<summary>VisibleAnywhere for testing, Category = Revision</summary>
	public FGuid RevisionGuid;
	///<summary>VisibleAnywhere for testing, Category = Revision</summary>
	public FGuid AppliedGuid_DEPRECATED;
	///<summary>This holds the latest value returned by UpdateNativeRevisionGuid during the last PostLoad (changing this value will invalidate the GUIDs for all instances)</summary>
	public int StoredNativeRevision;
	///<summary>Serialized version of the modifier that has been previously applied to the Animation Asset</summary>
	public UAnimationModifier PreviouslyAppliedModifier_DEPRECATED;
}
