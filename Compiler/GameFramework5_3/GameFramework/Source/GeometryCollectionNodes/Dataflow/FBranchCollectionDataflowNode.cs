namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Branch between two Managed Array Collections based on Boolean condition</summary>
[CppInclude("Dataflow/GeometryCollectionNodes.h")]
public partial struct FBranchCollectionDataflowNode {
	public FManagedArrayCollection TrueCollection;
	public FManagedArrayCollection FalseCollection;
	public bool bCondition;
	public FManagedArrayCollection ChosenCollection;
}
