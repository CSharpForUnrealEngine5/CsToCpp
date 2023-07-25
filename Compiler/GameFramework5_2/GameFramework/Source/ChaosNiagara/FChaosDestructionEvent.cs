#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceChaosDestruction.h")]
public partial struct FChaosDestructionEvent {
// ChaosDestructionEvent
	public FVector Position;
	public FVector Normal;
	public FVector Velocity;
	public FVector AngularVelocity;
	public float ExtentMin;
	public float ExtentMax;
	public int ParticleID;
	public float Time;
	public int Type;
}
