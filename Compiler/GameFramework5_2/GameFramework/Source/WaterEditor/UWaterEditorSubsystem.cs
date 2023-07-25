#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSubsystem.h")]
public partial class UWaterEditorSubsystem : UEditorSubsystem {
// WaterEditorSubsystem
	public UMaterialParameterCollection LandscapeMaterialParameterCollection;
	public TMap<UClass,UTexture2D> WaterActorSprites;
	public UTexture2D DefaultWaterActorSprite;
	public UTexture2D ErrorSprite;
}
