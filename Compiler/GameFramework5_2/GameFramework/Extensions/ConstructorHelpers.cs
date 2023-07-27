namespace GameFramework;

public partial struct ConstructorHelpers
{
    public struct FObjectFinder<T>
    {
        FObjectFinder(string path) { }

        bool Succeeded() { return false; }

        T Object;
    }
}
