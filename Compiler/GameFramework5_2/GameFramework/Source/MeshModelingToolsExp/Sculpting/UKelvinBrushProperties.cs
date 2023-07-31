#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptToolBase.h")]
public partial class UKelvinBrushProperties : UInteractiveToolPropertySet {
	///<summary>Brush Fall off as fraction of brush size</summary>
	public float FallOffDistance;
	///<summary>How much the mesh resists shear</summary>
	public float Stiffness;
	///<summary>How compressible the spatial region is: 1 - 2 x Poisson ratio</summary>
	public float Incompressiblity;
	///<summary>Integration steps</summary>
	public int BrushSteps;
}
