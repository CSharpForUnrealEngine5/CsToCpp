#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UVPWorldAssetUserData</summary>
[CppInclude("VPRootActor.h")]
public partial class UVPWorldAssetUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>LastSelectedRootActor</summary>
	public TLazyObjectPtr<AVPRootActor> LastSelectedRootActor;
}
