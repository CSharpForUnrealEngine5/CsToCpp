#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InheritableComponentHandler.h")]
public partial class UInheritableComponentHandler : UObject {
	///<summary>All component records</summary>
	public TArray<FComponentOverrideRecord> Records;
	///<summary>List of components that were marked unnecessary, need to keep these around so it doesn&#39;t regenerate them when a child asks for one</summary>
	public TArray<UActorComponent> UnnecessaryComponents;
}
