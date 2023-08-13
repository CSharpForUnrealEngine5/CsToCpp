namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptBrushOps.h")]
public partial class UStandardSculptBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
}
