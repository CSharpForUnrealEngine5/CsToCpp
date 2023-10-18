namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Entry for a delegate to assign after a blueprint has been instanced</summary>
[CppInclude("Engine/ComponentDelegateBinding.h")]
public partial struct FBlueprintComponentDelegateBinding {
	public FName ComponentPropertyName;
	public FName DelegatePropertyName;
	public FName FunctionNameToBind;
}
