#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassSmartObjectFragments.h")]
///<summary>Fragment used by an entity to be able to interact with smart objects</summary>
public partial struct FMassSmartObjectUserFragment {
// MassSmartObjectUserFragment
	public FGameplayTagContainer UserTags;
	public FSmartObjectClaimHandle InteractionHandle;
	public EMassSmartObjectInteractionStatus InteractionStatus;
	public double InteractionCooldownEndTime;
}
