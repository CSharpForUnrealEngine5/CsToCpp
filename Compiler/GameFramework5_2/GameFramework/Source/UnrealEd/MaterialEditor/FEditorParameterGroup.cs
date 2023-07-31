#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditor/MaterialEditorInstanceConstant.h")]
public partial struct FEditorParameterGroup {
	public string GroupName;
	public EMaterialParameterAssociation GroupAssociation;
	public TArray<UDEditorParameterValue> Parameters;
	public int GroupSortPriority;
}
