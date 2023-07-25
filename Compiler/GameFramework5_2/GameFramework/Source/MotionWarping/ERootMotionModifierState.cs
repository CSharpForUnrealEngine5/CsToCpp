#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RootMotionModifier.h")]
///<summary>The possible states of a Root Motion Modifier</summary>
public enum ERootMotionModifierState {
	Waiting=0,
	Active=1,
	MarkedForRemoval=2,
	Disabled=3,
}
