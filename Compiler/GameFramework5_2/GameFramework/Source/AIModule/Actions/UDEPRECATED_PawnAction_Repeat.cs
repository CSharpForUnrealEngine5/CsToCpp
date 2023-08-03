#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Actions/PawnAction_Repeat.h")]
public partial class UDEPRECATED_PawnAction_Repeat : UDEPRECATED_PawnAction {
	public static UClass StaticClass() {return default;}
	///<summary>Action to repeat. This instance won&#39;t really be run, it&#39;s a source for copying actions to be actually performed</summary>
	public UDEPRECATED_PawnAction ActionToRepeat_DEPRECATED;
	///<summary>RecentActionCopy_DEPRECATED</summary>
	public UDEPRECATED_PawnAction RecentActionCopy_DEPRECATED;
	///<summary>ChildFailureHandlingMode</summary>
	public EPawnActionFailHandling ChildFailureHandlingMode;
}
