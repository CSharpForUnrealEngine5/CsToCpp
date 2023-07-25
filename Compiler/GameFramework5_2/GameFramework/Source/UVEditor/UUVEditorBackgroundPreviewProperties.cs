#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UVEditorBackgroundPreview.h")]
///<summary>Visualization settings for the UUVEditorBackgroundPreview</summary>
public partial class UUVEditorBackgroundPreviewProperties : UInteractiveToolPropertySet {
// UVEditorBackgroundPreviewProperties
	public bool bVisible;
	public EUVEditorBackgroundSourceType SourceType;
	public UTexture2D SourceTexture;
	public UMaterial SourceMaterial;
	public TArray<int> UDIMBlocks;
	public bool bUDIMsEnabled;
}
