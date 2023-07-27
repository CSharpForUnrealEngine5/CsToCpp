#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/BrowserBinding.h")]
public partial class UBrowserBinding : UObject {
// BrowserBinding
	public  void DialogSuccessCallback(FWebJSFunction DialogJSCallback) {}
	public  void DialogFailCallback(FWebJSFunction DialogJSCallback) {}
	public  void OnDroppedCallback(FWebJSFunction OnDroppedJSCallback) {}
	public  void OnDropDiscardedCallback(FWebJSFunction OnDropDiscardedJSCallback) {}
	public  void OnExitCallback(FWebJSFunction OnExitJSCallback) {}
	public  void SaveAuthToken(string Value) {}
	public  string GetAuthToken() { return default; }
	public  void SendSuccess(string Value) {}
	public  void SendFailure(string Message) {}
	public  void ShowDialog(string Type,string Url) {}
	public  void DragStarted(TArray<string> ImageUrl,TArray<string> IDs,TArray<string> Types) {}
	public  void ShowLoginDialog(string LoginUrl,string ResponseCodeUrl) {}
	public  void OpenExternalUrl(string Url) {}
	public  void ExportDataToMSPlugin(string Data) {}
	public  string GetProjectPath() { return default; }
	public  void Logout() {}
	public  void StartNodeProcess() {}
	public  void RestartNodeProcess() {}
	public  void OpenMegascansPluginSettings() {}
}
