namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ICVFXTestControllerAutoTest.h")]
public enum EICVFXAutoTestState {
	InitialLoad=0,
	Soak=1,
	TraverseTestLocations=2,
	Finished=3,
	Shutdown=4,
	MAX=5,
}
