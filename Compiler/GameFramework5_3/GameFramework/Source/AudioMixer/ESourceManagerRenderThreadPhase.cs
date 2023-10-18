namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMixerSourceManager.h")]
///<summary>For diagnostics, keep track of what phase of updating the Source manager is in currently.</summary>
public enum ESourceManagerRenderThreadPhase {
	Begin=0,
	PumpMpscCmds=1,
	PumpCmds=2,
	ProcessModulators=3,
	UpdatePendingReleaseData=4,
	GenerateSrcAudio_WithBusses=5,
	ComputeBusses=6,
	GenerateSrcAudio_WithoutBusses=7,
	UpdateBusses=8,
	SpatialInterface_OnAllSourcesProcessed=9,
	SourceDataOverride_OnAllSourcesProcessed=10,
	UpdateGameThreadCopies=11,
	Finished=12,
}
