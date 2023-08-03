#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeEditorTool.h")]
public partial class UAttributeEditorNewAttributeActions : UAttributeEditorActionPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>NewName</summary>
	public string NewName;
	///<summary>UPROPERTY(EditAnywhere, Category = NewAttribute)</summary>
	public EAttributeEditorElementType ElementType;
	///<summary>UPROPERTY(EditAnywhere, Category = NewAttribute)</summary>
	public EAttributeEditorAttribType DataType;
	///<summary>Add a new Per-Vertex Weight Map layer with the given Name</summary>
	public  void AddWeightMapLayer() {}
	///<summary>Add a new PolyGroup layer with the given Name</summary>
	public  void AddPolyGroupLayer() {}
}
