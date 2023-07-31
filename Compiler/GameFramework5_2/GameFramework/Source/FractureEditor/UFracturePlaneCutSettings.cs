#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolPlaneCut.h")]
public partial class UFracturePlaneCutSettings : UFractureToolSettings {
	///<summary>Number of cutting planes. Only used when &quot;Use Gizmo&quot; is disabled</summary>
	public int NumberPlanarCuts;
	///<summary>bCanCutWithMultiplePlanes</summary>
	public bool bCanCutWithMultiplePlanes;
}
