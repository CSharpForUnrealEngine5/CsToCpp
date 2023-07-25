#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AssetManagerTypes.h")]
///<summary>Rule about when to cook/ship a primary asset</summary>
public enum EPrimaryAssetCookRule {
	Unknown=0,
	NeverCook=1,
	ProductionNeverCook=2,
	DevelopmentCook=-1,
	DevelopmentAlwaysProductionNeverCook=-1,
	DevelopmentAlwaysCook=-1,
	DevelopmentAlwaysProductionUnknownCook=-1,
	AlwaysCook=-1,
}
