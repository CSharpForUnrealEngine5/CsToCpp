namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure storing information about one event track</summary>
[CppInclude("Engine/TimelineTemplate.h")]
public partial struct FTTEventTrack {
	public string FunctionName;
	public UCurveFloat CurveKeys;
}
