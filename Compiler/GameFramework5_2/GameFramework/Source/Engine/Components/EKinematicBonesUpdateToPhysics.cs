namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SkeletalMeshComponent.h")]
///<summary>This enum defines how you&#39;d like to update bones to physics world.</summary>
[CppEnumInNamespace]
public enum EKinematicBonesUpdateToPhysics {
	SkipSimulatingBones=0,
	SkipAllBones=1,
}
