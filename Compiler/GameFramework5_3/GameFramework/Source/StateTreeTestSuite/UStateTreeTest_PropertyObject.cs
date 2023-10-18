namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeTestTypes.h")]
public partial class UStateTreeTest_PropertyObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>InstancedObject</summary>
	public UStateTreeTest_PropertyObjectInstanced InstancedObject;
	///<summary>ArrayOfInstancedObjects</summary>
	public TArray<UStateTreeTest_PropertyObjectInstanced> ArrayOfInstancedObjects;
	///<summary>ArrayOfInts</summary>
	public TArray<int> ArrayOfInts;
	///<summary>InstancedStruct</summary>
	public FInstancedStruct InstancedStruct;
	///<summary>ArrayOfInstancedStructs</summary>
	public TArray<FInstancedStruct> ArrayOfInstancedStructs;
	///<summary>Struct</summary>
	public FStateTreeTest_PropertyStruct Struct;
	///<summary>ArrayOfStruct</summary>
	public TArray<FStateTreeTest_PropertyStruct> ArrayOfStruct;
}
