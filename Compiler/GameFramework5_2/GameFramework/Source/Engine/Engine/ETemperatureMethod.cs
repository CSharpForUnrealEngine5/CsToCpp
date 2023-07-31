#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Scene.h")]
///<summary>Used by FPostProcessSettings to determine Temperature calculation method.</summary>
public enum ETemperatureMethod {
	TEMP_WhiteBalance=0,
	TEMP_ColorTemperature=1,
	TEMP_MAX=2,
}
