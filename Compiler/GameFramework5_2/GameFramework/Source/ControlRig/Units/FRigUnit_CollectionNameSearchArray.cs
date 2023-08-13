namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates an item array based on a name search.</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionNameSearchArray {
	public string PartialName;
	public ERigElementType TypeToSearch;
	public TArray<FRigElementKey> Items;
}
