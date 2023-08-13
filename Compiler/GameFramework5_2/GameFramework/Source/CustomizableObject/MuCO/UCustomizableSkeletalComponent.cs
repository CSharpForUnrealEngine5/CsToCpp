namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableSkeletalComponent.h")]
public partial class UCustomizableSkeletalComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SkippedLastRenderTime</summary>
	public float SkippedLastRenderTime;
	///<summary>CustomizableObjectInstance</summary>
	public UCustomizableObjectInstance CustomizableObjectInstance;
	///<summary>ComponentIndex</summary>
	public int ComponentIndex;
	///<summary>UpdateSkeletalMeshAsync</summary>
	public void UpdateSkeletalMeshAsync(bool bNeverSkipUpdate/*=false*/) {}
}
