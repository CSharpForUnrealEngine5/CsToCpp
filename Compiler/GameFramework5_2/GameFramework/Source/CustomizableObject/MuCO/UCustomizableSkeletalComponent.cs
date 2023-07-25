#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableSkeletalComponent.h")]
public partial class UCustomizableSkeletalComponent : USceneComponent {
// CustomizableSkeletalComponent
	public float SkippedLastRenderTime;
	public UCustomizableObjectInstance CustomizableObjectInstance;
	public int ComponentIndex;
	public void UpdateSkeletalMeshAsync(bool bNeverSkipUpdate/*=false*/) {}
}
