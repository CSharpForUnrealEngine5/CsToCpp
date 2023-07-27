#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureComponent.h")]
public partial class UDMXFixtureComponent : UActorComponent {
// DMXFixtureComponent
	public  void Initialize() {}
	public bool bIsEnabled;
	public float SkipThreshold;
	public bool bUseInterpolation;
	public float InterpolationScale;
	public bool bUsingMatrixData;
	public  ADMXFixtureActor GetParentFixtureActor() { return default; }
	public  TArray<FLinearColor> GetTextureCenterColors(UTexture2D TextureAtlas,int numTextures) { return default; }
	public  void InterpolateComponent(float DeltaSeconds) {}
	public  void InitializeComponent() {}
	public  void GetSupportedDMXAttributes(TArray<string> OutAttributeNames) {}
}
