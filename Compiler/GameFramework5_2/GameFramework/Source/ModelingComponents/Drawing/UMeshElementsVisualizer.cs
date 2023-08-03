#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMeshElementsVisualizer is a subclass of UPreviewGeometry that displays mesh elements.</summary>
[CppInclude("Drawing/MeshElementsVisualizer.h")]
public partial class UMeshElementsVisualizer : UPreviewGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>Visualization settings</summary>
	public UMeshElementsVisualizerProperties Settings;
	///<summary>Mesh Wireframe component, draws wireframe, boundaries, UV seams, normal seams, color seams</summary>
	public UMeshWireframeComponent WireframeComponent;
}
