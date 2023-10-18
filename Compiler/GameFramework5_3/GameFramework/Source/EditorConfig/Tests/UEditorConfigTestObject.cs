namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/EditorConfigTests.h")]
public partial class UEditorConfigTestObject : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Object</summary>
	public UObject Object;
	///<summary>Struct</summary>
	public FEditorConfigTestSimpleStruct Struct;
	///<summary>Number</summary>
	public int Number;
}
