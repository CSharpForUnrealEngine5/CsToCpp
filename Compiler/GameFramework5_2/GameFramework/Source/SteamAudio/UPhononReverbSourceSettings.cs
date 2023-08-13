namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononReverbSourceSettings.h")]
public partial class UPhononReverbSourceSettings : UReverbPluginSourceSettingsBase {
	public static UClass StaticClass() {return default;}
	///<summary>How to simulate source-centric reverb.</summary>
	public EIplSimulationType SourceReverbSimulationType;
	///<summary>Scale factor to make the indirect contribution louder or softer.</summary>
	public float SourceReverbContribution;
}
