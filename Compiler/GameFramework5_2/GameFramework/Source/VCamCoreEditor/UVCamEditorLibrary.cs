#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VCamEditorLibrary.h")]
public partial class UVCamEditorLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Find all loaded VCam Components own by an actor in the world editor. Exclude actor that are pending kill, in PIE, PreviewEditor, ...</summary>
	public static void GetAllVCamComponentsInLevel(TArray<UVCamComponent> VCamComponents) {}
}
