#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SocialManager.h")]
///<summary>Singleton manager at the top of the social framework</summary>
public partial class USocialManager : UObject {
// SocialManager
	public TArray<USocialToolkit> SocialToolkits;
	public USocialDebugTools SocialDebugTools;
}
