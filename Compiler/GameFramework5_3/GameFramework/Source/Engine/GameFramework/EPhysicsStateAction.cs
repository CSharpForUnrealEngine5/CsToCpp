namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PawnMovementComponent.h")]
///<summary>Enumerates all the action types that could be applied to the physics state</summary>
public enum EPhysicsStateAction {
	AddForce=0,
	AddTorque=1,
	AddForceAtPosition=2,
	AddLinearVelocity=3,
	AddAngularVelocity=4,
	AddVelocityAtPosition=5,
	AddLinearImpulse=6,
	AddAngularImpulse=7,
	AddImpulseAtPosition=8,
	AddAcceleration=9,
	NumActions=10,
}
