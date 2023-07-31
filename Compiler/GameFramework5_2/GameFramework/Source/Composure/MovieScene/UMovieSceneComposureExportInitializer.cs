#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Object passed to comp shot elements to initialize them for export.</summary>
[CppInclude("MovieScene/MovieSceneComposureExportSectionTemplate.h")]
public partial class UMovieSceneComposureExportInitializer : UObject {
	///<summary>Initialize the export to capture the specified named buffer visualization targets from a scene capture</summary>
	public  void ExportSceneCaptureBuffers(ACompositingElement CompShotElement,USceneCaptureComponent2D SceneCapture,TArray<string> BuffersToExport) {}
}
