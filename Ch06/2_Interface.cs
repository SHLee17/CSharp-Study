using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *-클래스간의 공동의 동일된 표준 규격을 통해 클래스 구조를 설계하는 문법
 *-인터페이스를 활용해서 다중 상속을 구현한다.
 *-인터페이스를 활용해서 객체간 결합도를 완하하는 효과를 얻는다. 다형성
 * 
*/
namespace Ch06
{
    internal class _2_Interface
    {
        static void Main1(string[] args)
        {
            LGRemocon lg = new LGRemocon();
            SamsungRemocon samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.SoundUp();
            lg.SoundDown();
            lg.PowerOff();

            samsung.PowerOn();
            samsung.ChUp();
            samsung.SoundUp();
            samsung.PowerOff();

            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();

            Bulb bulb = new Bulb();
            ISocket cable = new Cable(bulb);
        }
       


    }
}
