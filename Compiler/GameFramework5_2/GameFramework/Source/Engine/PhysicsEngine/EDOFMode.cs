namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/BodyInstance.h")]
[CppEnumInNamespace]
public enum EDOFMode {
	Default=0,
	SixDOF=1,
	YZPlane=2,
	XZPlane=3,
	XYPlane=4,
	CustomPlane=5,
	None=6,
}
