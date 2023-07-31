#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableSkeletalComponent.h")]
public partial class UCustomizableSkeletalComponent : USceneComponent {
	///<summary>SkippedLastRenderTime</summary>
	public float SkippedLastRenderTime;
	///<summary>CustomizableObjectInstance</summary>
	public UCustomizableObjectInstance CustomizableObjectInstance;
	///<summary>ComponentIndex</summary>
	public int ComponentIndex;
	///<summary>UpdateSkeletalMeshAsync</summary>
	public  void UpdateSkeletalMeshAsync(bool bNeverSkipUpdate/*=false*/) {}
}
