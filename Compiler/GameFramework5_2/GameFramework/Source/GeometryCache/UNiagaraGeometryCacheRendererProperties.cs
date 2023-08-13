namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraGeometryCacheRendererProperties.h")]
public partial class UNiagaraGeometryCacheRendererProperties : UNiagaraRendererProperties {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the geometry cache assets to use. If ArrayIndexBinding is not set, a random element is used for each particle.</summary>
	public TArray<FNiagaraGeometryCacheReference> GeometryCaches;
	///<summary>If true, then the geometry cache keeps playing in a loop</summary>
	public bool bIsLooping;
	///<summary>The max number of components that this emitter will spawn or update each frame.</summary>
	public uint ComponentCountLimit;
	///<summary>Which attribute should we use for the geometry cache position?</summary>
	public FNiagaraVariableAttributeBinding PositionBinding;
	///<summary>Which attribute should we use for the geometry cache rotation?</summary>
	public FNiagaraVariableAttributeBinding RotationBinding;
	///<summary>Which attribute should we use for the geometry cache component scale?</summary>
	public FNiagaraVariableAttributeBinding ScaleBinding;
	///<summary>Which attribute should we use for the geometry cache&#39;s current animation time?</summary>
	public FNiagaraVariableAttributeBinding ElapsedTimeBinding;
	///<summary>Which attribute should we use to check if rendering should be enabled?</summary>
	public FNiagaraVariableAttributeBinding EnabledBinding;
	///<summary>Which attribute should we use to pick the element in the geometry cache array for this renderer? If not set, a random element will be used.</summary>
	public FNiagaraVariableAttributeBinding ArrayIndexBinding;
	///<summary>Which attribute should we use for the renderer visibility tag?</summary>
	public FNiagaraVariableAttributeBinding RendererVisibilityTagBinding;
	///<summary>If a render visibility tag is present, particles whose tag matches this value will be visible in this renderer.</summary>
	public int RendererVisibility;
	///<summary>If true then components will not be automatically assigned to the first particle available, but try to stick to the same particle based on its unique id.</summary>
	public bool bAssignComponentsOnParticleID;
}
