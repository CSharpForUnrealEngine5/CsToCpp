#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The vizualization settings.</summary>
[CppInclude("MLDeformerVizSettings.h")]
public partial class UMLDeformerVizSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The data to visualize.</summary>
	public EMLDeformerVizMode VisualizationMode;
	///<summary>The animation sequence to play on the skeletal mesh.</summary>
	public TSoftObjectPtr<UAnimSequence> TestAnimSequence;
	///<summary>The deformer graph to use on the asset editor&#39;s deformed test actor.</summary>
	public TSoftObjectPtr<UMeshDeformer> DeformerGraph;
	///<summary>The play speed factor of the test anim sequence.</summary>
	public float AnimPlaySpeed;
	///<summary>The frame number of the training data to visualize.</summary>
	public int TrainingFrameNumber;
	///<summary>Specifies whether we should draw the labels, such as &quot;Linear Skinned&quot; and &quot;ML Deformed&quot; or not.</summary>
	public bool bDrawLabels;
	///<summary>The height in units to draw the labels at.</summary>
	public float LabelHeight;
	///<summary>The scale of the label text.</summary>
	public float LabelScale;
	///<summary>The spacing between meshes.</summary>
	public float MeshSpacing;
	///<summary>The frame number of the test data to visualize.</summary>
	public int TestingFrameNumber;
	///<summary>* The ML Deformer LOD value. This is a continuous value between 0 and 1, where 0 means maximum quality and 1 means the lowest quality.</summary>
	public int QualityLevel;
	///<summary>Specify whether the heatmap is enabled or not.</summary>
	public bool bShowHeatMap;
	///<summary>Specifies what the heatmap colors should represent.</summary>
	public EMLDeformerHeatMapMode HeatMapMode;
	///<summary>Specifies how many centimeters the most intense color of the heatmap represents.</summary>
	public float HeatMapMax;
	///<summary>The Lerp factor from ML deformed model to ground truth model when in heat map mode.</summary>
	public float GroundTruthLerp;
	///<summary>Specifies whether we draw the linear skinned model or not.</summary>
	public bool bDrawLinearSkinnedActor;
	///<summary>Specifies whether we draw the ML Deformed model or not.</summary>
	public bool bDrawMLDeformedActor;
	///<summary>Specifies whether we draw the ground truth model or not.</summary>
	public bool bDrawGroundTruthActor;
	///<summary>The scale factor of the ML deformer deltas being applied on top of the linear skinned results.</summary>
	public float Weight;
	///<summary>Specifiy whether we want to draw the vertex deltas or not.</summary>
	public bool bDrawDeltas;
	///<summary>Specify whether the vertex deltas are rendered, even if they are behind the current mesh.</summary>
	public bool bXRayDeltas;
}
