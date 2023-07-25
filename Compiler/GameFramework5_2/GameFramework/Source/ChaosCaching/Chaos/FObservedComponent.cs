#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/CacheManagerActor.h")]
public partial struct FObservedComponent {
// ObservedComponent
	public string CacheName;
	public FComponentReference ComponentRef;
	public FSoftComponentReference SoftComponentRef;
	public bool bIsSimulating;
	public bool bPlaybackEnabled;
}
