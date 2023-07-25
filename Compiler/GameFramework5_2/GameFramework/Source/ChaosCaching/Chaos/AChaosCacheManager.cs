#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/CacheManagerActor.h")]
public partial class AChaosCacheManager : AActor {
// ChaosCacheManager
	public UChaosCacheCollection CacheCollection;
	public ECacheMode CacheMode;
	public EStartMode StartMode;
	public float StartTime;
	public void SetStartTime(float InStartTime) {}
	public void ResetAllComponentTransforms() {}
	public void ResetSingleTransform(int InIndex) {}
	public void TriggerComponent(UObject InComponent) {}
	public void TriggerComponentByCache(string InCacheName) {}
	public void TriggerAll() {}
	public TArray<FObservedComponent> ObservedComponents;
}
