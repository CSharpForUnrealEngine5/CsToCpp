#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OnlineHotfixManager.h")]
///<summary>This class manages the downloading and application of hotfix data</summary>
public partial class UOnlineHotfixManager : UObject {
// OnlineHotfixManager
	public string OSSName;
	public string HotfixManagerClassName;
	public string DebugPrefix;
	public  void StartHotfixProcess() {}
	public TArray<UObject> AssetsHotfixedFromIniFiles;
}
