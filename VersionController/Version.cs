using System.Text;
using System.Linq;

namespace Uaine.VersionController
{
    public class Version
    {
        public int[] versionNo { get; private set; }
        public int Depth { get => versionNo.Length; }
        public string specialAttr { get; private set; }
        bool indev;
        public Version(int[] thisnum, string special, bool devbool)//leave blank if none
        {
            this.versionNo = thisnum;
            this.specialAttr = special;
            this.indev = devbool;
        }
        public void changeDevStatus(bool newstatus)
        {
            indev = newstatus;
        }
        public string ToStr()
        {
            string toadd = specialAttr;
            if (specialAttr.Length > 0)
                toadd += " ";

            StringBuilder output = new StringBuilder();
            //if indev say so
            if (indev)
                output.Append("InDev ");
            output.Append(toadd);
            for (int i = 0; i < Depth; i++)
            {
                output.Append(versionNo[i].ToString());
                if (i != Depth - 1)
                    output.Append(".");
            }
            return output.ToString();
        }
    }
}
