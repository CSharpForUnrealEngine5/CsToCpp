#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshGroupPaintBrushOps.h")]
public partial class UGroupPaintBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>The group that will be assigned to triangles within the brush region</summary>
	public int Group;
	///<summary>If true, only triangles with no group assigned will be painted</summary>
	public bool bOnlyPaintUngrouped;
}
