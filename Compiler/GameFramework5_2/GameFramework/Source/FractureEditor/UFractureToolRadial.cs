#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolRadial.h")]
public partial class UFractureToolRadial : UFractureToolVoronoiCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>Radial Voronoi Fracture Input Settings</summary>
	public UFractureRadialSettings RadialSettings;
	///<summary>GizmoSettings</summary>
	public UFractureTransformGizmoSettings GizmoSettings;
}
