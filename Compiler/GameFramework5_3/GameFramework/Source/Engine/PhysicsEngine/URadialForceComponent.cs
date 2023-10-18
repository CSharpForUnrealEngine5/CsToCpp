namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to emit a radial force or impulse that can affect physics objects and or destructible objects.</summary>
[CppInclude("PhysicsEngine/RadialForceComponent.h")]
public partial class URadialForceComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The radius to apply the force or impulse in</summary>
	public float Radius;
	///<summary>How the force or impulse should fall off as object are further away from the center</summary>
	public ERadialImpulseFalloff Falloff;
	///<summary>How strong the impulse should be</summary>
	public float ImpulseStrength;
	///<summary>If true, the impulse will ignore mass of objects and will always result in a fixed velocity change</summary>
	public bool bImpulseVelChange;
	///<summary>If true, do not apply force/impulse to any physics objects that are part of the Actor that owns this component.</summary>
	public bool bIgnoreOwningActor;
	///<summary>How strong the force should be</summary>
	public float ForceStrength;
	///<summary>If &gt; 0.f, will cause damage to destructible meshes as well</summary>
	public float DestructibleDamage;
	///<summary>Fire a single impulse</summary>
	public virtual void FireImpulse() {}
	///<summary>Add an object type for this radial force to affect</summary>
	public virtual void AddObjectTypeToAffect(EObjectTypeQuery ObjectType) {}
	///<summary>Remove an object type that is affected by this radial force</summary>
	public virtual void RemoveObjectTypeToAffect(EObjectTypeQuery ObjectType) {}
	///<summary>The object types that are affected by this radial force</summary>
	public TArray<EObjectTypeQuery> ObjectTypesToAffect;
}
