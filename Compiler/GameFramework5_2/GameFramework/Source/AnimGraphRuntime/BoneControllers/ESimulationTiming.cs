#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BoneControllers/AnimNode_RigidBody.h")]
///<summary>Determines behaviour regarding deferral of simulation tasks.</summary>
public enum ESimulationTiming {
	Default=0,
	Synchronous=1,
	Deferred=2,
}
