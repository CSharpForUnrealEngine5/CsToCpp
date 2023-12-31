namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshPlaneBrushOps.h")]
public partial class UFixedPlaneBrushOpProps : UBasePlaneBrushOpProps {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of the Brush</summary>
	public float Strength;
	///<summary>Amount of falloff to apply</summary>
	public float Falloff;
	///<summary>Depth of Brush into surface relative to plane</summary>
	public float Depth;
	///<summary>Control whether effect of brush should be limited to one side of the Plane</summary>
	public EPlaneBrushSideMode WhichSide;
}
