namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Fragment used by an entity to be able to interact with smart objects</summary>
[CppInclude("MassSmartObjectFragments.h")]
public partial struct FMassSmartObjectUserFragment {
	public FGameplayTagContainer UserTags;
	public FSmartObjectClaimHandle InteractionHandle;
	public EMassSmartObjectInteractionStatus InteractionStatus;
	public double InteractionCooldownEndTime;
}
