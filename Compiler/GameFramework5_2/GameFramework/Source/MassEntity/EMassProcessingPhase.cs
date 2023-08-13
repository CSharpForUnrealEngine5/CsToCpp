namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessingTypes.h")]
public enum EMassProcessingPhase {
	PrePhysics=0,
	StartPhysics=1,
	DuringPhysics=2,
	EndPhysics=3,
	PostPhysics=4,
	FrameEnd=5,
	MAX=6,
}
