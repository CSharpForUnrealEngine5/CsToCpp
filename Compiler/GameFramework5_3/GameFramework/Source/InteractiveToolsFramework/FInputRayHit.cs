namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* FInputRayHit is returned by various hit-test interface functions.</summary>
[CppInclude("InputState.h")]
public partial struct FInputRayHit {
	public bool bHit;
	public double HitDepth;
	public FVector HitNormal;
	public bool bHasHitNormal;
	public int HitIdentifier;
	public TWeakObjectPtr<UObject> HitObject;
}
