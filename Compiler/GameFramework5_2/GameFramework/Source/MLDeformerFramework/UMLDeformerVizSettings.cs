#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MLDeformerVizSettings.h")]
///<summary>The vizualization settings.</summary>
public partial class UMLDeformerVizSettings : UObject {
// MLDeformerVizSettings
	public EMLDeformerVizMode VisualizationMode;
	public TSoftObjectPtr<UAnimSequence> TestAnimSequence;
	public TSoftObjectPtr<UMeshDeformer> DeformerGraph;
	public float AnimPlaySpeed;
	public int TrainingFrameNumber;
	public bool bDrawLabels;
	public float LabelHeight;
	public float LabelScale;
	public float MeshSpacing;
	public int TestingFrameNumber;
	public int QualityLevel;
	public bool bShowHeatMap;
	public EMLDeformerHeatMapMode HeatMapMode;
	public float HeatMapMax;
	public float GroundTruthLerp;
	public bool bDrawLinearSkinnedActor;
	public bool bDrawMLDeformedActor;
	public bool bDrawGroundTruthActor;
	public float Weight;
	public bool bDrawDeltas;
	public bool bXRayDeltas;
}
