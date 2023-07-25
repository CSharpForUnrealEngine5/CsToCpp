#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Fonts/CompositeFont.h")]
public partial struct FCompositeFont {
// CompositeFont
	public FTypeface DefaultTypeface;
	public FCompositeFallbackFont FallbackTypeface;
	public TArray<FCompositeSubFont> SubTypefaces;
}
