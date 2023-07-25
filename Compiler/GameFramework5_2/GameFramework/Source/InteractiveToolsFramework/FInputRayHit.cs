#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputState.h")]
///<summary>* FInputRayHit is returned by various hit-test interface functions.</summary>
public partial struct FInputRayHit {
// InputRayHit
	public bool bHit;
	public double HitDepth;
	public FVector HitNormal;
	public bool bHasHitNormal;
	public int HitIdentifier;
	public TWeakObjectPtr<UObject> HitObject;
}
