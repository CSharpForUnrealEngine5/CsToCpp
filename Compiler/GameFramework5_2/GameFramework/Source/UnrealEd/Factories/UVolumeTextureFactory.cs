#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory for creating volume texture</summary>
[CppInclude("Factories/VolumeTextureFactory.h")]
public partial class UVolumeTextureFactory : UFactory {
	///<summary>An initial texture to assign to the newly created volume texture</summary>
	public UTexture2D InitialTexture;
}
