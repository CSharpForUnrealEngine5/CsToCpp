#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WaterEditorSubsystem.h")]
public partial class UWaterEditorSubsystem : UEditorSubsystem {
	public static UClass StaticClass() {return default;}
	///<summary>LandscapeMaterialParameterCollection</summary>
	public UMaterialParameterCollection LandscapeMaterialParameterCollection;
	///<summary>WaterActorSprites</summary>
	public TMap<UClass,UTexture2D> WaterActorSprites;
	///<summary>DefaultWaterActorSprite</summary>
	public UTexture2D DefaultWaterActorSprite;
	///<summary>ErrorSprite</summary>
	public UTexture2D ErrorSprite;
}
