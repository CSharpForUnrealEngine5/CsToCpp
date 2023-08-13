namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Entry for a delegate to assign after a blueprint has been instanced</summary>
[CppInclude("Engine/ComponentDelegateBinding.h")]
public partial struct FBlueprintComponentDelegateBinding {
	public string ComponentPropertyName;
	public string DelegatePropertyName;
	public string FunctionNameToBind;
}
