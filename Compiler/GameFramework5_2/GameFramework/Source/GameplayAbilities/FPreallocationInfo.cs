#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayCue_Types.h")]
///<summary>Struct for pooling and preallocating gameplaycuenotify_actor classes. This data is per world and used to track what actors are available to recycle and which classes need to preallocate instances of those actors</summary>
public partial struct FPreallocationInfo {
// PreallocationInfo
	public TMap<UClass,FGameplayCueNotifyActorArray> PreallocatedInstances;
	public TArray<UClass> ClassesNeedingPreallocation;
}
