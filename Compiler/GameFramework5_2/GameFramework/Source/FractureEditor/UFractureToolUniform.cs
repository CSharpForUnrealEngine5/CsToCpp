namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolUniform.h")]
public partial class UFractureToolUniform : UFractureToolVoronoiCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>Uniform Voronoi Fracture Input Settings</summary>
	public UFractureUniformSettings UniformSettings;
}
