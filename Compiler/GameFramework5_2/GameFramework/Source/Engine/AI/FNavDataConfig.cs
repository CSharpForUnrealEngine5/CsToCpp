#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/NavigationTypes.h")]
public partial struct FNavDataConfig {
	public string Name;
	public FColor Color;
	public FVector DefaultQueryExtent;
	public UClass NavigationDataClass;
	public TSoftObjectPtr<UClass> NavDataClass;
}
