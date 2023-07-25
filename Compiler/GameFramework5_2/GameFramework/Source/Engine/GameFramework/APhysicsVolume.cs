#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/PhysicsVolume.h")]
///<summary>PhysicsVolume: A bounding volume which affects actor physics.</summary>
public partial class APhysicsVolume : AVolume {
// PhysicsVolume
	public float TerminalVelocity;
	public int Priority;
	public float FluidFriction;
	public bool bWaterVolume;
	public bool bPhysicsOnContact;
}
