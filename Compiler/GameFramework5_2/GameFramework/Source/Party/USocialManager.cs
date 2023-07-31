#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Singleton manager at the top of the social framework</summary>
[CppInclude("SocialManager.h")]
public partial class USocialManager : UObject {
	///<summary>SocialToolkits</summary>
	public TArray<USocialToolkit> SocialToolkits;
	///<summary>SocialDebugTools</summary>
	public USocialDebugTools SocialDebugTools;
}
