#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for garbage collection.</summary>
[CppInclude("Engine/CoreSettings.h")]
public partial class UGarbageCollectionSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Time in seconds (game time) we should wait between purging object references to objects that are pending kill.</summary>
	public float TimeBetweenPurgingPendingKillObjects;
	///<summary>If enabled, streaming will be flushed each time garbage collection is triggered.</summary>
	public bool FlushStreamingOnGC;
	///<summary>If enabled, garbage collection will use multiple threads.</summary>
	public bool AllowParallelGC;
	///<summary>If true, the engine will destroy objects incrementally using time limit each frame.</summary>
	public bool IncrementalBeginDestroyEnabled;
	///<summary>If true, the engine will free objects&#39; memory on a worker thread.</summary>
	public bool MultithreadedDestructionEnabled;
	///<summary>If true, the engine will attempt to create clusters of objects for better garbage collection performance.</summary>
	public bool CreateGCClusters;
	///<summary>Whether to allow asset files to create actor clusters for GC.</summary>
	public bool AssetClusteringEnabled;
	///<summary>Whether to allow levels to create actor clusters for GC.</summary>
	public bool ActorClusteringEnabled;
	///<summary>Whether to allow Blueprint classes to create GC clusters.</summary>
	public bool BlueprintClusteringEnabled;
	///<summary>If false, DisregardForGC will be disabled for dedicated servers.</summary>
	public bool UseDisregardForGCOnDedicatedServers;
	///<summary>If true, the engine will verify if all FGCObject-derived classes define GetReferencerName() function overrides.</summary>
	public bool VerifyGCObjectNames;
	///<summary>If true, the engine will throw a warning when it detects a UObject-derived class which also derives from FGCObject or any of its members is derived from FGCObject.</summary>
	public bool VerifyUObjectsAreNotFGCObjects;
	///<summary>If true, objects marked as PendingKill will be automatically nulled and destroyed by Garbage Collector.</summary>
	public bool PendingKillEnabled;
	///<summary>Minimum GC cluster size.</summary>
	public int MinGCClusterSize;
	///<summary>Maximum number of times GC can be skipped if worker threads are currently modifying UObject state. 0 = never force GC</summary>
	public int NumRetriesBeforeForcingGC;
	///<summary>Maximum Object Count Not Considered By GC. Works only in cooked builds.</summary>
	public int MaxObjectsNotConsideredByGC;
	///<summary>Size Of Permanent Object Pool (bytes). Works only in cooked builds.</summary>
	public int SizeOfPermanentObjectPool;
	///<summary>Maximum number of UObjects that can exist in cooked game. Keep this as small as possible.</summary>
	public int MaxObjectsInGame;
	///<summary>Maximum number of UObjects that can exist in the editor game. Make sure this can hold enough objects for the editor and commadlets within reasonable limit.</summary>
	public int MaxObjectsInEditor;
}
