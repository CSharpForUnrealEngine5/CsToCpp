namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditorSettings.h")]
public partial class UMaterialEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Path to user installed Mali shader compiler that can be used by the material editor to compile and extract shader informations for Android platforms.</summary>
	public FFilePath MaliOfflineCompilerPath;
	///<summary>The width (in pixels) of the preview viewport when a material editor is first opened</summary>
	public int DefaultPreviewWidth;
	///<summary>The height (in pixels) of the preview viewport when a material editor is first opened</summary>
	public int DefaultPreviewHeight;
	///<summary>Configures the background shown behind the UI material preview</summary>
	public FPreviewBackgroundSettings PreviewBackground;
}
