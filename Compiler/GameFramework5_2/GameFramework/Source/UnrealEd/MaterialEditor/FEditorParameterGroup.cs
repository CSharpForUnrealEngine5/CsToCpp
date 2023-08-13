namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditor/MaterialEditorInstanceConstant.h")]
public partial struct FEditorParameterGroup {
	public string GroupName;
	public EMaterialParameterAssociation GroupAssociation;
	public TArray<UDEditorParameterValue> Parameters;
	public int GroupSortPriority;
}
