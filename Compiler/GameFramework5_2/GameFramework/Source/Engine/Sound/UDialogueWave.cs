#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/DialogueWave.h")]
public partial class UDialogueWave : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>true if this dialogue is considered to contain mature/adult content.</summary>
	public bool bMature;
	///<summary>bOverride_SubtitleOverride</summary>
	public bool bOverride_SubtitleOverride;
	///<summary>A localized version of the text that is actually spoken phonetically in the audio.</summary>
	public string SpokenText;
	///<summary>A localized version of the subtitle text that should be displayed for this audio. By default this will be the same as the Spoken Text.</summary>
	public string SubtitleOverride;
	///<summary>Provides general notes to the voice actor intended to direct their performance, as well as contextual information to the translator.</summary>
	public string VoiceActorDirection;
	///<summary>Mappings between dialogue contexts and associated soundwaves.</summary>
	public TArray<FDialogueContextMapping> ContextMappings;
	///<summary>LocalizationGUID</summary>
	public FGuid LocalizationGUID;
}
