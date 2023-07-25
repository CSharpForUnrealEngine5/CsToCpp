#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundCueContainer.h")]
public partial class USoundCueContainer : USoundCueTemplate {
// SoundCueContainer
	public ESoundContainerType ContainerType;
	public bool bLooping;
	public TSet<USoundWave> Variations;
	public FVector2D PitchModulation;
	public FVector2D VolumeModulation;
}
