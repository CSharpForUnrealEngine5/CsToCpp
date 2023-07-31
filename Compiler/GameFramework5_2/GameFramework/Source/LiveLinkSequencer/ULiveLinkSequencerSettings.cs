#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for LiveLink Sequencer</summary>
[CppInclude("LiveLinkSequencerSettings.h")]
public partial class ULiveLinkSequencerSettings : UDeveloperSettings {
	///<summary>Default Track Recorder class to use for the specified LiveLink controller</summary>
	public TMap<UClass,UClass> DefaultTrackRecordersForController;
}
