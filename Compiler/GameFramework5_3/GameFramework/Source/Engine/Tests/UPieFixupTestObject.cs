namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/PieFixupTestObjects.h")]
public partial class UPieFixupTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Path</summary>
	public FSoftObjectPath Path;
	///<summary>TypedPtr</summary>
	public TSoftObjectPtr<AActor> TypedPtr;
	///<summary>Struct</summary>
	public FPieFixupStructWithSoftObjectPath Struct;
	///<summary>Array</summary>
	public TArray<FPieFixupStructWithSoftObjectPath> Array;
}
