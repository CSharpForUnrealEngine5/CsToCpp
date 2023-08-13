namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/CacheManagerActor.h")]
public partial struct FObservedComponent {
	public string CacheName;
	public FComponentReference ComponentRef;
	public FSoftComponentReference SoftComponentRef;
	public bool bIsSimulating;
	public bool bPlaybackEnabled;
}
