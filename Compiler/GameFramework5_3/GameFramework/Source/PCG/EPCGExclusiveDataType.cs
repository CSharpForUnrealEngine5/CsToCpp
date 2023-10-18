namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PCGCommon.h")]
///<summary>As discussed just before, a parallel version for &quot;exclusive&quot; (as in only type) of the EPCGDataType enum. Needed for blueprint compatibility.</summary>
public enum EPCGExclusiveDataType {
	None=0,
	Point=1,
	Spline=2,
	LandscapeSpline=3,
	PolyLine=4,
	Landscape=5,
	Texture=6,
	RenderTarget=7,
	BaseTexture=8,
	Surface=9,
	Volume=10,
	Primitive=11,
	Concrete=12,
	Composite=13,
	Spatial=14,
	Param=15,
	Settings=16,
	Other=17,
	Any=18,
}
