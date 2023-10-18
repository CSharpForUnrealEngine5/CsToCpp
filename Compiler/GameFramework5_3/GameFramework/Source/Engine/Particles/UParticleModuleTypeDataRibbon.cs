namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/TypeData/ParticleModuleTypeDataRibbon.h")]
public partial class UParticleModuleTypeDataRibbon : UParticleModuleTypeDataBase {
	public static UClass StaticClass() {return default;}
	///<summary>The maximum amount to tessellate between two particles of the trail.</summary>
	public int MaxTessellationBetweenParticles;
	///<summary>The number of sheets to render for the trail.</summary>
	public int SheetsPerTrail;
	///<summary>The number of live trails</summary>
	public int MaxTrailCount;
	///<summary>Max particles per trail</summary>
	public int MaxParticleInTrailCount;
	///<summary>If true, when the system is deactivated, mark trails as dead.</summary>
	public bool bDeadTrailsOnDeactivate;
	///<summary>If true, when the source of a trail is &#39;lost&#39; (ie, the source particle</summary>
	public bool bDeadTrailsOnSourceLoss;
	///<summary>If true, do not join the trail to the source position</summary>
	public bool bClipSourceSegement;
	///<summary>If true, recalculate the previous tangent when a new particle is spawned</summary>
	public bool bEnablePreviousTangentRecalculation;
	///<summary>If true, recalculate tangents every frame to allow velocity/acceleration to be applied</summary>
	public bool bTangentRecalculationEveryFrame;
	///<summary>If true, ribbon will spawn a particle when it first starts moving</summary>
	public bool bSpawnInitialParticle;
	///<summary>The &#39;render&#39; axis for the trail (what axis the trail is stretched out on)</summary>
	public ETrailsRenderAxisOption RenderAxis;
	///<summary>The tangent scalar for spawning.</summary>
	public float TangentSpawningScalar;
	///<summary>If true, render the trail geometry (this should typically be on)</summary>
	public bool bRenderGeometry;
	///<summary>If true, render stars at each spawned particle point along the trail</summary>
	public bool bRenderSpawnPoints;
	///<summary>If true, render a line showing the tangent at each spawned particle point along the trail</summary>
	public bool bRenderTangents;
	///<summary>If true, render the tessellated path between spawned particles</summary>
	public bool bRenderTessellation;
	///<summary>The (estimated) covered distance to tile the 2nd UV set at.</summary>
	public float TilingDistance;
	///<summary>The distance step size for tessellation.</summary>
	public float DistanceTessellationStepSize;
	///<summary>If this flag is enabled, the system will scale the number of interpolated vertices</summary>
	public bool bEnableTangentDiffInterpScale;
	///<summary>The tangent scalar for tessellation.</summary>
	public float TangentTessellationScalar;
}
