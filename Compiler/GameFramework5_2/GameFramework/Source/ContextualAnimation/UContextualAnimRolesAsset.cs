namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimSceneAsset.h")]
public partial class UContextualAnimRolesAsset : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Roles</summary>
	public TArray<FContextualAnimRoleDefinition> Roles;
}
