using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Engine/LocalPlayer.h")]
    public partial class ULocalPlayer : UPlayer {
        public static T GetSubsystem<T>(ULocalPlayer LocalPlayer) { return default(T); }
    }

}