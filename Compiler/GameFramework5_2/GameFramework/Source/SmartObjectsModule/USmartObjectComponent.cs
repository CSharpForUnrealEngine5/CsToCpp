#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectComponent.h")]
public partial class USmartObjectComponent : USceneComponent {
// SmartObjectComponent
	public USmartObjectDefinition DefinitionAsset;
	public FSmartObjectHandle RegisteredHandle;
	public bool bCanBePartOfCollection;
}
