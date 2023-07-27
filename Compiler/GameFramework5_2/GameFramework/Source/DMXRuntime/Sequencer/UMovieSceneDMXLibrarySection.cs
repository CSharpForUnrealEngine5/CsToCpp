#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneDMXLibrarySection.h")]
///<summary>A DMX Fixture Patch section</summary>
public partial class UMovieSceneDMXLibrarySection : UMovieSceneSection {
// MovieSceneDMXLibrarySection
	public bool bUseNormalizedValues;
	public  void AddFixturePatch(UDMXEntityFixturePatch InPatch) {}
	public  void AddFixturePatches(TArray<FDMXEntityFixturePatchRef> InFixturePatchRefs) {}
	public  void RemoveFixturePatch(UDMXEntityFixturePatch InPatch) {}
	public  bool ContainsFixturePatch(UDMXEntityFixturePatch InPatch) { return default; }
	public  void SetFixturePatchActiveMode(UDMXEntityFixturePatch InPatch,int InActiveMode) {}
	public  void ToggleFixturePatchChannel(UDMXEntityFixturePatch InPatch,int InChannelIndex) {}
	public  bool GetFixturePatchChannelEnabled(UDMXEntityFixturePatch InPatch,int InChannelIndex) { return default; }
	public  TArray<UDMXEntityFixturePatch> GetFixturePatches() { return default; }
	public  int GetNumPatches() { return default; }
	public TArray<FDMXFixturePatchChannel> FixturePatchChannels;
}
