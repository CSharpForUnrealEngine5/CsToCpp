#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebBrowser.h")]
public partial class UWebBrowser : UWidget {
// WebBrowser
	public void FOnUrlChanged(string Text) {}
	public void FOnBeforePopup(string URL,string Frame) {}
	public void FOnConsoleMessage(string Message,string Source,int Line) {}
	public void LoadURL(string NewURL) {}
	public void LoadString(string Contents,string DummyURL) {}
	public void ExecuteJavascript(string ScriptText) {}
	public string GetTitleText() { return default; }
	public string GetUrl() { return default; }
	public FOnUrlChanged OnUrlChanged;
	public FOnBeforePopup OnBeforePopup;
	public FOnConsoleMessage OnConsoleMessage;
	public string InitialURL;
	public bool bSupportsTransparency;
}
