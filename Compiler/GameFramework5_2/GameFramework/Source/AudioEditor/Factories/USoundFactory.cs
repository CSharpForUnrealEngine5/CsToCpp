namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/SoundFactory.h")]
public partial class USoundFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>If enabled, a sound cue will automatically be created for the sound</summary>
	public bool bAutoCreateCue;
	///<summary>If enabled, the created sound cue will include a attenuation node</summary>
	public bool bIncludeAttenuationNode;
	///<summary>If enabled, the created sound cue will include a looping node</summary>
	public bool bIncludeLoopingNode;
	///<summary>If enabled, the created sound cue will include a modulator node</summary>
	public bool bIncludeModulatorNode;
	///<summary>The volume of the created sound cue</summary>
	public float CueVolume;
	///<summary>If not empty, generated SoundCues will be placed in PackageCuePackageSuffix, but only if bAutoCreateCue is true</summary>
	public string CuePackageSuffix;
}
