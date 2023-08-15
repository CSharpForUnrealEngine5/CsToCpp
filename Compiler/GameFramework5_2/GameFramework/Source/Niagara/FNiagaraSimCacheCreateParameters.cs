namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial struct FNiagaraSimCacheCreateParameters {
	public ENiagaraSimCacheAttributeCaptureMode AttributeCaptureMode;
	public bool bAllowRebasing;
	public bool bAllowDataInterfaceCaching;
	public bool bAllowInterpolation;
	public bool bAllowVelocityExtrapolation;
	public TArray<FName> RebaseIncludeAttributes;
	public TArray<FName> RebaseExcludeAttributes;
	public TArray<FName> InterpolationIncludeAttributes;
	public TArray<FName> InterpolationExcludeAttributes;
	public TArray<FName> ExplicitCaptureAttributes;
}
