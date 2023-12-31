namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/TransactionDiffingTests.h")]
public partial class UTransactionDiffingTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>NamesArray</summary>
	public TArray<FName> NamesArray;
	///<summary>AdditionalName</summary>
	public FName AdditionalName;
	///<summary>ObjectsArray</summary>
	public TArray<UObject> ObjectsArray;
	///<summary>AdditionalObject</summary>
	public UObject AdditionalObject;
	///<summary>SoftObjectsArray</summary>
	public TArray<TSoftObjectPtr<UObject>> SoftObjectsArray;
	///<summary>AdditionalSoftObject</summary>
	public TSoftObjectPtr<UObject> AdditionalSoftObject;
	///<summary>PropertyData</summary>
	public int PropertyData;
}
