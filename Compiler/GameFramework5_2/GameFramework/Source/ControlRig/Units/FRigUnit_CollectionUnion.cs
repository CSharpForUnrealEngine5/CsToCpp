namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the union of two provided collections</summary>
[CppInclude("Units/Execution/RigUnit_Collection.h")]
public partial struct FRigUnit_CollectionUnion {
	public FRigElementKeyCollection A;
	public FRigElementKeyCollection B;
	public bool bAllowDuplicates;
	public FRigElementKeyCollection Collection;
}
