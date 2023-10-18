namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WidgetBlueprint.h")]
public partial struct FDelegateEditorBinding {
	public string ObjectName;
	public FName PropertyName;
	public FName FunctionName;
	public FName SourceProperty;
	public FEditorPropertyPath SourcePath;
	public FGuid MemberGuid;
	public EBindingKind Kind;
}
