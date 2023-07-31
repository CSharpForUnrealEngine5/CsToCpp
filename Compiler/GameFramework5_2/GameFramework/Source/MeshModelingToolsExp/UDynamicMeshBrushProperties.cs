#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DynamicMeshSculptTool.h")]
public partial class UDynamicMeshBrushProperties : UInteractiveToolPropertySet {
	///<summary>BrushSize</summary>
	public FBrushToolRadius BrushSize;
	///<summary>Amount of falloff to apply (0.0 - 1.0)</summary>
	public float BrushFalloffAmount;
	///<summary>Depth of Brush into surface along view ray or surface normal, depending on the Active Brush Type</summary>
	public float Depth;
	///<summary>Allow the Brush to hit the back-side of the mesh</summary>
	public bool bHitBackFaces;
}
