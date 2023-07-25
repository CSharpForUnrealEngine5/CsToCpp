#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosWheeledVehicleMovementComponent.h")]
///<summary>Single angle : both wheels steer by the same amount</summary>
public enum ESteeringType {
	SingleAngle=0,
	AngleRatio=1,
	Ackermann=2,
}
