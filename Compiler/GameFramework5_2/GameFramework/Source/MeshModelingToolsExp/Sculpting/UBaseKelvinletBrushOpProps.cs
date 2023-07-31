#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/KelvinletBrushOp.h")]
public partial class UBaseKelvinletBrushOpProps : UMeshSculptBrushOpProps {
	///<summary>How much the mesh resists shear</summary>
	public float Stiffness;
	///<summary>How compressible the spatial region is: 1 - 2 x Poisson ratio</summary>
	public float Incompressiblity;
	///<summary>Integration steps</summary>
	public int BrushSteps;
}
