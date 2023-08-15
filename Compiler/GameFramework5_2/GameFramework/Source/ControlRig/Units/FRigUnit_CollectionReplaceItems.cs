namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Replaces all names within the collection</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionReplaceItems {
	public FRigElementKeyCollection Items;
	public FName Old;
	public FName New;
	public bool RemoveInvalidItems;
	public bool bAllowDuplicates;
	public FRigElementKeyCollection Collection;
}
