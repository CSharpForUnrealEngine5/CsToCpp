namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/NavigationTypes.h")]
public partial struct FNavDataConfig {
	public FName Name;
	public FColor Color;
	public FVector DefaultQueryExtent;
	public UClass NavigationDataClass;
	public TSoftObjectPtr<UClass> NavDataClass;
}
