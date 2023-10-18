namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A DMX Fixture Patch section</summary>
[CppInclude("Sequencer/MovieSceneDMXLibrarySection.h")]
public partial class UMovieSceneDMXLibrarySection : UMovieSceneSection {
	public static UClass StaticClass() {return default;}
	///<summary>If true, all values are interpreted as normalized values (0.0 to 1.0)</summary>
	public bool bUseNormalizedValues;
	///<summary>Adds a single patch to the section</summary>
	public void AddFixturePatch(UDMXEntityFixturePatch InPatch) {}
	///<summary>Adds all patches to the secion</summary>
	public void AddFixturePatches(TArray<FDMXEntityFixturePatchRef> InFixturePatchRefs) {}
	///<summary>Remove all Functions of a Fixture Patch</summary>
	public void RemoveFixturePatch(UDMXEntityFixturePatch InPatch) {}
	///<summary>Check if this Section animates a Fixture Patch&#39;s Functions</summary>
	public bool ContainsFixturePatch(UDMXEntityFixturePatch InPatch) { return default; }
	///<summary>Sets the active mode for a Fixture Patch</summary>
	public void SetFixturePatchActiveMode(UDMXEntityFixturePatch InPatch,int InActiveMode) {}
	///<summary>Toggle the visibility and evaluation of a Fixture Patch&#39;s Function.</summary>
	public void ToggleFixturePatchChannel(UDMXEntityFixturePatch InPatch,int InChannelIndex) {}
	///<summary>Returns whether a Fixture Patch&#39;s Function curve channel is currently enabled</summary>
	public bool GetFixturePatchChannelEnabled(UDMXEntityFixturePatch InPatch,int InChannelIndex) { return default; }
	///<summary>Get a list of the Fixture Patches being animated by this Section</summary>
	public TArray<UDMXEntityFixturePatch> GetFixturePatches() { return default; }
	///<summary>Get the list of animated Fixture Patches and their curve channels</summary>
	public int GetNumPatches() { return default; }
	///<summary>The Fixture Patches being controlled by this section and their respective chosen mode</summary>
	public TArray<FDMXFixturePatchChannel> FixturePatchChannels;
}
