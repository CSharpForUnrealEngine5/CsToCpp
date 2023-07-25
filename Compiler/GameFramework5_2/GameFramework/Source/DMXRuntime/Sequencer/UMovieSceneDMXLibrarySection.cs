#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneDMXLibrarySection.h")]
///<summary>A DMX Fixture Patch section</summary>
public partial class UMovieSceneDMXLibrarySection : UMovieSceneSection {
// MovieSceneDMXLibrarySection
	public bool bUseNormalizedValues;
	public void AddFixturePatch(UObject InPatch) {}
	public void AddFixturePatches(TArray<FDMXEntityFixturePatchRef> InFixturePatchRefs) {}
	public void RemoveFixturePatch(UObject InPatch) {}
	public bool ContainsFixturePatch(UObject InPatch) { return default; }
	public void SetFixturePatchActiveMode(UObject InPatch,int InActiveMode) {}
	public void ToggleFixturePatchChannel(UObject InPatch,int InChannelIndex) {}
	public bool GetFixturePatchChannelEnabled(UObject InPatch,int InChannelIndex) { return default; }
	public TArray<UObject> GetFixturePatches() { return default; }
	public int GetNumPatches() { return default; }
	public TArray<FDMXFixturePatchChannel> FixturePatchChannels;
}
