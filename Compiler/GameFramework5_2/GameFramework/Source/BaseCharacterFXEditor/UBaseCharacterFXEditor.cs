#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base UAssetEditor class for character simulation asset editors (e.g. cloth, hair, flesh).</summary>
[CppInclude("BaseCharacterFXEditor.h")]
public partial class UBaseCharacterFXEditor : UAssetEditor {
	///<summary>OriginalObjectsToEdit</summary>
	public TArray<UObject> OriginalObjectsToEdit;
}
