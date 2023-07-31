#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replaces all names within the collection</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionReplaceItems {
	public FRigElementKeyCollection Items;
	public string Old;
	public string New;
	public bool RemoveInvalidItems;
	public bool bAllowDuplicates;
	public FRigElementKeyCollection Collection;
}
