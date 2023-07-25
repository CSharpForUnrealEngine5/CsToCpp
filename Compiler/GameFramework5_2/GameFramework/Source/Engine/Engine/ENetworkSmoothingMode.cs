#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Smoothing approach used by network interpolation for Characters.</summary>
public enum ENetworkSmoothingMode {
	Disabled=0,
	Linear=1,
	Exponential=2,
}
