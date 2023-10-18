namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolPlaneCut.h")]
public partial class UFracturePlaneCutSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Number of cutting planes. Only used when &quot;Use Gizmo&quot; is disabled</summary>
	public int NumberPlanarCuts;
	///<summary>bCanCutWithMultiplePlanes</summary>
	public bool bCanCutWithMultiplePlanes;
}
