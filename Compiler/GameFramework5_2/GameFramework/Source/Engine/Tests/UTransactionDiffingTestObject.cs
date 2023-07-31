#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/TransactionDiffingTests.h")]
public partial class UTransactionDiffingTestObject : UObject {
	///<summary>NamesArray</summary>
	public TArray<string> NamesArray;
	///<summary>AdditionalName</summary>
	public string AdditionalName;
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
