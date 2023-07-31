#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DMXFixtureComponent.h")]
public partial class UDMXFixtureComponent : UActorComponent {
	///<summary>Initializes the component</summary>
	public  void Initialize() {}
	///<summary>If used within a DMX Fixture Actor or Fixture Matrix Actor, the component only receives data when set to true. Else needs be implemented in blueprints.</summary>
	public bool bIsEnabled;
	///<summary>Value changes smaller than this threshold are ignored</summary>
	public float SkipThreshold;
	///<summary>If used within a DMX Fixture Actor or Fixture Matrix Actor, the plugin interpolates towards the last set value.</summary>
	public bool bUseInterpolation;
	///<summary>The scale of the interpolation speed. Faster when &gt; 1, slower when &lt; 1</summary>
	public float InterpolationScale;
	///<summary>True if the component is attached to a matrix fixture</summary>
	public bool bUsingMatrixData;
	///<summary>If attached to a DMX Fixture Actor, returns the parent fixture actor.</summary>
	public  ADMXFixtureActor GetParentFixtureActor() { return default; }
	///<summary>Reads pixel color in the middle of each &quot;Texture&quot; and output linear colors</summary>
	public  TArray<FLinearColor> GetTextureCenterColors(UTexture2D TextureAtlas,int numTextures) { return default; }
	///<summary>Called each tick when interpolation is enabled, to calculate the next value</summary>
	public  void InterpolateComponent(float DeltaSeconds) {}
	///<summary>Called to initialize the component in blueprints</summary>
	public  void InitializeComponent() {}
	///<summary>Should be implemented to let other objects (e.g. datasmith) know which attributes the component can handle</summary>
	public  void GetSupportedDMXAttributes(TArray<string> OutAttributeNames) {}
}
