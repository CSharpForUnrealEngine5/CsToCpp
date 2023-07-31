#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
///<summary>An enumeration for specifying quantization boundary reference frame</summary>
public enum EQuarztQuantizationReference {
	BarRelative=0,
	TransportRelative=1,
	CurrentTimeRelative=2,
	Count=3,
}
