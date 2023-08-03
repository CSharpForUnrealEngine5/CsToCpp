#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/Commandlet.h")]
public partial class UCommandlet : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Description of the commandlet&#39;s purpose</summary>
	public string HelpDescription;
	///<summary>Usage template to show for &quot;ucc help&quot;</summary>
	public string HelpUsage;
	///<summary>Hyperlink for more info</summary>
	public string HelpWebLink;
	///<summary>The name of the parameter the commandlet takes</summary>
	public TArray<string> HelpParamNames;
	///<summary>The description of the parameter</summary>
	public TArray<string> HelpParamDescriptions;
	///<summary>Whether to load objects required in server, client, and editor context.  If IsEditor is set to false, then a</summary>
	public bool IsServer;
	///<summary>IsClient</summary>
	public bool IsClient;
	///<summary>IsEditor</summary>
	public bool IsEditor;
	///<summary>Whether to redirect standard log to the console</summary>
	public bool LogToConsole;
	///<summary>Whether to show standard error and warning count on exit</summary>
	public bool ShowErrorCount;
	///<summary>Whether to show cooking progress on tick</summary>
	public bool ShowProgress;
	///<summary>Whether to exit the process as soon as the commandlet completes, skipping the engine shutdown</summary>
	public bool FastExit;
}
