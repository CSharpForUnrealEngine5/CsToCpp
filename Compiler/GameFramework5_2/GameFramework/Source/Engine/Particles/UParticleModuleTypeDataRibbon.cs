#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataRibbon.h")]
public partial class UParticleModuleTypeDataRibbon : UParticleModuleTypeDataBase {
// ParticleModuleTypeDataRibbon
	public int MaxTessellationBetweenParticles;
	public int SheetsPerTrail;
	public int MaxTrailCount;
	public int MaxParticleInTrailCount;
	public bool bDeadTrailsOnDeactivate;
	public bool bDeadTrailsOnSourceLoss;
	public bool bClipSourceSegement;
	public bool bEnablePreviousTangentRecalculation;
	public bool bTangentRecalculationEveryFrame;
	public bool bSpawnInitialParticle;
	public ETrailsRenderAxisOption RenderAxis;
	public float TangentSpawningScalar;
	public bool bRenderGeometry;
	public bool bRenderSpawnPoints;
	public bool bRenderTangents;
	public bool bRenderTessellation;
	public float TilingDistance;
	public float DistanceTessellationStepSize;
	public bool bEnableTangentDiffInterpScale;
	public float TangentTessellationScalar;
}
