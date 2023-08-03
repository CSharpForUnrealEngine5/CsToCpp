#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Emitter properties base class</summary>
[CppInclude("NiagaraRendererProperties.h")]
public partial class UNiagaraRendererProperties : UNiagaraMergeable {
	public static UClass StaticClass() {return default;}
	///<summary>Platforms on which this renderer is enabled.</summary>
	public FNiagaraPlatformSet Platforms;
	///<summary>By default, emitters are drawn in the order that they are added to the system. This value will allow you to control the order in a more fine-grained manner.</summary>
	public int SortOrderHint;
	///<summary>Hint about how to generate motion (velocity) vectors for this renderer.</summary>
	public ENiagaraRendererMotionVectorSetting MotionVectorSetting;
	///<summary>Binding to control if the renderer is enabled or disabled.</summary>
	public FNiagaraVariableAttributeBinding RendererEnabledBinding;
	///<summary>bIsEnabled</summary>
	public bool bIsEnabled;
	///<summary>bAllowInCullProxies</summary>
	public bool bAllowInCullProxies;
	///<summary>OuterEmitterVersion</summary>
	public FGuid OuterEmitterVersion;
	///<summary>bMotionBlurEnabled_DEPRECATED</summary>
	public bool bMotionBlurEnabled_DEPRECATED;
}
