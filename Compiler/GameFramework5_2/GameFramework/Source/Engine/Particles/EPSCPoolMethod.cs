#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/WorldPSCPool.h")]
public enum EPSCPoolMethod {
	None=0,
	AutoRelease=1,
	ManualRelease=2,
	ManualRelease_OnComplete=3,
	FreeInPool=4,
}
