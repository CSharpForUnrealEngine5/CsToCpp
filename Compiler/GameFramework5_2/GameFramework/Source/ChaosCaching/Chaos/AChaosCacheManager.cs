namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/CacheManagerActor.h")]
public partial class AChaosCacheManager : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>The Cache Collection asset to use for this observer. This can be used for playback and record simultaneously</summary>
	public UChaosCacheCollection CacheCollection;
	///<summary>How to use the cache - playback or record</summary>
	public ECacheMode CacheMode;
	///<summary>How to trigger the cache record or playback, timed will start counting at BeginPlay, Triggered will begin</summary>
	public EStartMode StartMode;
	///<summary>Defines the (random access) time that represents the rest pose of the components managed by this cache.</summary>
	public float StartTime;
	///<summary>Expose StartTime property to Sequencer. GetStartTime will be called on keys.</summary>
	public void SetStartTime(float InStartTime) {}
	///<summary>Resets all components back to the world space transform they had when the cache for them was originally recorded</summary>
	public void ResetAllComponentTransforms() {}
	///<summary>Resets the component at the specified index in the observed list back to the world space transform it had when the</summary>
	public void ResetSingleTransform(int InIndex) {}
	///<summary>Triggers a component to play or record.</summary>
	public void TriggerComponent(UPrimitiveComponent InComponent) {}
	///<summary>Triggers a component to play or record.</summary>
	public void TriggerComponentByCache(FName InCacheName) {}
	///<summary>Triggers the recording or playback of all observed components</summary>
	public void TriggerAll() {}
	///<summary>List of observed objects and their caches</summary>
	public TArray<FObservedComponent> ObservedComponents;
}
