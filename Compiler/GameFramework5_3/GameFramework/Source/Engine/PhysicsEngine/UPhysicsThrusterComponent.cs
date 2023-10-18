namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used with objects that have physics to apply a force down the negative-X direction</summary>
[CppInclude("PhysicsEngine/PhysicsThrusterComponent.h")]
public partial class UPhysicsThrusterComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Strength of thrust force applied to the base object.</summary>
	public float ThrustStrength;
}
