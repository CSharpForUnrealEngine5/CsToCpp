#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FOculusCapsuleCollider is a struct that contains information on the physics/collider capsules created by the runtime for hands.</summary>
[CppInclude("OculusInputFunctionLibrary.h")]
public partial struct FOculusCapsuleCollider {
	public UCapsuleComponent Capsule;
	public EBone BoneId;
}
