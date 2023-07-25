#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraRendererProperties.h")]
///<summary>Emitter properties base class</summary>
public partial class UNiagaraRendererProperties : UNiagaraMergeable {
// NiagaraRendererProperties
	public FNiagaraPlatformSet Platforms;
	public int SortOrderHint;
	public ENiagaraRendererMotionVectorSetting MotionVectorSetting;
	public FNiagaraVariableAttributeBinding RendererEnabledBinding;
	public bool bIsEnabled;
	public bool bAllowInCullProxies;
	public FGuid OuterEmitterVersion;
	public bool bMotionBlurEnabled_DEPRECATED;
}
