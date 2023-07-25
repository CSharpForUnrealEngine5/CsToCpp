#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/CoreSettings.h")]
///<summary>Implements the settings for garbage collection.</summary>
public partial class UGarbageCollectionSettings : UDeveloperSettings {
// GarbageCollectionSettings
	public float TimeBetweenPurgingPendingKillObjects;
	public bool FlushStreamingOnGC;
	public bool AllowParallelGC;
	public bool IncrementalBeginDestroyEnabled;
	public bool MultithreadedDestructionEnabled;
	public bool CreateGCClusters;
	public bool AssetClusteringEnabled;
	public bool ActorClusteringEnabled;
	public bool BlueprintClusteringEnabled;
	public bool UseDisregardForGCOnDedicatedServers;
	public bool VerifyGCObjectNames;
	public bool VerifyUObjectsAreNotFGCObjects;
	public bool PendingKillEnabled;
	public int MinGCClusterSize;
	public int NumRetriesBeforeForcingGC;
	public int MaxObjectsNotConsideredByGC;
	public int SizeOfPermanentObjectPool;
	public int MaxObjectsInGame;
	public int MaxObjectsInEditor;
}
