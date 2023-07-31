#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Scalability settings for Niagara Systems for a particular platform set (unless overridden).</summary>
[CppInclude("NiagaraEffectType.h")]
public partial struct FNiagaraSystemVisibilityCullingSettings {
	public bool bCullWhenNotRendered;
	public bool bCullByViewFrustum;
	public bool bAllowPreCullingByViewFrustum;
	public float MaxTimeOutsideViewFrustum;
	public float MaxTimeWithoutRender;
}
