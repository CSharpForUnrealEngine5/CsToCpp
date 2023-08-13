namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimationDataSource.h")]
public partial class UAnimationDataSourceRegistry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>DataSources</summary>
	public TMap<string,TWeakObjectPtr<UObject>> DataSources;
}
