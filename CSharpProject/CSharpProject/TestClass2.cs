using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpProject
{
    
    //1. 대리자 선언(타입임)
    delegate void EventHandlerTest(string message);
    
    
    class MyNotifier
    {
        //2. 대리자의 인스턴스를 event 한정자로 수식해서 선언
        public event EventHandlerTest SomethingHappened;

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if(temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format($"{number} : 짝"));
            }
        }
    }

    class MainApp
    {
        //3. 이벤트 핸들러를 작성
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }


        static void Main(string [] args)
        {
            //클래스 인스턴스 생성
            MyNotifier notifier = new MyNotifier();

            //인스턴스에 이벤트 핸들러 등록 (대리자에 함수 참조)
            notifier.SomethingHappened += new EventHandlerTest(MyHandler);

            for(int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i); //내부 클래스에 있는대리자 호출 되며 함수가 실행됨
            }
        }
    }
}
