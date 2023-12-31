namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UFUNCTION actions to manage default proximity detection settings for geometry collections</summary>
[CppInclude("FractureToolProximity.h")]
public partial class UFractureProximityActions : UFractureToolSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Save settings as project defaults, to be used for all new geometry collections</summary>
	public void SaveAsDefaults() {}
	///<summary>Set settings from current project defaults</summary>
	public void SetFromDefaults() {}
}
