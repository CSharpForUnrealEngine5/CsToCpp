namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolCustomVoronoi.h")]
public partial class UFractureToolCustomVoronoi : UFractureToolVoronoiCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>CustomVoronoi Voronoi Fracture Input Settings</summary>
	public UFractureCustomVoronoiSettings CustomVoronoiSettings;
	///<summary>GizmoSettings</summary>
	public UFractureTransformGizmoSettings GizmoSettings;
}
