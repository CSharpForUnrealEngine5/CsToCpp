namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>SparseVolumeTexture base interface to communicate with material graph and shader bindings.</summary>
[CppInclude("SparseVolumeTexture/SparseVolumeTexture.h")]
public partial class USparseVolumeTexture : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GetSizeX</summary>
	public virtual int GetSizeX() { return default; }
	///<summary>GetSizeY</summary>
	public virtual int GetSizeY() { return default; }
	///<summary>GetSizeZ</summary>
	public virtual int GetSizeZ() { return default; }
	///<summary>GetNumFrames</summary>
	public virtual int GetNumFrames() { return default; }
	///<summary>GetNumMipLevels</summary>
	public virtual int GetNumMipLevels() { return default; }
}
