namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base UAssetEditor class for character simulation asset editors (e.g. cloth, hair, flesh).</summary>
[CppInclude("BaseCharacterFXEditor.h")]
public partial class UBaseCharacterFXEditor : UAssetEditor {
	public static UClass StaticClass() {return default;}
	///<summary>OriginalObjectsToEdit</summary>
	public TArray<UObject> OriginalObjectsToEdit;
}
