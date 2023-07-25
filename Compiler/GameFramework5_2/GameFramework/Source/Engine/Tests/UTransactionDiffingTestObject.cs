#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/TransactionDiffingTests.h")]
public partial class UTransactionDiffingTestObject : UObject {
// TransactionDiffingTestObject
	public TArray<string> NamesArray;
	public string AdditionalName;
	public TArray<UObject> ObjectsArray;
	public UObject AdditionalObject;
	public TArray<TSoftObjectPtr<UObject>> SoftObjectsArray;
	public TSoftObjectPtr<UObject> AdditionalSoftObject;
	public int PropertyData;
}
