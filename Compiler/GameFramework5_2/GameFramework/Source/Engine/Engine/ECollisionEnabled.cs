namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Enum used to describe what type of collision is enabled on a body.</summary>
[CppEnumInNamespace]
public enum ECollisionEnabled {
	NoCollision=0,
	QueryOnly=1,
	PhysicsOnly=2,
	QueryAndPhysics=3,
	ProbeOnly=4,
	QueryAndProbe=5,
}
