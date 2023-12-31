namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSmoothingBrushOps.h")]
public partial class UEraseBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply (0.0 - 1.0)</summary>
	public float Falloff;
}
