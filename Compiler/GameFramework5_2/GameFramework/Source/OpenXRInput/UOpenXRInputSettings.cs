#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the OpenXR Input plugin.</summary>
[CppInclude("OpenXRInputSettings.h")]
public partial class UOpenXRInputSettings : UObject {
	///<summary>Set a mappable input config to allow OpenXR runtimes to remap the Enhanced Input actions.</summary>
	public FSoftObjectPath MappableInputConfig;
}
