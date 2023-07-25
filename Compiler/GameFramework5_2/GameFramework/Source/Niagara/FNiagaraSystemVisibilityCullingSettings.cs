#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEffectType.h")]
///<summary>Scalability settings for Niagara Systems for a particular platform set (unless overridden).</summary>
public partial struct FNiagaraSystemVisibilityCullingSettings {
// NiagaraSystemVisibilityCullingSettings
	public bool bCullWhenNotRendered;
	public bool bCullByViewFrustum;
	public bool bAllowPreCullingByViewFrustum;
	public float MaxTimeOutsideViewFrustum;
	public float MaxTimeWithoutRender;
}
