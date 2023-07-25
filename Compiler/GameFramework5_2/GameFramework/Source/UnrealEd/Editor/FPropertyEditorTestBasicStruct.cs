#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Editor/PropertyEditorTestObject.h")]
///<summary>This structs properties should be pushed out to categories inside its parent category unless it is in an array</summary>
public partial struct FPropertyEditorTestBasicStruct {
// PropertyEditorTestBasicStruct
	public int IntPropertyInsideAStruct;
	public float FloatPropertyInsideAStruct;
	public UObject ObjectPropertyInsideAStruct;
	public FPropertyEditorTestSubStruct InnerStruct;
}
