using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class LGRemocon : IRemoteControl
    {
        public void ChDown()
        {
        }
        public void ChUp()
        {
        }
        public void PowerOff()
        {
        }

        public void PowerOn()
        {
            Console.WriteLine("왜");
        }
        public void SoundDown()
        {
        }
        public void SoundUp()
        {
        }
    }
}
