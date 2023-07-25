#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Properties/UVLayoutProperties.h")]
///<summary>UV Layout Settings</summary>
public partial class UUVLayoutProperties : UInteractiveToolPropertySet {
// UVLayoutProperties
	public EUVLayoutType LayoutType;
	public int TextureResolution;
	public float Scale;
	public FVector2D Translation;
	public bool bAllowFlips;
	public bool bEnableUDIMLayout;
	public bool bUDIMCVAREnabled;
}
