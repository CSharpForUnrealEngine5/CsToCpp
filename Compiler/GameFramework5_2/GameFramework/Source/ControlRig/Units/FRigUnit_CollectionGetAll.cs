#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates an item array for all elements given the filter.</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionGetAll {
	public ERigElementType TypeToSearch;
	public TArray<FRigElementKey> Items;
}
