namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the OpenXR Input plugin.</summary>
[CppInclude("OpenXRInputSettings.h")]
public partial class UOpenXRInputSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Set a mappable input config to allow OpenXR runtimes to remap the Enhanced Input actions.</summary>
	public FSoftObjectPath MappableInputConfig;
}
