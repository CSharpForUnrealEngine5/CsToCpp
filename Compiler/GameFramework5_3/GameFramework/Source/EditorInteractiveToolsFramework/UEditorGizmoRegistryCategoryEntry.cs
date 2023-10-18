namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditorInteractiveGizmoRegistry.h")]
public partial class UEditorGizmoRegistryCategoryEntry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GizmoTypes</summary>
	public TArray<UInteractiveGizmoBuilder> GizmoTypes;
	///<summary>CategoryName</summary>
	public string CategoryName;
}
