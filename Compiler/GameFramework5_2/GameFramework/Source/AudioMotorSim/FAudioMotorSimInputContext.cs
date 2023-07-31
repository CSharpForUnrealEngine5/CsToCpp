#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>collection of properties to be filled out by the vehicle in order to update the motor sim</summary>
[CppInclude("AudioMotorSimTypes.h")]
public partial struct FAudioMotorSimInputContext {
	public float DeltaTime;
	public float Speed;
	public float ForwardSpeed;
	public float SideSpeed;
	public float UpSpeed;
	public float Throttle;
	public float Brake;
	public float SurfaceFrictionModifier;
	public float MotorFrictionModifier;
	public float Boost;
	public bool bDriving;
	public bool bGrounded;
	public bool bCanShift;
	public bool bClutchEngaged;
}
