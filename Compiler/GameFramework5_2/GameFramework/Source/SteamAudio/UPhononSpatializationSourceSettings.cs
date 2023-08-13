namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononSpatializationSourceSettings.h")]
public partial class UPhononSpatializationSourceSettings : USpatializationPluginSourceSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>SpatializationMethod</summary>
	public EIplSpatializationMethod SpatializationMethod;
	///<summary>HrtfInterpolationMethod</summary>
	public EIplHrtfInterpolationMethod HrtfInterpolationMethod;
}
