namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tools derived from this class provide parameter details and operate modally.</summary>
[CppInclude("FractureTool.h")]
public partial class UFractureModalTool : UFractureActionTool {
	public static UClass StaticClass() {return default;}
	///<summary>Geometry collection components referenced by visualizations</summary>
	public TArray<UGeometryCollectionComponent> VisualizedCollections;
}
