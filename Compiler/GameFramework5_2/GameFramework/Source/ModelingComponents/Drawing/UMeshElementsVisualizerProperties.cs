#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/MeshElementsVisualizer.h")]
///<summary>Visualization settings UMeshElementsVisualizer</summary>
public partial class UMeshElementsVisualizerProperties : UInteractiveToolPropertySet {
// MeshElementsVisualizerProperties
	public bool bVisible;
	public bool bShowWireframe;
	public bool bShowBorders;
	public bool bShowUVSeams;
	public bool bShowNormalSeams;
	public bool bShowColorSeams;
	public float ThicknessScale;
	public FColor WireframeColor;
	public FColor BoundaryEdgeColor;
	public FColor UVSeamColor;
	public FColor NormalSeamColor;
	public FColor ColorSeamColor;
	public float DepthBias;
	public bool bAdjustDepthBiasUsingMeshSize;
}
