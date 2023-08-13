namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UFUNCTION actions to manage convex hulls generation for geometry collections</summary>
[CppInclude("FractureToolConvex.h")]
public partial class UFractureConvexActions : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Save settings as project defaults, to be used for all new geometry collections</summary>
	public void SaveAsDefaults() {}
	///<summary>Set settings from current project defaults</summary>
	public void SetFromDefaults() {}
}
