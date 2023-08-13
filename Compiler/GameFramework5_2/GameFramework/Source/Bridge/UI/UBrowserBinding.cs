namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UI/BrowserBinding.h")]
public partial class UBrowserBinding : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DialogSuccessCallback</summary>
	public void DialogSuccessCallback(FWebJSFunction DialogJSCallback) {}
	///<summary>DialogFailCallback</summary>
	public void DialogFailCallback(FWebJSFunction DialogJSCallback) {}
	///<summary>OnDroppedCallback</summary>
	public void OnDroppedCallback(FWebJSFunction OnDroppedJSCallback) {}
	///<summary>OnDropDiscardedCallback</summary>
	public void OnDropDiscardedCallback(FWebJSFunction OnDropDiscardedJSCallback) {}
	///<summary>OnExitCallback</summary>
	public void OnExitCallback(FWebJSFunction OnExitJSCallback) {}
	///<summary>SaveAuthToken</summary>
	public void SaveAuthToken(string Value) {}
	///<summary>GetAuthToken</summary>
	public string GetAuthToken() { return default; }
	///<summary>SendSuccess</summary>
	public void SendSuccess(string Value) {}
	///<summary>SendFailure</summary>
	public void SendFailure(string Message) {}
	///<summary>ShowDialog</summary>
	public void ShowDialog(string Type,string Url) {}
	///<summary>DragStarted</summary>
	public void DragStarted(TArray<string> ImageUrl,TArray<string> IDs,TArray<string> Types) {}
	///<summary>ShowLoginDialog</summary>
	public void ShowLoginDialog(string LoginUrl,string ResponseCodeUrl) {}
	///<summary>OpenExternalUrl</summary>
	public void OpenExternalUrl(string Url) {}
	///<summary>ExportDataToMSPlugin</summary>
	public void ExportDataToMSPlugin(string Data) {}
	///<summary>GetProjectPath</summary>
	public string GetProjectPath() { return default; }
	///<summary>Logout</summary>
	public void Logout() {}
	///<summary>StartNodeProcess</summary>
	public void StartNodeProcess() {}
	///<summary>RestartNodeProcess</summary>
	public void RestartNodeProcess() {}
	///<summary>OpenMegascansPluginSettings</summary>
	public void OpenMegascansPluginSettings() {}
}
