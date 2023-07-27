#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/TimelineComponent.h")]
public partial struct FTimeline {
// Timeline
	public ETimelineLengthMode LengthMode;
	public bool bLooping;
	public bool bReversePlayback;
	public bool bPlaying;
	public float Length;
	public float PlayRate;
	public float Position;
	public TArray<FTimelineEventEntry> Events;
	public TArray<FTimelineVectorTrack> InterpVectors;
	public TArray<FTimelineFloatTrack> InterpFloats;
	public TArray<FTimelineLinearColorTrack> InterpLinearColors;
	public FOnTimelineEvent TimelinePostUpdateFunc;
	public FOnTimelineEvent TimelineFinishedFunc;
	public TWeakObjectPtr<UObject> PropertySetObject;
	public string DirectionPropertyName;
}
