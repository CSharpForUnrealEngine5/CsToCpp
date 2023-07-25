#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectSystem.h")]
public partial class UCustomizableObjectSystem : UObject {
// CustomizableObjectSystem
	public UObject GetInstance() { return default; }
	public TArray<FPendingReleaseSkeletalMeshInfo> PendingReleaseSkeletalMesh;
	public UDefaultImageProvider DefaultImageProvider;
	public string GetPluginVersion() { return default; }
	public int GetNumInstances() { return default; }
	public int GetNumPendingInstances() { return default; }
	public int GetTotalInstances() { return default; }
	public int GetTextureMemoryUsed() { return default; }
	public int GetAverageBuildTime() { return default; }
	public void SetReleaseMutableTexturesImmediately(bool bReleaseTextures) {}
	public UCustomizableInstanceLODManagementBase DefaultInstanceLODManagement;
	public UCustomizableInstanceLODManagementBase CurrentInstanceLODManagement;
	public TArray<UTexture2D> ProtectedCachedTextures;
}
