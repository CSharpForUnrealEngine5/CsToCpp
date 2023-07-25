#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkeletalMeshComponent.h")]
///<summary>This enum defines how you'd like to update bones to physics world.</summary>
[CppEnumInNamespace]
public enum EKinematicBonesUpdateToPhysics {
	SkipSimulatingBones=0,
	SkipAllBones=1,
}
