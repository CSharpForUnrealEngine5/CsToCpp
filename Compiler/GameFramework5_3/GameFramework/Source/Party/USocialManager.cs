namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Singleton manager at the top of the social framework</summary>
[CppInclude("SocialManager.h")]
public partial class USocialManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>SocialToolkits</summary>
	public TArray<USocialToolkit> SocialToolkits;
	///<summary>SocialDebugTools</summary>
	public USocialDebugTools SocialDebugTools;
}
