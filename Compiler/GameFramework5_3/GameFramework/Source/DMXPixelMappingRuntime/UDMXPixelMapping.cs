namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Public container of Pixel Mapping object and it using for asset</summary>
[CppInclude("DMXPixelMapping.h")]
public partial class UDMXPixelMapping : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Get root component of the component tree</summary>
	public UDMXPixelMappingRootComponent GetRootComponent() { return default; }
	///<summary>Holds the reference to root component</summary>
	public UDMXPixelMappingRootComponent RootComponent;
	///<summary>Holds the Thumbnail for asset</summary>
	public UTexture ThumbnailImage;
}
