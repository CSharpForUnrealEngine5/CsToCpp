#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimEditorTypes.h")]
///<summary>Struct used to construct the widget for adding a new set</summary>
public partial struct FContextualAnimNewAnimSetParams {
// ContextualAnimNewAnimSetParams
	public string SectionName;
	public TArray<FContextualAnimNewAnimSetData> Data;
	public float RandomWeight;
}
