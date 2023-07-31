#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Identifier for a specific DataRegistryItem, provides the user with a Tag or dropdown-based UI for selecting based on the available index info</summary>
[CppInclude("DataRegistryId.h")]
public partial struct FDataRegistryId {
	public FDataRegistryType RegistryType;
	public string ItemName;
}
