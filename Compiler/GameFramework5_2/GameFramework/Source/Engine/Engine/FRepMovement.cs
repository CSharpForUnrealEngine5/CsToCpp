#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replicated movement data of our RootComponent.</summary>
[CppInclude("Engine/ReplicatedState.h")]
public partial struct FRepMovement {
	public FVector LinearVelocity;
	public FVector AngularVelocity;
	public FVector Location;
	public FRotator Rotation;
	public bool bSimulatedPhysicSleep;
	public bool bRepPhysics;
	public int ServerFrame;
	public int ServerPhysicsHandle;
	public EVectorQuantization LocationQuantizationLevel;
	public EVectorQuantization VelocityQuantizationLevel;
	public ERotatorQuantization RotationQuantizationLevel;
}
