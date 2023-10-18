namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This class contains the logic for handling distortion visualization within the UV Editor. It manages the setting</summary>
[CppInclude("UVEditorDistortionVisualization.h")]
public partial class UUVEditorDistortionVisualization : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UUVEditorDistortionVisualizationProperties Settings;
	///<summary>Targets</summary>
	public TArray<UUVEditorToolMeshInput> Targets;
}
