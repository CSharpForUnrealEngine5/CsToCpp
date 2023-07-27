#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ActorGroupingUtils.h")]
///<summary>Helper class for grouping actors in the level editor</summary>
public partial class UActorGroupingUtils : UObject {
// ActorGroupingUtils
	public static bool IsGroupingActive() { return default; }
	public static void SetGroupingActive(bool bInGroupingActive) {}
	public static UActorGroupingUtils Get() { return default; }
	public  AGroupActor GroupSelected() { return default; }
	public  AGroupActor GroupActors(TArray<AActor> ActorsToGroup) { return default; }
	public  void UngroupSelected() {}
	public  void UngroupActors(TArray<AActor> ActorsToUngroup) {}
	public  void LockSelectedGroups() {}
	public  void UnlockSelectedGroups() {}
	public  void AddSelectedToGroup() {}
	public  void RemoveSelectedFromGroup() {}
}
