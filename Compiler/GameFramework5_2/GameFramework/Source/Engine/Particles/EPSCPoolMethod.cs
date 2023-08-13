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
