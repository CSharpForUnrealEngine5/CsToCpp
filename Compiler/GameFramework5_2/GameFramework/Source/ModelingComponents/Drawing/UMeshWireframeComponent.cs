#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/MeshWireframeComponent.h")]
///<summary>UMeshWireframeComponent draws a mesh wireframe as lines, with line color/thickness</summary>
public partial class UMeshWireframeComponent : UMeshComponent {
// MeshWireframeComponent
	public float LineDepthBias;
	public float LineDepthBiasSizeScale;
	public float ThicknessScale;
	public bool bEnableWireframe;
	public FColor WireframeColor;
	public float WireframeThickness;
	public bool bEnableBoundaryEdges;
	public FColor BoundaryEdgeColor;
	public float BoundaryEdgeThickness;
	public bool bEnableUVSeams;
	public FColor UVSeamColor;
	public float UVSeamThickness;
	public bool bEnableNormalSeams;
	public FColor NormalSeamColor;
	public float NormalSeamThickness;
	public bool bEnableColorSeams;
	public FColor ColorSeamColor;
	public float ColorSeamThickness;
	public UMaterialInterface LineMaterial;
	public FBoxSphereBounds LocalBounds;
}
