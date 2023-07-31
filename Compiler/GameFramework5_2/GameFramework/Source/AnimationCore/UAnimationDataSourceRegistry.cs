#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationDataSource.h")]
public partial class UAnimationDataSourceRegistry : UObject {
	///<summary>DataSources</summary>
	public TMap<string,TWeakObjectPtr<UObject>> DataSources;
}
