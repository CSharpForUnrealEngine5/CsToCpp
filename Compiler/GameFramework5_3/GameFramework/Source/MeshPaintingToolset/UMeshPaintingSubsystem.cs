namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshPaintHelpers.h")]
public partial class UMeshPaintingSubsystem : UEngineSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>OverridePaintTexture</summary>
	public TWeakObjectPtr<UTexture> OverridePaintTexture;
}
