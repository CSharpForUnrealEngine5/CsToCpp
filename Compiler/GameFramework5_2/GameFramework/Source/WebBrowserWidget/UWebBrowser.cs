#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WebBrowser.h")]
public partial class UWebBrowser : UWidget {
	public static UClass StaticClass() {return default;}
	///<summary>FOnUrlChanged</summary>
	public  void FOnUrlChanged(string Text) {}
	///<summary>FOnBeforePopup</summary>
	public  void FOnBeforePopup(string URL,string Frame) {}
	///<summary>FOnConsoleMessage</summary>
	public  void FOnConsoleMessage(string Message,string Source,int Line) {}
	///<summary>Load the specified URL</summary>
	public  void LoadURL(string NewURL) {}
	///<summary>Load a string as data to create a web page</summary>
	public  void LoadString(string Contents,string DummyURL) {}
	///<summary>Executes a JavaScript string in the context of the web page</summary>
	public  void ExecuteJavascript(string ScriptText) {}
	///<summary>Get the current title of the web page</summary>
	public  string GetTitleText() { return default; }
	///<summary>Gets the currently loaded URL.</summary>
	public  string GetUrl() { return default; }
	///<summary>Called when the Url changes.</summary>
	public FOnUrlChanged OnUrlChanged;
	///<summary>Called when a popup is about to spawn.</summary>
	public FOnBeforePopup OnBeforePopup;
	///<summary>Called when the browser has console spew to print</summary>
	public FOnConsoleMessage OnConsoleMessage;
	///<summary>URL that the browser will initially navigate to. The URL should include the protocol, eg http://</summary>
	public string InitialURL;
	///<summary>Should the browser window support transparency.</summary>
	public bool bSupportsTransparency;
}
