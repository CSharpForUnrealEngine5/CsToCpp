namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BehaviorTree/BlackboardAssetProvider.h")]
public partial class UBlackboardAssetProvider : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Returns BlackboardData referenced by the owner object.</summary>
	public virtual UBlackboardData GetBlackboardAsset() { return default; }
}
