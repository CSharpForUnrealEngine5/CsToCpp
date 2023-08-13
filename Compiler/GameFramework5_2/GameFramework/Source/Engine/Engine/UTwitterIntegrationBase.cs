namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TwitterIntegrationBase.h")]
public partial class UTwitterIntegrationBase : UPlatformInterfaceBase {
	public static UClass StaticClass() {return default;}
	///<summary>Perform any needed initialization</summary>
	public virtual void Init() {}
	///<summary>@return true if the user is allowed to use the Tweet UI</summary>
	public virtual bool CanShowTweetUI() { return default; }
	///<summary>Kicks off a tweet, using the platform to show the UI. If this returns false, or you are on a platform that doesn&#39;t support the UI,</summary>
	public virtual bool ShowTweetUI(string InitialMessage,string URL,string Picture) { return default; }
	///<summary>Starts the process of authorizing the local user(s). When TID_AuthorizeComplete is called, then GetNumAccounts()</summary>
	public virtual bool AuthorizeAccounts() { return default; }
	///<summary>@return The number of accounts that were authorized</summary>
	public virtual int GetNumAccounts() { return default; }
	///<summary>@return the display name of the given Twitter account</summary>
	public virtual string GetAccountName(int AccountIndex) { return default; }
	///<summary>Kicks off a generic twitter request</summary>
	public virtual bool TwitterRequest(string URL,TArray<string> ParamKeysAndValues,ETwitterRequestMethod RequestMethod,int AccountIndex) { return default; }
}
