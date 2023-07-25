#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewModels/DMXPixelMappingLayoutViewModel.h")]
///<summary>Model for the Layout View</summary>
public partial class UDMXPixelMappingLayoutViewModel : UObject {
// DMXPixelMappingLayoutViewModel
	public TWeakObjectPtr<UDMXPixelMappingRendererComponent> RendererComponent;
	public TArray<TWeakObjectPtr<UDMXPixelMappingScreenComponent>> ScreenComponents;
	public TArray<TWeakObjectPtr<UDMXPixelMappingFixtureGroupComponent>> FixtureGroupComponents;
	public TArray<TWeakObjectPtr<UDMXPixelMappingMatrixComponent>> MatrixComponents;
	public TSoftObjectPtr<UClass> LayoutScriptClass;
}
