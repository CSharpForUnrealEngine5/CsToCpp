#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_FootPlacement.h")]
public partial struct FAnimNode_FootPlacement {
	public EWarpingEvaluationMode PlantSpeedMode;
	public FBoneReference IKFootRootBone;
	public FBoneReference PelvisBone;
	public FFootPlacementPelvisSettings PelvisSettings;
	public TArray<FFootPlacemenLegDefinition> LegDefinitions;
	public FFootPlacementPlantSettings PlantSettings;
	public FFootPlacementInterpolationSettings InterpolationSettings;
	public FFootPlacementTraceSettings TraceSettings;
}
