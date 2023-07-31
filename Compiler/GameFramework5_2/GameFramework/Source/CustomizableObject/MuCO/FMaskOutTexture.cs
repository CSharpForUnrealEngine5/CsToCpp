#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a texture used for masking-out areas of an object from projectors</summary>
[CppInclude("MuCO/CustomizableObject.h")]
public partial struct FMaskOutTexture {
	public int SizeX;
	public int SizeY;
	public TArray<uint> Data;
}
