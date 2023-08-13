namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings related to the collision properties of the fractured mesh pieces</summary>
[CppInclude("FractureToolCutter.h")]
public partial class UFractureCollisionSettings : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, add extra vertices (without triangles) to the geometry in regions where vertices are spaced too far apart (e.g. across large triangles)</summary>
	public bool bAddSamplesForCollision;
	///<summary>The number of centimeters to allow between vertices on the mesh surface: If there are gaps larger than this, add additional vertices (without triangles) to help support particle-implicit collisions</summary>
	public float PointSpacing;
}
