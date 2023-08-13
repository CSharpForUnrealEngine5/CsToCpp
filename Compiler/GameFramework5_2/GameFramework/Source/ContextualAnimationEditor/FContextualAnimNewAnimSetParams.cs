namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct used to construct the widget for adding a new set</summary>
[CppInclude("ContextualAnimEditorTypes.h")]
public partial struct FContextualAnimNewAnimSetParams {
	public string SectionName;
	public TArray<FContextualAnimNewAnimSetData> Data;
	public float RandomWeight;
}
