#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class manages the downloading and application of hotfix data</summary>
[CppInclude("OnlineHotfixManager.h")]
public partial class UOnlineHotfixManager : UObject {
	///<summary>Tells the hotfix manager which OSS to use. Uses the default if empty</summary>
	public string OSSName;
	///<summary>Tells the factory method which class to contruct</summary>
	public string HotfixManagerClassName;
	///<summary>Used to prevent development work from interfering with playtests, etc.</summary>
	public string DebugPrefix;
	///<summary>Starts the fetching of hotfix data from the OnlineTitleFileInterface that is registered for this game</summary>
	public  void StartHotfixProcess() {}
	///<summary>Array of objects that we&#39;re forcing to remain resident because we&#39;ve applied live hotfixes and won&#39;t get an</summary>
	public TArray<UObject> AssetsHotfixedFromIniFiles;
}
