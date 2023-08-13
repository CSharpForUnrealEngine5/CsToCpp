namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The actual asset editor class doesn&#39;t have that much in it, intentionally.</summary>
[CppInclude("UVEditor.h")]
public partial class UUVEditor : UAssetEditor {
	public static UClass StaticClass() {return default;}
	///<summary>OriginalObjectsToEdit</summary>
	public TArray<UObject> OriginalObjectsToEdit;
}
