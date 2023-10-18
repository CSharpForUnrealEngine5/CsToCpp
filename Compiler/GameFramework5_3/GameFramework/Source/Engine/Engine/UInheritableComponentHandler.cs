namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/InheritableComponentHandler.h")]
public partial class UInheritableComponentHandler : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>All component records</summary>
	public TArray<FComponentOverrideRecord> Records;
	///<summary>List of components that were marked unnecessary, need to keep these around so it doesn&#39;t regenerate them when a child asks for one</summary>
	public TArray<UActorComponent> UnnecessaryComponents;
}
