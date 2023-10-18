namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool to create a mesh from a set of selected Spline Components</summary>
[CppInclude("TriangulateSplinesTool.h")]
public partial class UTriangulateSplinesTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>TriangulateProperties</summary>
	public UTriangulateSplinesToolProperties TriangulateProperties;
	///<summary>OutputTypeProperties</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>TargetWorld</summary>
	public TWeakObjectPtr<UWorld> TargetWorld;
	///<summary>Note: We track actors instead of the USplineComponents here because the USplineComponents objects are often deleted / swapped for identical but new objects</summary>
	public TArray<TWeakObjectPtr<AActor>> ActorsWithSplines;
}
