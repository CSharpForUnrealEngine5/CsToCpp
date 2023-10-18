namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>User data that can be attached to assets to provide namespaced data access.</summary>
[CppInclude("RigVMCore/RigVMAssetUserData.h")]
public partial class UNameSpacedUserData : UAssetUserData {
	public static UClass StaticClass() {return default;}
	///<summary>The namespace to use when looking up values inside of the user data.</summary>
	public string NameSpace;
}
