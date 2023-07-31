#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsCoreTypes.h")]
public enum EChaosThreadingMode {
	DedicatedThread=0,
	TaskGraph=1,
	SingleThread=2,
	Num=3,
	Invalid=4,
}
