namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_RigidBody.h")]
///<summary>Determines in what space the simulation should run</summary>
public enum ESimulationSpace {
	ComponentSpace=0,
	WorldSpace=1,
	BaseBoneSpace=2,
}
