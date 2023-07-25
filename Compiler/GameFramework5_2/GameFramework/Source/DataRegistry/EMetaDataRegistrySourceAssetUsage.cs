#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataRegistrySource.h")]
///<summary>Rules specifying how a meta source will deal with assets, arranged as a semi-bitfield</summary>
public enum EMetaDataRegistrySourceAssetUsage {
	NoAssets=0,
	SearchAssets=1,
	RegisterAssets=2,
	SearchAndRegisterAssets=3,
}
