#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundMix.h")]
public partial class USoundMix : UObject {
	///<summary>Whether to apply the EQ effect</summary>
	public bool bApplyEQ;
	///<summary>EQPriority</summary>
	public float EQPriority;
	///<summary>EQSettings</summary>
	public FAudioEQEffect EQSettings;
	///<summary>Array of changes to be applied to groups.</summary>
	public TArray<FSoundClassAdjuster> SoundClassEffects;
	///<summary>Initial delay in seconds before the mix is applied.</summary>
	public float InitialDelay;
	///<summary>Time taken in seconds for the mix to fade in.</summary>
	public float FadeInTime;
	///<summary>Duration of mix, negative means it will be applied until another mix is set.</summary>
	public float Duration;
	///<summary>Time taken in seconds for the mix to fade out.</summary>
	public float FadeOutTime;
	///<summary>Transient property used to trigger real-time updates of the active EQ filter for editor previewing</summary>
	public bool bChanged;
}
