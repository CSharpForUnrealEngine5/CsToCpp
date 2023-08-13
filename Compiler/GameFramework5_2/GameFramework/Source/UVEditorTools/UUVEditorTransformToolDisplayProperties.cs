namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Visualization settings for the TransformTool</summary>
[CppInclude("UVEditorTransformTool.h")]
public partial class UUVEditorTransformToolDisplayProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Draw the tool&#39;s active pivot location if needed.</summary>
	public bool bDrawPivots;
}
