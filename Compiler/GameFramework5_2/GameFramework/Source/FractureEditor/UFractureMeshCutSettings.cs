#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolMeshCut.h")]
public partial class UFractureMeshCutSettings : UFractureToolSettings {
// FractureMeshCutSettings
	public TLazyObjectPtr<AStaticMeshActor> CuttingActor;
	public EMeshCutDistribution CutDistribution;
	public int NumberToScatter;
	public int GridX;
	public int GridY;
	public int GridZ;
	public float Variability;
	public float MinScaleFactor;
	public float MaxScaleFactor;
	public bool bRandomOrientation;
	public float RollRange;
	public float PitchRange;
	public float YawRange;
}
