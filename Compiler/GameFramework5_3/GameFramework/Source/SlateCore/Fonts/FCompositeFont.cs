namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Fonts/CompositeFont.h")]
public partial struct FCompositeFont {
	public FTypeface DefaultTypeface;
	public FCompositeFallbackFont FallbackTypeface;
	public TArray<FCompositeSubFont> SubTypefaces;
}
