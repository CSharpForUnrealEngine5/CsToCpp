namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Model for the Layout View</summary>
[CppInclude("ViewModels/DMXPixelMappingLayoutViewModel.h")]
public partial class UDMXPixelMappingLayoutViewModel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The Renderer Component currently in use</summary>
	public TWeakObjectPtr<UDMXPixelMappingRendererComponent> RendererComponent;
	///<summary>The Screen Components currently in use</summary>
	public TArray<TWeakObjectPtr<UDMXPixelMappingScreenComponent>> ScreenComponents;
	///<summary>The Fixture Group Components currently in use</summary>
	public TArray<TWeakObjectPtr<UDMXPixelMappingFixtureGroupComponent>> FixtureGroupComponents;
	///<summary>The Matrix Components currently in use</summary>
	public TArray<TWeakObjectPtr<UDMXPixelMappingMatrixComponent>> MatrixComponents;
	///<summary>The Layout Script class currently in use</summary>
	public TSoftObjectPtr<UClass> LayoutScriptClass;
}
