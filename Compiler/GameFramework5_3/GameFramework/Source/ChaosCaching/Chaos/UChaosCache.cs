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
	///<summary>Map a curve index in the cache to the original particle index specified when recording</summary>
	public TArray<int> ChannelCurveToParticle;
	///<summary>Per-particle data,  continuous per-frame data</summary>
	public TMap<FName,FRichCurves> ChannelsTracks;
	///<summary>CompressedChannelsTracks</summary>
	public TMap<FName,FCompressedRichCurves> CompressedChannelsTracks;
	///<summary>Per component/cache curve data, any continuous data that isn&#39;t per-particle can be stored here</summary>
	public TMap<FName,FRichCurve> CurveData;
	///<summary>NamedTransformTracks</summary>
	public TMap<FName,FParticleTransformTrack> NamedTransformTracks;
	///<summary>bCompressChannels</summary>
	public bool bCompressChannels;
	///<summary>ChannelsCompressionErrorThreshold</summary>
	public float ChannelsCompressionErrorThreshold;
	///<summary>ChannelsCompressionSampleRate</summary>
	public float ChannelsCompressionSampleRate;
	///<summary>Timestamped generic event tracks</summary>
	public TMap<FName,FCacheEventTrack> EventTracks;
	///<summary>Spawn template for an actor that can play this cache</summary>
	public FCacheSpawnableTemplate Spawnable;
	///<summary>GUID identifier for the adapter that spawned this cache</summary>
	public FGuid AdapterGuid;
	///<summary>Version for controlling conditioning of older caches to work with current system. Newly created caches should always be saved as CurrentVersion.</summary>
	public int Version;
}
