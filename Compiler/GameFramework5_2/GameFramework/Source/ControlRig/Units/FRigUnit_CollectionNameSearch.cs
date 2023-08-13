namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Creates a collection based on a name search.</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionNameSearch {
	public string PartialName;
	public ERigElementType TypeToSearch;
	public FRigElementKeyCollection Collection;
}
