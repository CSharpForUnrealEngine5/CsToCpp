#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononProbeVolume.h")]
///<summary>Phonon Probe volumes generate a set of probes at which acoustic information will be sampled</summary>
public partial class APhononProbeVolume : AVolume {
// PhononProbeVolume
	public EPhononProbePlacementStrategy PlacementStrategy;
	public float HorizontalSpacing;
	public float HeightAboveFloor;
	public int NumProbes;
	public int ProbeDataSize;
	public TArray<FBakedDataInfo> BakedDataInfo;
	public UPhononProbeComponent PhononProbeComponent;
	public string ProbeBoxFileName;
	public string ProbeBatchFileName;
}
