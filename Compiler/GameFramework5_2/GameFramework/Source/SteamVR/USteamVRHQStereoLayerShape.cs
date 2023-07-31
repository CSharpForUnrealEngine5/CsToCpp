#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SteamVRHQLayerShape.h")]
public partial class USteamVRHQStereoLayerShape : UStereoLayerShapeQuad {
	///<summary>bCurved</summary>
	public bool bCurved;
	///<summary>bAntiAlias</summary>
	public bool bAntiAlias;
	///<summary>For curved layers, sets the minimum distance from the layer used to automatically curve</summary>
	public float AutoCurveMinDistance;
	///<summary>For curved layers, sets the maximum distance from the layer used to automatically curve</summary>
	public float AutoCurveMaxDistance;
	///<summary>SetCurved</summary>
	public  void SetCurved(bool InCurved) {}
	///<summary>SetAntiAlias</summary>
	public  void SetAntiAlias(bool InAntiAlias) {}
	///<summary>SetAutoCurveMinDistance</summary>
	public  void SetAutoCurveMinDistance(float InDistance) {}
	///<summary>SetAutoCurveMaxDistance</summary>
	public  void SetAutoCurveMaxDistance(float InDistance) {}
}
