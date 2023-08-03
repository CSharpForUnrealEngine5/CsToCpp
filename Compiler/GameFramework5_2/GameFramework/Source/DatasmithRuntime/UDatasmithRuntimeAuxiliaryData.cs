#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Asset user data that can be used with DatasmithRuntime on Actors and other objects</summary>
[CppInclude("DatasmithRuntimeAuxiliaryData.h")]
public partial class UDatasmithRuntimeAuxiliaryData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>Auxiliary</summary>
	public UObject Auxiliary;
}
