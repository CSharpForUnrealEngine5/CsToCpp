#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshPinchBrushOps.h")]
public partial class UPinchBrushOpProps : UMeshSculptBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
	///<summary>Depth of Brush into surface along surface normal</summary>
	public float Depth;
	///<summary>When enabled, brush will damp motion of vertices that would move perpendicular to brush stroke direction</summary>
	public bool bPerpDamping;
}
