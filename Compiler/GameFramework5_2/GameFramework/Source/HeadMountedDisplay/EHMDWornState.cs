#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HeadMountedDisplayTypes.h")]
///<summary>Stores if the user is wearing the HMD or not. For HMDs without a sensor to detect the user wearing it, the state defaults to Unknown.</summary>
[CppEnumInNamespace]
public enum EHMDWornState {
	Unknown=0,
	Worn=1,
	NotWorn=2,
}
