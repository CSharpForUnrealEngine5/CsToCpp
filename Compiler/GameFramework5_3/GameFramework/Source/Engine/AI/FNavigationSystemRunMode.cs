namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/NavigationSystemBase.h")]
public enum FNavigationSystemRunMode {
	InvalidMode=0,
	GameMode=1,
	EditorMode=2,
	SimulationMode=3,
	PIEMode=4,
	InferFromWorldMode=5,
	EditorWorldPartitionBuildMode=6,
}
