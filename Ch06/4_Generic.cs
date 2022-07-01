//using Ch06.Sub3;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Ch06
//{
//    /*
//     * 제네릭 p395 
//     * - 클래스 내부의 변수의 타입을 동적으로 일반화 시키는 문법
//     * - 제네릭 사용으로 클래스를 범용성을 갖도록 활용
//     * 
//     */

//    class FruitBox <T>
//    {
//        T fruit;

//        public T Fruit { get => fruit; set => fruit = value; }
//    }
//    internal class _4_Generic
//    {
//        static void Main1(string[] args)
//        {
//            Apple apple = new Apple("한국", 3000);
//            Banana banana = new Banana("대만", 4000);

//            FruitBox<Apple> box = new FruitBox<Apple>();
//            box.Fruit = apple;
//            box.Fruit.Show();

//            FruitBox<Banana> box2 = new FruitBox<Banana>();

//            box2.Fruit = banana;
//            box2.Fruit.Show();

//        }
//    }
//}
