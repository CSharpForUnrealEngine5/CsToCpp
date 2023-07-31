#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundCueContainer.h")]
public partial class USoundCueContainer : USoundCueTemplate {
	///<summary>ContainerType</summary>
	public ESoundContainerType ContainerType;
	///<summary>bLooping</summary>
	public bool bLooping;
	///<summary>Variations</summary>
	public TSet<USoundWave> Variations;
	///<summary>PitchModulation</summary>
	public FVector2D PitchModulation;
	///<summary>VolumeModulation</summary>
	public FVector2D VolumeModulation;
}
