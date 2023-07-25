#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SequencerTrackInstanceBP.h")]
public partial class USequencerTrackInstanceBP : UMovieSceneTrackInstance {
// SequencerTrackInstanceBP
	public void K2_OnInitialize() {}
	public void K2_OnUpdate() {}
	public void K2_OnBeginUpdateInputs() {}
	public void K2_OnInputAdded(FSequencerTrackInstanceInput Input) {}
	public void K2_OnInputRemoved(FSequencerTrackInstanceInput Input) {}
	public void K2_OnEndUpdateInputs() {}
	public void K2_OnDestroyed() {}
	public UObject GetAnimatedObject() { return default; }
	public TArray<FSequencerTrackInstanceInput> GetInputs() { return default; }
	public int GetNumInputs() { return default; }
	public FSequencerTrackInstanceInput GetInput(int Index) { return default; }
}
