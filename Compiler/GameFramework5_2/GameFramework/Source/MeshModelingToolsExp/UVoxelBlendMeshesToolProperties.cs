#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties of the blend operation</summary>
[CppInclude("VoxelBlendMeshesTool.h")]
public partial class UVoxelBlendMeshesToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Blend power controls the shape of the blend between shapes</summary>
	public double BlendPower;
	///<summary>Blend falloff controls the size of the blend region</summary>
	public double BlendFalloff;
	///<summary>How to combine the shapes</summary>
	public EVoxelBlendOperation Operation;
	///<summary>Apply a &quot;VoxWrap&quot; operation to input mesh(es) before computing the blend.  Fixes results for inputs with holes and/or self-intersections.</summary>
	public bool bVoxWrap;
	///<summary>Remove internal surfaces from the VoxWrap output, before computing the blend.</summary>
	public bool bRemoveInternalsAfterVoxWrap;
	///<summary>Thicken open-boundary surfaces (extrude them inwards) before VoxWrapping them. Units are in world space. If 0 then no extrusion is applied.</summary>
	public double ThickenShells;
}
