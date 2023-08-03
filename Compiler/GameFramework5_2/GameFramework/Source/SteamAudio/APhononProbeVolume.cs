#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Phonon Probe volumes generate a set of probes at which acoustic information will be sampled</summary>
[CppInclude("PhononProbeVolume.h")]
public partial class APhononProbeVolume : AVolume {
	public static UClass StaticClass() {return default;}
	///<summary>Method by which probes are placed within the volume.</summary>
	public EPhononProbePlacementStrategy PlacementStrategy;
	///<summary>How far apart to place probes.</summary>
	public float HorizontalSpacing;
	///<summary>How high above the floor to place probes.</summary>
	public float HeightAboveFloor;
	///<summary>Number of probes contained in this probe volume.</summary>
	public int NumProbes;
	///<summary>Size of probe data in bytes.</summary>
	public int ProbeDataSize;
	///<summary>Useful information for each baked source.</summary>
	public TArray<FBakedDataInfo> BakedDataInfo;
	///<summary>Component used for visualization.</summary>
	public UPhononProbeComponent PhononProbeComponent;
	///<summary>Current filename where probe box data is stored. Used to maintain connection if volume is renamed.</summary>
	public string ProbeBoxFileName;
	///<summary>Current filename where probe batch data is stored. Used to maintain connection if volume is renamed.</summary>
	public string ProbeBatchFileName;
}
