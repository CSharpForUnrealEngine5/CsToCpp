namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosCache.h")]
public partial class UChaosCache : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>RecordedDuration</summary>
	public float RecordedDuration;
	///<summary>NumRecordedFrames</summary>
	public uint NumRecordedFrames;
	///<summary>Maps a track index in the cache to the original particle index specified when recording</summary>
	public TArray<int> TrackToParticle;
	///<summary>Per-particle data, includes transforms, velocities and other per-particle, per-frame data</summary>
	public TArray<FPerParticleCacheData> ParticleTracks;
	///<summary>Per-particle data, includes transforms, velocities and other per-particle, per-frame data</summary>
	public TMap<string,FRichCurves> ChannelsTracks;
	///<summary>Per component/cache curve data, any continuous data that isn&#39;t per-particle can be stored here</summary>
	public TMap<string,FRichCurve> CurveData;
	///<summary>Timestamped generic event tracks</summary>
	public TMap<string,FCacheEventTrack> EventTracks;
	///<summary>Spawn template for an actor that can play this cache</summary>
	public FCacheSpawnableTemplate Spawnable;
	///<summary>GUID identifier for the adapter that spawned this cache</summary>
	public FGuid AdapterGuid;
	///<summary>Version for controlling conditioning of older caches to work with current system. Newly created caches should always be saved as CurrentVersion.</summary>
	public int Version;
}
