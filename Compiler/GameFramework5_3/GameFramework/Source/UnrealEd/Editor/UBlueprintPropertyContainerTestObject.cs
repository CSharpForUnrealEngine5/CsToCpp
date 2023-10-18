namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/PropertyEditorTestObject.h")]
public partial class UBlueprintPropertyContainerTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Array</summary>
	public TArray<UBlueprintPropertyTestObject> Array;
}
