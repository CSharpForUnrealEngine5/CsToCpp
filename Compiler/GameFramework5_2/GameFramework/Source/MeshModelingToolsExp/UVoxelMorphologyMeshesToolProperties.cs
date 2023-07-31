#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties of the morphology tool</summary>
[CppInclude("VoxelMorphologyMeshesTool.h")]
public partial class UVoxelMorphologyMeshesToolProperties : UInteractiveToolPropertySet {
	///<summary>Operation</summary>
	public EMorphologyOperation Operation;
	///<summary>Distance</summary>
	public double Distance;
	///<summary>Apply a &quot;VoxWrap&quot; operation to input mesh(es) before computing the morphology.  Fixes results for inputs with holes and/or self-intersections.</summary>
	public bool bVoxWrap;
	///<summary>Remove internal surfaces from the VoxWrap output, before computing the morphology.</summary>
	public bool bRemoveInternalsAfterVoxWrap;
	///<summary>Thicken open-boundary surfaces (extrude them inwards) before VoxWrapping them. Units are in world space. If 0, no extrusion is applied.</summary>
	public double ThickenShells;
}
