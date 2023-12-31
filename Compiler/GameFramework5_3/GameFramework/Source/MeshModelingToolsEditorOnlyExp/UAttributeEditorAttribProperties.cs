namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorAttribProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>VertexAttributes</summary>
	public TArray<string> VertexAttributes;
	///<summary>InstanceAttributes</summary>
	public TArray<string> InstanceAttributes;
	///<summary>TriangleAttributes</summary>
	public TArray<string> TriangleAttributes;
	///<summary>PolygonAttributes</summary>
	public TArray<string> PolygonAttributes;
	///<summary>EdgeAttributes</summary>
	public TArray<string> EdgeAttributes;
	///<summary>GroupAttributes</summary>
	public TArray<string> GroupAttributes;
}
