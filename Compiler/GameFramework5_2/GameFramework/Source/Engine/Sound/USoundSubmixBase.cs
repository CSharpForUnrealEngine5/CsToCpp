#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSubmix.h")]
public partial class USoundSubmixBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Auto-manage enabling and disabling the submix as a CPU optimization. It will be disabled if the submix and all child submixes are silent. It will re-enable if a sound is sent to the submix or a child submix is audible.</summary>
	public bool bAutoDisable;
	///<summary>The minimum amount of time to wait before automatically disabling a submix if it is silent. Will immediately re-enable if source audio is sent to it.</summary>
	public float AutoDisableTime;
	///<summary>Child submixes to this sound mix</summary>
	public TArray<USoundSubmixBase> ChildSubmixes;
}
