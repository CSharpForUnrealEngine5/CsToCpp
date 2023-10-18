namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSmoothingBrushOps.h")]
public partial class UFlattenBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply (0.0 - 1.0)</summary>
	public float Falloff;
	///<summary>Depth of Brush into surface along surface normal</summary>
	public float Depth;
	///<summary>Control whether effect of brush should be limited to one side of the Plane</summary>
	public EPlaneBrushSideMode WhichSide;
}
