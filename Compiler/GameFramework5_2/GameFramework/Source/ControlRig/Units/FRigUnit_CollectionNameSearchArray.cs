#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Execution/RigUnit_Collection.h")]
///<summary>Creates an item array based on a name search.</summary>
public partial struct FRigUnit_CollectionNameSearchArray {
// RigUnit_CollectionNameSearchArray
	public string PartialName;
	public ERigElementType TypeToSearch;
	public TArray<FRigElementKey> Items;
}
