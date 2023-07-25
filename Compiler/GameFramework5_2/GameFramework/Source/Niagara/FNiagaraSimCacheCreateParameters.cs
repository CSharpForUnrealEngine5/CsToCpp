#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCache.h")]
public partial struct FNiagaraSimCacheCreateParameters {
// NiagaraSimCacheCreateParameters
	public ENiagaraSimCacheAttributeCaptureMode AttributeCaptureMode;
	public bool bAllowRebasing;
	public bool bAllowDataInterfaceCaching;
	public bool bAllowInterpolation;
	public bool bAllowVelocityExtrapolation;
	public TArray<string> RebaseIncludeAttributes;
	public TArray<string> RebaseExcludeAttributes;
	public TArray<string> InterpolationIncludeAttributes;
	public TArray<string> InterpolationExcludeAttributes;
	public TArray<string> ExplicitCaptureAttributes;
}
