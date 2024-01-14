using System.Linq;

namespace Uaine.VersionController
{
    public static class VersionNumber
    {
        public const int A_Newer = 0;
        public const int A_Older = 1;
        public const int Same_Version = 2;

            public static bool isANewer(Version a, Version b)
        {
            bool newer = false;
            Version iteratorVersion = a;
            if (a.Depth < b.Depth)//there are more numbers in b
                iteratorVersion = b;

            for (int i = 0; i < iteratorVersion.Depth; i++)
            {
                if (a.versionNo[i] > b.versionNo[i])
                {
                    newer = true;
                    break;
                }
            }
            return newer;
        }
        public static int compareVersion(Version a, Version b)
        {
            if (a.specialAttr == b.specialAttr)
            {
                if (a.versionNo.SequenceEqual<int>(b.versionNo))
                    return Same_Version;
                else if (isANewer(a, b))//a is newer so...
                    return A_Newer;
                else
                    return A_Older;
            }
            //implied else
            return -1;
        }
    }
}
