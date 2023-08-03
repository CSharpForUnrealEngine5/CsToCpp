#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptBrushOps.h")]
public partial class USculptMaxBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
	///<summary>Maximum height as fraction of brush size</summary>
	public float MaxHeight;
	///<summary>If true, maximum height is defined using the FixedHeight constant instead of brush-relative size</summary>
	public bool bUseFixedHeight;
	///<summary>Maximum height in world-space dimension</summary>
	public float FixedHeight;
}
