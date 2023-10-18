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
	///<summary>Update Skeletal Mesh asynchronously.</summary>
	public void UpdateSkeletalMeshAsync(bool bNeverSkipUpdate/*=false*/) {}
	///<summary>Update Skeletal Mesh asynchronously. Callback will be called once the update finishes, even if it fails.</summary>
	public void UpdateSkeletalMeshAsyncResult(FInstanceUpdateDelegate Callback,bool bIgnoreCloseDist/*=false*/,bool bForceHighPriority/*=false*/) {}
}
