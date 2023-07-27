#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TwitterIntegrationBase.h")]
public partial class UTwitterIntegrationBase : UPlatformInterfaceBase {
// TwitterIntegrationBase
	public  void Init() {}
	public  bool CanShowTweetUI() { return default; }
	public  bool ShowTweetUI(string InitialMessage,string URL,string Picture) { return default; }
	public  bool AuthorizeAccounts() { return default; }
	public  int GetNumAccounts() { return default; }
	public  string GetAccountName(int AccountIndex) { return default; }
	public  bool TwitterRequest(string URL,TArray<string> ParamKeysAndValues,ETwitterRequestMethod RequestMethod,int AccountIndex) { return default; }
}
