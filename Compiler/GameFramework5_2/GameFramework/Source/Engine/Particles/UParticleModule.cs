#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Particles/ParticleModule.h")]
public partial class UParticleModule : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the module performs operations on particles during Spawning</summary>
	public bool bSpawnModule;
	///<summary>If true, the module performs operations on particles during Updating</summary>
	public bool bUpdateModule;
	///<summary>If true, the module performs operations on particles during final update</summary>
	public bool bFinalUpdateModule;
	///<summary>If true, the module performs operations on particles during update and/or final update for GPU emitters</summary>
	public bool bUpdateForGPUEmitter;
	///<summary>If true, the module displays FVector curves as colors</summary>
	public bool bCurvesAsColor;
	///<summary>If true, the module should render its 3D visualization helper</summary>
	public bool b3DDrawMode;
	///<summary>If true, the module supports rendering a 3D visualization helper</summary>
	public bool bSupported3DDrawMode;
	///<summary>If true, the module is enabled</summary>
	public bool bEnabled;
	///<summary>If true, the module has had editing enabled on it</summary>
	public bool bEditable;
	///<summary>If true, this flag indicates that auto-generation for LOD will result in</summary>
	public bool LODDuplicate;
	///<summary>If true, the module supports RandomSeed setting</summary>
	public bool bSupportsRandomSeed;
	///<summary>If true, the module should be told when looping</summary>
	public bool bRequiresLoopingNotification;
	///<summary>The LOD levels this module is present in.</summary>
	public byte LODValidity;
	///<summary>The color to draw the modules curves in the curve editor.</summary>
	public FColor ModuleEditorColor;
}
