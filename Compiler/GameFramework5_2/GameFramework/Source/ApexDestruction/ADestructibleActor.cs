#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DestructibleActor.h")]
public partial class ADestructibleActor : AActor {
// DestructibleActor
	public UDestructibleComponent DestructibleComponent;
	public FActorFractureSignature OnActorFracture;
	public bool bAffectNavigation;
}
