#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorGroupingUtils.h")]
///<summary>Helper class for grouping actors in the level editor</summary>
public partial class UActorGroupingUtils : UObject {
// ActorGroupingUtils
	public bool IsGroupingActive() { return default; }
	public void SetGroupingActive(bool bInGroupingActive) {}
	public UObject Get() { return default; }
	public UObject GroupSelected() { return default; }
	public UObject GroupActors(TArray<UObject> ActorsToGroup) { return default; }
	public void UngroupSelected() {}
	public void UngroupActors(TArray<UObject> ActorsToUngroup) {}
	public void LockSelectedGroups() {}
	public void UnlockSelectedGroups() {}
	public void AddSelectedToGroup() {}
	public void RemoveSelectedFromGroup() {}
}
