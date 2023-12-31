namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for LiveLink Sequencer</summary>
[CppInclude("LiveLinkSequencerSettings.h")]
public partial class ULiveLinkSequencerSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Default Track Recorder class to use for the specified LiveLink controller</summary>
	public TMap<UClass,UClass> DefaultTrackRecordersForController;
}
