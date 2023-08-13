namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/InterpToMovementComponent.h")]
///<summary>Controls the movement behaviour</summary>
public enum EInterpToBehaviourType {
	OneShot=0,
	OneShot_Reverse=1,
	Loop_Reset=2,
	PingPong=3,
}
