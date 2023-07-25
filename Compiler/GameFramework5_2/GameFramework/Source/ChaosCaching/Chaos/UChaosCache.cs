#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosCache.h")]
public partial class UChaosCache : UObject {
// ChaosCache
	public float RecordedDuration;
	public uint NumRecordedFrames;
	public TArray<int> TrackToParticle;
	public TArray<FPerParticleCacheData> ParticleTracks;
	public TMap<string,FRichCurves> ChannelsTracks;
	public TMap<string,FRichCurve> CurveData;
	public TMap<string,FCacheEventTrack> EventTracks;
	public FCacheSpawnableTemplate Spawnable;
	public FGuid AdapterGuid;
	public int Version;
}
