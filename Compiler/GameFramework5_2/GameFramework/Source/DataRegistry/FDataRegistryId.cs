#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistryId.h")]
///<summary>Identifier for a specific DataRegistryItem, provides the user with a Tag or dropdown-based UI for selecting based on the available index info</summary>
public partial struct FDataRegistryId {
// DataRegistryId
	public FDataRegistryType RegistryType;
	public string ItemName;
}
