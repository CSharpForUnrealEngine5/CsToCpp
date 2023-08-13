namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FOculusCapsuleCollider is a struct that contains information on the physics/collider capsules created by the runtime for hands.</summary>
[CppInclude("OculusInputFunctionLibrary.h")]
public partial struct FOculusCapsuleCollider {
	public UCapsuleComponent Capsule;
	public EBone BoneId;
}
