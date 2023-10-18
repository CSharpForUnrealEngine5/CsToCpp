namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshGroupPaintBrushOps.h")]
public partial class UGroupEraseBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Group to set as Erased value</summary>
	public int Group;
	///<summary>When enabled, only the current group configured in the Paint brush is erased</summary>
	public bool bOnlyEraseCurrent;
}
