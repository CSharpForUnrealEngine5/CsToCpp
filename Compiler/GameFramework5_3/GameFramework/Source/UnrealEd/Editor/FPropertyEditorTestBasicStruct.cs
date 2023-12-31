namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This structs properties should be pushed out to categories inside its parent category unless it is in an array</summary>
[CppInclude("Editor/PropertyEditorTestObject.h")]
public partial struct FPropertyEditorTestBasicStruct {
	public int IntPropertyInsideAStruct;
	public float FloatPropertyInsideAStruct;
	public UObject ObjectPropertyInsideAStruct;
	public FPropertyEditorTestSubStruct InnerStruct;
}
