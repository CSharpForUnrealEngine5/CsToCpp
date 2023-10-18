namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundCueContainer.h")]
public partial class USoundCueContainer : USoundCueTemplate {
	public static UClass StaticClass() {return default;}
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
