#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Framework/Text/TextLayout.h")]
///<summary>The different methods that can be used if a word is too long to be broken by the default line-break iterator.</summary>
public enum ETextWrappingPolicy {
	DefaultWrapping=0,
	AllowPerCharacterWrapping=1,
}
