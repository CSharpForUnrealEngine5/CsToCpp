#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties of the trim mode</summary>
[CppInclude("CSGMeshesTool.h")]
public partial class UTrimMeshesToolProperties : UInteractiveToolPropertySet {
	///<summary>Which object to trim</summary>
	public ETrimOperation WhichMesh;
	///<summary>Whether to remove the surface inside or outside of the trimming geometry</summary>
	public ETrimSide TrimSide;
	///<summary>Threshold to determine whether a triangle in one mesh is inside or outside of the other</summary>
	public float WindingThreshold;
	///<summary>Whether to show a translucent version of the trimming mesh, to help visualize what is being cut</summary>
	public bool bShowTrimmingMesh;
	///<summary>Opacity of translucent version of the trimming mesh</summary>
	public float OpacityOfTrimmingMesh;
	///<summary>Color of translucent version of the trimming mesh</summary>
	public FLinearColor ColorOfTrimmingMesh;
}
