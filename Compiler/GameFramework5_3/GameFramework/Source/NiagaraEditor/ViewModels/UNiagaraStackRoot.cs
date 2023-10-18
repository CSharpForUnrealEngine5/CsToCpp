namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/Stack/NiagaraStackRoot.h")]
public partial class UNiagaraStackRoot : UNiagaraStackEntry {
	public static UClass StaticClass() {return default;}
	///<summary>SystemPropertiesGroup</summary>
	public UNiagaraStackSystemPropertiesGroup SystemPropertiesGroup;
	///<summary>SystemUserParametersGroup</summary>
	public UNiagaraStackSystemUserParametersGroup SystemUserParametersGroup;
	///<summary>SystemSpawnGroup</summary>
	public UNiagaraStackScriptItemGroup SystemSpawnGroup;
	///<summary>SystemUpdateGroup</summary>
	public UNiagaraStackScriptItemGroup SystemUpdateGroup;
	///<summary>EmitterPropertiesGroup</summary>
	public UNiagaraStackEmitterPropertiesGroup EmitterPropertiesGroup;
	///<summary>EmitterSummaryGroup</summary>
	public UNiagaraStackEmitterSummaryGroup EmitterSummaryGroup;
	///<summary>EmitterSpawnGroup</summary>
	public UNiagaraStackScriptItemGroup EmitterSpawnGroup;
	///<summary>EmitterUpdateGroup</summary>
	public UNiagaraStackScriptItemGroup EmitterUpdateGroup;
	///<summary>ParticleSpawnGroup</summary>
	public UNiagaraStackScriptItemGroup ParticleSpawnGroup;
	///<summary>ParticleUpdateGroup</summary>
	public UNiagaraStackScriptItemGroup ParticleUpdateGroup;
	///<summary>RenderGroup</summary>
	public UNiagaraStackRenderItemGroup RenderGroup;
	///<summary>CommentCollection</summary>
	public UNiagaraStackCommentCollection CommentCollection;
	///<summary>SummaryCollapseButton</summary>
	public UNiagaraStackSummaryViewCollapseButton SummaryCollapseButton;
}
