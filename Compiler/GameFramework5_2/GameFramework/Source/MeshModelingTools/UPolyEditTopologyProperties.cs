namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditMeshPolygonsTool.h")]
public partial class UPolyEditTopologyProperties : UEditMeshPolygonsToolActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>When true, adds extra corners at sharp group edge bends (in addition to the normal corners that</summary>
	public bool bAddExtraCorners;
	///<summary>RegenerateExtraCorners</summary>
	public void RegenerateExtraCorners() {}
	///<summary>When generating extra corners, how sharp the angle needs to be to warrant an extra corner placement there. Lower values require</summary>
	public double ExtraCornerAngleThresholdDegrees;
}
