using System.Collections.Concurrent;

namespace DataProcessor;

static internal class FilesToProcess
{
    //using System.Collections.Concurrent;
    public static ConcurrentDictionary<string, string> Files = new();

    //public static MemoryCache Files = MemoryCache.Default;

}
