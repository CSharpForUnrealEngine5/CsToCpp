#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base Sound Cue Template class, which builds the sound node graph procedurally and hides more complex Sound Cue functionality</summary>
[CppInclude("SoundCueTemplate.h")]
public partial class USoundCueTemplate : USoundCue {
	public static UClass StaticClass() {return default;}
	///<summary>AddSoundWavesToTemplate</summary>
	public  void AddSoundWavesToTemplate(TArray<UObject> SelectedObjects) {}
}
