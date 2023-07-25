#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhysicsEngine/RadialForceComponent.h")]
///<summary>Used to emit a radial force or impulse that can affect physics objects and or destructible objects.</summary>
public partial class URadialForceComponent : USceneComponent {
// RadialForceComponent
	public float Radius;
	public byte Falloff;
	public float ImpulseStrength;
	public bool bImpulseVelChange;
	public bool bIgnoreOwningActor;
	public float ForceStrength;
	public float DestructibleDamage;
	public void FireImpulse() {}
	public void AddObjectTypeToAffect(byte ObjectType) {}
	public void RemoveObjectTypeToAffect(byte ObjectType) {}
	public TArray<byte> ObjectTypesToAffect;
}
