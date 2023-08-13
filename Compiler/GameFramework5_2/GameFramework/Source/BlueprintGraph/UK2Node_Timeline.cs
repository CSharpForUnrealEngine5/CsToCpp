namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_Timeline.h")]
public partial class UK2Node_Timeline : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The name of the timeline. Used to name ONLY the member variable (Component). To obtain the name of timeline template use UTimelineTemplate::TimelineVariableNameToTemplateName</summary>
	public string TimelineName;
	///<summary>If the timeline is set to autoplay</summary>
	public bool bAutoPlay;
	///<summary>Unique ID for the template we use, required to indentify the timeline after a paste</summary>
	public FGuid TimelineGuid;
	///<summary>If the timeline is set to loop</summary>
	public bool bLoop;
	///<summary>If the timeline is set to replicate</summary>
	public bool bReplicated;
	///<summary>If the timeline should ignore global time dilation</summary>
	public bool bIgnoreTimeDilation;
}
