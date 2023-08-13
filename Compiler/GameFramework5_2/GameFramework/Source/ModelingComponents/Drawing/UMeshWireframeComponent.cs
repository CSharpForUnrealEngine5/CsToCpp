namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeshWireframeComponent draws a mesh wireframe as lines, with line color/thickness</summary>
[CppInclude("Drawing/MeshWireframeComponent.h")]
public partial class UMeshWireframeComponent : UMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Depth bias of the lines, used to offset in depth to avoid z-fighting</summary>
	public float LineDepthBias;
	///<summary>Target-size depth bias scale. This is multiplied by LineDepthBias.</summary>
	public float LineDepthBiasSizeScale;
	///<summary>Scaling factor applied to the per-edge-type thicknesses defined below</summary>
	public float ThicknessScale;
	///<summary>Wireframe properties</summary>
	public bool bEnableWireframe;
	///<summary>WireframeColor</summary>
	public FColor WireframeColor;
	///<summary>WireframeThickness</summary>
	public float WireframeThickness;
	///<summary>Boundary Edge properties</summary>
	public bool bEnableBoundaryEdges;
	///<summary>BoundaryEdgeColor</summary>
	public FColor BoundaryEdgeColor;
	///<summary>BoundaryEdgeThickness</summary>
	public float BoundaryEdgeThickness;
	///<summary>UV seam properties</summary>
	public bool bEnableUVSeams;
	///<summary>UVSeamColor</summary>
	public FColor UVSeamColor;
	///<summary>UVSeamThickness</summary>
	public float UVSeamThickness;
	///<summary>normal seam properties</summary>
	public bool bEnableNormalSeams;
	///<summary>NormalSeamColor</summary>
	public FColor NormalSeamColor;
	///<summary>NormalSeamThickness</summary>
	public float NormalSeamThickness;
	///<summary>color seam properties</summary>
	public bool bEnableColorSeams;
	///<summary>ColorSeamColor</summary>
	public FColor ColorSeamColor;
	///<summary>ColorSeamThickness</summary>
	public float ColorSeamThickness;
	///<summary>LineMaterial</summary>
	public UMaterialInterface LineMaterial;
	///<summary>LocalBounds</summary>
	public FBoxSphereBounds LocalBounds;
}
