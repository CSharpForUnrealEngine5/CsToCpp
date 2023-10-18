namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>3D vector represented using only a single byte per component</summary>
[CppInclude("LidarPointCloudShared.h")]
public partial struct FLidarPointCloudNormal {
	public byte X;
	public byte Y;
	public byte Z;
}
