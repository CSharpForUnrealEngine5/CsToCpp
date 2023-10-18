namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Mass Agent Feature which appends a list of specified fragments.</summary>
[CppInclude("MassAssortedFragmentsTrait.h")]
public partial class UMassAssortedFragmentsTrait : UMassEntityTraitBase {
	public static UClass StaticClass() {return default;}
	///<summary>Fragments</summary>
	public TArray<FInstancedStruct> Fragments;
	///<summary>Tags</summary>
	public TArray<FInstancedStruct> Tags;
}
