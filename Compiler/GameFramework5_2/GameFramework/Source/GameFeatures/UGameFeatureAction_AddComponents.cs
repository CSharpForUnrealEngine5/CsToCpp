#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Adds actor&lt;-&gt;component spawn requests to the component manager</summary>
[CppInclude("GameFeatureAction_AddComponents.h")]
public partial class UGameFeatureAction_AddComponents : UGameFeatureAction {
	public static UClass StaticClass() {return default;}
	///<summary>List of components to add to gameplay actors when this game feature is enabled</summary>
	public TArray<FGameFeatureComponentEntry> ComponentList;
}
