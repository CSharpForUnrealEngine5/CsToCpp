namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Visualization settings for the UUVEditorBackgroundPreview</summary>
[CppInclude("UVEditorBackgroundPreview.h")]
public partial class UUVEditorBackgroundPreviewProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Should the background be shown (Alt+B)</summary>
	public bool bVisible;
	///<summary>Source of background visuals</summary>
	public EUVEditorBackgroundSourceType SourceType;
	///<summary>Display a background based on the selected texture</summary>
	public UTexture2D SourceTexture;
	///<summary>Display a background based on the selected material</summary>
	public UMaterial SourceMaterial;
	///<summary>UDIMBlocks</summary>
	public TArray<int> UDIMBlocks;
	///<summary>bUDIMsEnabled</summary>
	public bool bUDIMsEnabled;
}
