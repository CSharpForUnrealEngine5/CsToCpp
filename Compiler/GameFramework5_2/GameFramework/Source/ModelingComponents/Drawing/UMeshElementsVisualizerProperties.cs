namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Visualization settings UMeshElementsVisualizer</summary>
[CppInclude("Drawing/MeshElementsVisualizer.h")]
public partial class UMeshElementsVisualizerProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Should any be mesh elements be shown</summary>
	public bool bVisible;
	///<summary>Should mesh wireframe be shown</summary>
	public bool bShowWireframe;
	///<summary>Should mesh boundary edges be shown</summary>
	public bool bShowBorders;
	///<summary>Should mesh uv seam edges be shown</summary>
	public bool bShowUVSeams;
	///<summary>Should mesh normal seam edges be shown</summary>
	public bool bShowNormalSeams;
	///<summary>Should mesh color seam edges be shown</summary>
	public bool bShowColorSeams;
	///<summary>multiplier on edge thicknesses</summary>
	public float ThicknessScale;
	///<summary>Color of mesh wireframe</summary>
	public FColor WireframeColor;
	///<summary>Color of mesh boundary edges</summary>
	public FColor BoundaryEdgeColor;
	///<summary>Color of mesh UV seam edges</summary>
	public FColor UVSeamColor;
	///<summary>Color of mesh normal seam edges</summary>
	public FColor NormalSeamColor;
	///<summary>Color of mesh color seam edges</summary>
	public FColor ColorSeamColor;
	///<summary>depth bias used to slightly shift depth of lines</summary>
	public float DepthBias;
	///<summary>If true, the depth bias will be adjusted depending on the diagonal length of the mesh bounding box (smaller for smaller meshes).</summary>
	public bool bAdjustDepthBiasUsingMeshSize;
}
