namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleEmitter.h")]
public partial class UParticleEmitter : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the emitter.</summary>
	public FName EmitterName;
	///<summary>SubUVDataOffset</summary>
	public int SubUVDataOffset;
	///<summary>How to render the emitter particles. Can be one of the following:</summary>
	public EEmitterRenderMode EmitterRenderMode;
	///<summary>The significance level required of this emitter&#39;s owner for this emitter to be active.</summary>
	public EParticleSignificanceLevel SignificanceLevel;
	///<summary>If true, maintains some legacy spawning behavior.</summary>
	public bool bUseLegacySpawningBehavior;
	///<summary>ConvertedModules</summary>
	public bool ConvertedModules;
	///<summary>If true, then show only this emitter in the editor</summary>
	public bool bIsSoloing;
	///<summary>If true, then this emitter was &#39;cooked out&#39; by the cooker.</summary>
	public bool bCookedOut;
	///<summary>When true, if the current LOD is disabled the emitter will be kept alive. Otherwise, the emitter will be considered complete if the current LOD is disabled.</summary>
	public bool bDisabledLODsKeepEmitterAlive;
	///<summary>When true, emitters deemed insignificant will have their tick and render disabled Instantly. When false they will simple stop spawning new particles.</summary>
	public bool bDisableWhenInsignficant;
	///<summary>This value indicates the emitter should be drawn &#39;collapsed&#39; in Cascade</summary>
	public bool bCollapsed;
	///<summary>If detail mode is &gt;= system detail mode, primitive won&#39;t be rendered.</summary>
	public EDetailMode DetailMode_DEPRECATED;
	///<summary>The color of the emitter in the curve editor and debug rendering modes.</summary>
	public FColor EmitterEditorColor;
	///<summary>&#39;Private&#39; data - not required by the editor</summary>
	public TArray<UParticleLODLevel> LODLevels;
	///<summary>PeakActiveParticles</summary>
	public int PeakActiveParticles;
	///<summary>Initial allocation count - overrides calculated peak count if &gt; 0</summary>
	public int InitialAllocationCount;
	///<summary>QualityLevelSpawnRateScale</summary>
	public float QualityLevelSpawnRateScale;
	///<summary>Detail mode: Set flags reflecting which system detail mode you want the emitter to be ticked and rendered in</summary>
	public uint DetailModeBitmask;
	///<summary>DetailModeDisplay</summary>
	public string DetailModeDisplay;
}
