#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/Actor.h")]
///<summary>Determines how the transform being passed into actor spawning methods interact with the actor&#39;s default root component</summary>
public enum ESpawnActorScaleMethod {
	OverrideRootScale=0,
	MultiplyWithRoot=1,
	SelectDefaultAtRuntime=2,
}
