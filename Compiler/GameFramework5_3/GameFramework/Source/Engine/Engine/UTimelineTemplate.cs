namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TimelineTemplate.h")]
public partial class UTimelineTemplate : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Length of this timeline</summary>
	public float TimelineLength;
	///<summary>How we want the timeline to determine its own length (e.g. specified length, last keyframe)</summary>
	public ETimelineLengthMode LengthMode;
	///<summary>If we want the timeline to auto-play</summary>
	public bool bAutoPlay;
	///<summary>If we want the timeline to loop</summary>
	public bool bLoop;
	///<summary>If we want the timeline to loop</summary>
	public bool bReplicated;
	///<summary>If we want the timeline to ignore global time dilation</summary>
	public bool bIgnoreTimeDilation;
	///<summary>Set of event tracks</summary>
	public TArray<FTTEventTrack> EventTracks;
	///<summary>Set of float interpolation tracks</summary>
	public TArray<FTTFloatTrack> FloatTracks;
	///<summary>Set of vector interpolation tracks</summary>
	public TArray<FTTVectorTrack> VectorTracks;
	///<summary>Set of linear color interpolation tracks</summary>
	public TArray<FTTLinearColorTrack> LinearColorTracks;
	///<summary>Metadata information for this timeline</summary>
	public TArray<FBPVariableMetaDataEntry> MetaDataArray;
	///<summary>TimelineGuid</summary>
	public FGuid TimelineGuid;
	///<summary>Allow control of Timeline component TickGroup assignment via TimelineTemplates</summary>
	public ETickingGroup TimelineTickGroup;
	///<summary>VariableName</summary>
	public FName VariableName;
	///<summary>DirectionPropertyName</summary>
	public FName DirectionPropertyName;
	///<summary>UpdateFunctionName</summary>
	public FName UpdateFunctionName;
	///<summary>FinishedFunctionName</summary>
	public FName FinishedFunctionName;
	///<summary>Whether or not this track is expanded in the UI.</summary>
	public TArray<FTTTrackId> TrackDisplayOrder;
}
