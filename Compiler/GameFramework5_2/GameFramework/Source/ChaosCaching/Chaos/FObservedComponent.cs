namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/CacheManagerActor.h")]
public partial struct FObservedComponent {
	public FName CacheName;
	public FComponentReference ComponentRef;
	public FSoftComponentReference SoftComponentRef;
	public bool bIsSimulating;
	public bool bPlaybackEnabled;
}
