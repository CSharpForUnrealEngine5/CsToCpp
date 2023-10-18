namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Scalability settings for Niagara Systems for a particular platform set (unless overridden).</summary>
[CppInclude("NiagaraEffectType.h")]
public partial struct FNiagaraSystemScalabilitySettings {
	public FNiagaraPlatformSet Platforms;
	public bool bCullByDistance;
	public bool bCullMaxInstanceCount;
	public bool bCullPerSystemMaxInstanceCount;
	public float MaxDistance;
	public bool bCullByMaxTimeWithoutRender_DEPRECATED;
	public int MaxInstances;
	public int MaxSystemInstances;
	public float MaxTimeWithoutRender_DEPRECATED;
	public ENiagaraCullProxyMode CullProxyMode;
	public int MaxSystemProxies;
	public FNiagaraSystemVisibilityCullingSettings VisibilityCulling;
	public FNiagaraGlobalBudgetScaling BudgetScaling;
}
