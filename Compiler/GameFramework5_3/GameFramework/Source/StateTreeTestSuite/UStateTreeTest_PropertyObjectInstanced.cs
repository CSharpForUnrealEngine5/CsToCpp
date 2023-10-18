namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTestTypes.h")]
public partial class UStateTreeTest_PropertyObjectInstanced : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>A</summary>
	public int A;
	///<summary>InstancedStruct</summary>
	public FInstancedStruct InstancedStruct;
	///<summary>ArrayOfTags</summary>
	public TArray<FGameplayTag> ArrayOfTags;
}
