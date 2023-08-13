namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Helper class for grouping actors in the level editor</summary>
[CppInclude("ActorGroupingUtils.h")]
public partial class UActorGroupingUtils : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>IsGroupingActive</summary>
	public static bool IsGroupingActive() { return default; }
	///<summary>SetGroupingActive</summary>
	public static void SetGroupingActive(bool bInGroupingActive) {}
	///<summary>Convenience method for accessing grouping utils in a blueprint or script</summary>
	public static UActorGroupingUtils Get() { return default; }
	///<summary>Creates a new group from the current selection removing the actors from any existing groups they are already in</summary>
	public virtual AGroupActor GroupSelected() { return default; }
	///<summary>Creates a new group from the provided list of actors removing the actors from any existing groups they are already in</summary>
	public virtual AGroupActor GroupActors(TArray<AActor> ActorsToGroup) { return default; }
	///<summary>Disbands any groups in the current selection, does not attempt to maintain any hierarchy</summary>
	public virtual void UngroupSelected() {}
	///<summary>Disbands any groups that the provided actors belong to, does not attempt to maintain any hierarchy</summary>
	public virtual void UngroupActors(TArray<AActor> ActorsToUngroup) {}
	///<summary>Locks any groups in the current selection</summary>
	public virtual void LockSelectedGroups() {}
	///<summary>Unlocks any groups in the current selection</summary>
	public virtual void UnlockSelectedGroups() {}
	///<summary>Activates &quot;Add to Group&quot; mode which allows the user to select a group to append current selection</summary>
	public virtual void AddSelectedToGroup() {}
	///<summary>Removes any groups or actors in the current selection from their immediate parent.</summary>
	public virtual void RemoveSelectedFromGroup() {}
}
