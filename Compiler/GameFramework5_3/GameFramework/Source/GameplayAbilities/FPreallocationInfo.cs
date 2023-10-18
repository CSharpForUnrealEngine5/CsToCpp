namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct for pooling and preallocating gameplaycuenotify_actor classes. This data is per world and used to track what actors are available to recycle and which classes need to preallocate instances of those actors</summary>
[CppInclude("GameplayCue_Types.h")]
public partial struct FPreallocationInfo {
	public TMap<UClass,FGameplayCueNotifyActorArray> PreallocatedInstances;
	public TArray<UClass> ClassesNeedingPreallocation;
}
