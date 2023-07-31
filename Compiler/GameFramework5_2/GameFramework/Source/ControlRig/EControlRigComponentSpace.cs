#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ControlRigComponent.h")]
///<summary>Enum for controlling which space a transform is applied in.</summary>
public enum EControlRigComponentSpace {
	WorldSpace=0,
	ActorSpace=1,
	ComponentSpace=2,
	RigSpace=3,
	LocalSpace=4,
	Max=5,
}
