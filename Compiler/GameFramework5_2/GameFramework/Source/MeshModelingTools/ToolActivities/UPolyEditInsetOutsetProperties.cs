namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolActivities/PolyEditInsetOutsetActivity.h")]
public partial class UPolyEditInsetOutsetProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Amount of smoothing applied to outset boundary</summary>
	public float Softness;
	///<summary>Controls whether outset operation will move interior vertices as well as border vertices</summary>
	public bool bBoundaryOnly;
	///<summary>Tweak area scaling when solving for interior vertices</summary>
	public float AreaScale;
	///<summary>When insetting, determines whether vertices in inset region should be projected back onto input surface</summary>
	public bool bReproject;
	///<summary>bOutset</summary>
	public bool bOutset;
}
