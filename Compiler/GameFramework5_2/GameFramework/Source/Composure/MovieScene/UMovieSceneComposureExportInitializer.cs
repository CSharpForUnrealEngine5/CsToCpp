namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object passed to comp shot elements to initialize them for export.</summary>
[CppInclude("MovieScene/MovieSceneComposureExportSectionTemplate.h")]
public partial class UMovieSceneComposureExportInitializer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize the export to capture the specified named buffer visualization targets from a scene capture</summary>
	public void ExportSceneCaptureBuffers(ACompositingElement CompShotElement,USceneCaptureComponent2D SceneCapture,TArray<string> BuffersToExport) {}
}
