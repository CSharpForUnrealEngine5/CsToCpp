#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/ReplicatedState.h")]
///<summary>Replicated movement data of our RootComponent.</summary>
public partial struct FRepMovement {
// RepMovement
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
