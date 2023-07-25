#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Factories/SoundFactory.h")]
public partial class USoundFactory : UFactory {
// SoundFactory
	public bool bAutoCreateCue;
	public bool bIncludeAttenuationNode;
	public bool bIncludeLoopingNode;
	public bool bIncludeModulatorNode;
	public float CueVolume;
	public string CuePackageSuffix;
}
