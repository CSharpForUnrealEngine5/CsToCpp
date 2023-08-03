#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshMoveBrushOps.h")]
public partial class UMoveBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
	///<summary>Depth of Brush into surface along view ray</summary>
	public float Depth;
	///<summary>Axis filters restrict mesh movement to World X/Y/Z axes</summary>
	public FModelingToolsAxisFilter AxisFilters;
}
