#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
///<summary>Represents a texture used for masking-out areas of an object from projectors</summary>
public partial struct FMaskOutTexture {
// MaskOutTexture
	public int SizeX;
	public int SizeY;
	public TArray<uint> Data;
}
